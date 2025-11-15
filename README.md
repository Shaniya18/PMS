Here is your **properly formatted, professional, clean, and organized README** for the *Pharmacy Management System (PMS)* — ready to paste into GitHub:

---

# **Pharmacy Management System (PMS)**

A comprehensive **Pharmacy Management System** built with **VB.NET** and **SQL Server**, designed to streamline pharmacy operations through efficient billing, inventory management, prescription handling, and secure transaction processing.

---

## 📋 **Table of Contents**

* Overview
* Features
* Technologies Used
* Project Structure
* Installation & Setup
* Usage
* Database Integration
* Screenshots
* Contributing
* License
* Support

---

## 🏥 **Overview**

The **Pharmacy Management System (PMS)** automates and manages daily pharmacy operations.
It provides a user-friendly interface for pharmacists and administrators to manage billing, inventory, prescriptions, and reports while ensuring secure and accurate data handling.

---

## ⚡ **Features**

### 🔐 **Authentication & Security**

* Role-Based Login System (Administrator & Pharmacist)
* Secure access control for sensitive operations

### 💰 **Billing & Sales**

* Integrated billing system for smooth sales processing
* Automatic inventory deductions after each sale
* Prescription-based sales support
* Strong data validation for accurate recording

### 📦 **Inventory Management**

* Real-time stock tracking
* Low stock alert system
* Comprehensive inventory reports

### 📊 **Reporting & Analytics**

* Daily, weekly, and monthly sales reports
* Top-selling product analysis
* Full inventory status reporting
* Custom date range reporting options

### 👥 **User Management**

* Administrator: Full control of system settings
* Pharmacist: Daily operations, billing, and inventory

---

## 🛠 **Technologies Used**

* **Frontend:** VB.NET (Windows Forms)
* **Backend:** .NET Framework
* **Database:** SQL Server
* **Architecture:** Client-Server Model
* **Data Access:** ADO.NET

---

## 📁 **Project Structure**

```
PMS/
├── My Project/
│   ├── Application.Designer.vb
│   ├── AssemblyInfo.vb
│   ├── Resources.resx
│   ├── Settings.settings
│   └── PMS Database.mdf
├── Forms/
│   ├── Login Form.vb
│   ├── Admin_MainPage.vb
│   ├── Pharmacist_MainPage.vb
│   ├── Inventory Management.vb
│   ├── Billing Form.vb
│   ├── Prescription Management.vb
│   └── ReportsForm.vb
├── Modules/
│   └── Database Module.vb
├── Data/
│   ├── PMS Database.mdf
│   └── PMS Database_log.ldf
└── Configuration/
    ├── App.config
    └── Settings.settings
```

### **Key Components**

* **Login Form:** User authentication and role management
* **Admin Main Page:** System control and user management
* **Pharmacist Main Page:** Daily operational interface
* **Inventory Management:** Stock control and updates
* **Billing Form:** Sales and transaction processing
* **Prescription Management:** Handles prescription-based sales
* **Reports Form:** Generate sales and inventory reports

---

## ⚙️ **Installation & Setup**

### **Prerequisites**

* Windows OS
* .NET Framework 4.5+
* SQL Server Express or higher
* Visual Studio

### **Steps**

#### 1. Clone the Repository

```bash
git clone https://github.com/Shaniya18/PMS.git
```

#### 2. Database Setup

* Attach **PMS Database.mdf** to SQL Server
* Update the connection string in **App.config** if necessary

#### 3. Build the Solution

* Open **PMS.sln** in Visual Studio
* Restore NuGet packages (if needed)
* Build the solution (`Ctrl + Shift + B`)

#### 4. Run the Application

* Set **PMS** as the startup project
* Run (`F5`)

---

## 🚀 **Usage**

### **For Pharmacists**

* Log in using pharmacist credentials
* View dashboard
* Process sales via the Billing Form
* Manage inventory (view/update stock)
* Generate sales and inventory reports

### **For Administrators**

* Log in using admin credentials
* Manage system users
* Access all inventory and sales modules
* View full reports and analytics

---

## 🗄 **Database Integration**

The system uses **SQL Server** with strong data integrity and optimized queries.

### Key Features:

* ADO.NET for database communication
* Transaction log handling
* Constraints for accurate data integrity
* Stored procedures for optimized operations

### **Main Tables**

* **Users:** Login info & roles
* **Inventory:** Product stock and details
* **Sales:** Transaction data
* **Prescriptions:** Prescription sales
* **Reports:** Reporting history

---

## 📸 **Screenshots**

### **Pharmacist Main Page**

![Pharmacist Main Page](https://github.com/Shaniya18/PMS/raw/master/images/Pharmacist%2520MainPage.png)

*Features menu navigation for Dashboard, Inventory, Billing, Reports, and Logout.*

---

