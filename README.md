# 🚗 Driving & Vehicles License Department (DVLD) System

A robust, enterprise-grade Desktop Application designed to digitize and manage the core operations of a Driving and Vehicles License Department. Built using C#, Windows Forms, and SQL Server, strictly following a 3-Tier Software Architecture.

---

## 🏗️ Architecture & Project Structure

The solution is divided into three distinct layers to ensure full separation of concerns, maintainability, and scalability:

* DVLD (Presentation Layer): Windows Forms UI handling user interactions, custom controls, and visual validation.
* DVLD_BLL (Business Logic Layer): Encapsulates core business rules, validation logic, calculations, and layer communication.
* DVLD_DAL (Data Access Layer): Direct database operations using ADO.NET and T-SQL queries/stored procedures.

DVLD_Project/
├── DVLD/                  # Presentation Layer (WinForms UI)
├── DVLD_BLL/              # Business Logic Layer
├── DVLD_DAL/              # Data Access Layer
└── DVLD.sln               # Solution File

---

## ✨ Key Features & Modules

* 👤 People Management: Centralized person profile system with photo support, national ID validation, and full CRUD operations.
* 🔑 User & Security Management: System user authentication, access control, and password encryption logic.
* 📋 Application Management: Support for various application types (New Driving License, Renewals, Replacements for Lost/Damaged).
* 📜 License Management: Issuing local and international driving licenses with detailed tracking and validity rules.
* 📝 Testing & Appointment System: Multi-stage testing workflow (Vision, Written, Street Test) with appointment management.
* 🚫 License Detention System: Detaining, releasing, and managing fine payments for violating licenses.

---

## 🛠️ Tech Stack & Tools

* Language: C#
* Framework: .NET Framework (Windows Forms)
* Database: Microsoft SQL Server
* Data Access: ADO.NET
* IDE: Microsoft Visual Studio
* Version Control: Git & GitHub

---

## 🚀 How to Run the Project

1. Clone the Repository:
   git clone https://github.com/Haider-Development/DVLD.git

2. Database Setup:
   * Restore/Import the SQL database script into your local SQL Server Management Studio (SSMS) instance.
   * Update the connection string inside DVLD_DAL to point to your local server.

3. Run Solution:
   * Open DVLD.sln in Visual Studio.
   * Set DVLD (Presentation Layer) as the Startup Project.
   * Build and run (F5).

---

## 👨‍💻 Developed By

Haider Tarraf
* GitHub: [@Haider-Development](https://github.com/Haider-Development)
* Linkedin: [www.linkedin.com/in/haider-m-tarraf]
