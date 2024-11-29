# 📚 **MVC and ASP.NET Core 8 Project: Employee Portal**

This project demonstrates an **ASP.NET Core MVC** application that integrates **Entity Framework (EF)**, **.NET Core Identity**, **Web API**, and **SQL Server** to manage employee data. The application includes login functionality, CRUD operations for employees, a contact form with email notifications, and essential user interface components.

## 🚀 **Project Overview**

In this project, we have created an **Employee Portal** with the following features:

- **User Authentication**: Login system with **.NET Core Identity**.
- **Employee Data Management**: CRUD operations for employees stored in a SQL database.
- **Web API**: For deleting employee records via a RESTful API.
- **Search Functionality**: Filter employee records by first name.
- **Contact Us**: A form submission system to send an email with form data.
- **Logout**: Users can log out and be redirected to the home page.

---

## 📑 **Project Requirements**

- **ASP.NET Core 8**
- **Visual Studio** (any version supporting .NET 8)
- **SQL Server** (for database management)
- **Email Server Configuration** (for contact form email functionality)

---

## 🛠 **Setup Instructions**

### 1. **Create the Project**
1. Create a new **ASP.NET Core MVC 8 Project** in Visual Studio.
2. Name the solution appropriately (e.g., **EmployeePortal**).

---

## 🖥 **Database Configuration**

1. **Create Database**: 
   - Create a new database named **Employees** in **SQL Server**.

2. **Set Up Entity Framework (EF)**:
   - Use **Entity Framework (EF)** to connect your MVC application to the **Employees** database.
   - Define a model class that corresponds to the Employee table.
   - Use **Code First Migrations** to ensure the database schema matches the model.

---

## 🏡 **Home Page: Authentication & Redirection**

1. **Integrate .NET Core Identity** for **login functionality**:
   - Create an **Identity system** that enables user registration and login.
   - After a successful login, users should be redirected to the **Employees** page.
   - If an **unauthenticated user** tries to access the **Employees** page directly, they should be redirected back to the **Home** page to log in.

### **Login Credentials**
- **Email**: `admin.digiwhiz@gmail.com`
- **Password**: `admin$123`

---

## 👨‍💻 **Employees Page: CRUD Operations**

1. **Retrieve Employees Data**:
   - Display a table with employee details (First Name, Last Name, Email).
   - Retrieve all employee data from the database using **Entity Framework (EF)**.

2. **Web API**:
   - Create a **Web API** that handles the deletion of employee records.
   - Implement a **Delete** button in the employee table to trigger this Web API and remove records.

3. **Search Functionality**:
   - Implement search functionality based on the employee’s **First Name**.
   - Add a **Show All** button that removes the search filter and displays all records again.

---

## 📧 **Contact Us Page: Form Submission & Email**

1. **Create a Contact Us Form**:
   - Design a form that allows users to submit their information (Name, Email, Message).
   - Integrate **form validation** to ensure that the fields are correctly filled out.

2. **Email Notification**:
   - Upon form submission, send an email containing the form data to a predefined email address.

   ### **Email Setup**
   - **Email Service Setup**: Configure the email credential in inside EmailRepository 
