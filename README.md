# Library Management System

## Table of Contents
- [Overview](#overview)
  - [Section A - Brief Function of the System](#section-a---brief-function-of-the-system)
  - [Section B - Acknowledgment of AI and External Resources](#section-c---acknowledgment-of-ai-and-external-resources)

---

## Overview
This Library Management System is designed to manage and streamline library operations efficiently. It provides two distinct user profiles with different privileges, ensuring users only access functions relevant to their role.  

---

## Section A - Brief Function of the System

### User Profiles
The system has **two profiles**:

1. **Librarian Profile**  
2. **Manager Profile**  

Having separate profiles allows different roles and privileges, for example, giving the librarian the ability to manage staff without granting unnecessary access to other system functions.  

### 1. Librarian Profile Functions
The Librarian profile contains **6 main functions**, each with sub-functions:

1. **Adding a New Student**  
   - Captures student details (email, name, surname, cellphone).  
   - Stores data in the database for future reference (e.g., linking student to borrow records).  
   - Helps the organization track borrowers efficiently.  

2. **View Books Offered by the Library**  
   - Displays how many bookings have been made for a particular book.  

3. **Issuing a Book to Students**  
   - Links a student to the borrowed book.  

4. **Reservations**  
   - **View the Database:** Displays existing reservations.  
   - **Add a Reservation:** Allows students to queue for a book if fully booked. The earliest reservation is notified when the book becomes available.  

5. **Returning a Book**  
   - Marks if a student has returned a borrowed book.  

6. **Borrow History**  
   - Allows the librarian to view the history of borrowed books.  

### 2. Manager Profile Functions
The Manager profile contains **6 main functions** (3 active functions):

1. **View All Database Tables**  
   - Provides an overview of all tables.  

2. **Manage Library Staff**  
   - Enables the manager to add, modify, or delete library staff.  

3. **Add New Book**  
   - Adds a new book to the inventory with quantity details.  

4. **View Overdue Bookings**  
   - Displays students who have not returned books within the due date and allows contact using their information.  

5. **View Statistics**  
   - Shows analytics about library performance and areas for improvement.  

6. **Coming Soon Feature**  
   - Placeholder for future enhancements.  

---

