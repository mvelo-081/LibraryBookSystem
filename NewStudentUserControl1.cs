using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class NewStudentUserControl1 : UserControl
    {
        private Panel homePagePanel;

        private Button menuBtn;

        string connectionString = ConfigurationManager.ConnectionStrings["LibraryBookSystem.Properties.Settings.ist2koConnectionString"].ConnectionString;

        public NewStudentUserControl1(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            cancelBtn.Click += handleCancelBtn;

            newStudentBtn.Click += handleNewStudentBtn;
        }

        private void handleCancelBtn(object sender, EventArgs e)
        {
            menuBtn.Visible = false;
            
            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new MenuUserControl(homePagePanel, menuBtn));
        }
        private bool isDataValid()
        {
        string email = emailTextData.Text;
        string name = studentNameData.Text;
        string surname = StudentSurnameData.Text;
        string cellphone = cellPhoneNumberTextData.Text;

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(surname) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(cellphone))
        {
            ErrorLabel.Text = "All fields are required.";
            ErrorLabel.Visible = true;
            return false;
        }

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (!Regex.IsMatch(email, emailPattern))
        {
            ErrorLabel.Text = "Invalid email format.";
            ErrorLabel.Visible = true;
            return false;
        }

        string phonePattern = @"^\d{10}$";
        if (!Regex.IsMatch(cellphone, phonePattern))
        {
            ErrorLabel.Text = "Cellphone number must be 10 digits.";
            ErrorLabel.Visible = true;
            return false;
        }

        return true;
    }
        private Boolean isAlreadyRegistered()
        {
            string email = emailTextData.Text;

            string query = "SELECT COUNT(*) FROM Student WHERE Student_Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        ErrorLabel.Text = "A student with this email is already registered.";
                        ErrorLabel.Visible = true;
                        return true;
                    }
                }
            }

            return false;
        }

        private void handleNewStudentBtn(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();

            if (isAlreadyRegistered())
            {
                return;
            }


            string query = @"INSERT INTO Student 
                            (Student_FName, Student_LName, Student_Email, Student_CellPhoneNo)
                            OUTPUT INSERTED.StudentID
                            VALUES (@name, @surname, @email, @cellphone)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if(isDataValid())
                    {
                        command.Parameters.AddWithValue("@name", studentNameData.Text);
                        command.Parameters.AddWithValue("@surname", StudentSurnameData.Text);
                        command.Parameters.AddWithValue("@email", emailTextData.Text);
                        command.Parameters.AddWithValue("@cellphone", cellPhoneNumberTextData.Text);

                        int newStudentId = (int)command.ExecuteScalar();
                        if (newStudentId.ToString() != null)
                        {
                            ErrorLabel.ForeColor = Color.Green;
                            ErrorLabel.Text = "New student added successfully!";
                            ErrorLabel.Visible = true;
                        }
                        else
                        { 
                            ErrorLabel.Text = "Failed to add new student. Please try again.";
                            ErrorLabel.Visible = true;
                        }
                        studentNameData.Clear(); StudentSurnameData.Clear(); emailTextData.Clear(); cellPhoneNumberTextData.Clear();
                        connection.Close();
                    }
                    else
                    {
                        connection.Close();
                    }
                }
            }
            
        }
    }
}
