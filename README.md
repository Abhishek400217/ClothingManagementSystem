# 👔 Atelier OS – Clothing Management System

Atelier OS is a Clothing Inventory Management System built using **ASP.NET MVC 5**, **C#**, and **SQL Server**.

The goal of this project is to help clothing stores manage their daily operations from a single dashboard. It allows the admin to manage products, customer orders, inventory, and business reports in a simple and organized way.

This project was built to gain practical experience with ASP.NET MVC architecture, SQL Server, ADO.NET, and real-world business workflows.

---

## 🚀 Project Overview

Managing products and customer orders manually can become difficult as the business grows.

Atelier OS provides a simple admin panel where everything can be managed in one place. From adding new products to generating business reports, the system is designed to make inventory management easier and more organized.

---

# ✨ Features

## 🔐 Admin Authentication

- Secure Admin Login
- Session-Based Authentication
- Protected Dashboard Access
- Logout Confirmation

---

## 📊 Dashboard

The dashboard gives a quick overview of the business.

It displays:

- Total Products
- Total Categories
- Inventory Value
- Low Stock Products
- Recent Products
- Recent Orders
- Business Summary

This helps the admin understand the current business status without checking multiple pages.

---

## 👕 Product Management

The Product module allows the admin to manage the complete inventory.

Features include:

- Add Product
- Edit Product
- Delete Product
- Search Products
- Manage Product Details

Each product stores:

- Product Name
- Category
- Price
- Available Stock
- Description
- Product Image

---

## 📦 Order Management

The Order module helps manage customer orders.

The admin can:

- Create Orders
- Update Orders
- Delete Orders
- Search Orders

Supported order status:

- Pending
- Processing
- Completed
- Cancelled

The total amount is calculated automatically based on quantity and price.

---

## 📄 Reports

The Reports module provides a quick business summary.

It includes:

- Total Products
- Total Orders
- Total Revenue
- Low Stock Products
- Recent Orders

Reports can also be downloaded as a PDF.

---

## ⚙️ Settings

The Settings page contains important system information in read-only mode.

It displays:

- Store Information
- Owner Details
- Contact Information
- Application Version
- Framework
- Database

---

# 🛠️ Tech Stack

### Frontend

- HTML5
- CSS3
- JavaScript
- Razor Views

### Backend

- ASP.NET MVC 5
- C#
- ADO.NET
- Repository Pattern

### Database

- Microsoft SQL Server
- Stored Procedures

### Libraries

- SweetAlert2
- iTextSharp
- Remix Icons

---

# 📂 Project Structure

```
ClotheManagementSystem
│
├── Controllers
├── Models
├── Repository
├── DAL
├── Views
├── Content
├── Scripts
└── SQL Scripts
```

---

# 📋 Main Modules

- Dashboard
- Product Management
- Order Management
- Reports
- Settings
- Authentication

---

# 🔄 Application Workflow

```
Admin Login
      │
      ▼
Dashboard
      │
 ┌────┼──────────────┐
 │    │              │
 ▼    ▼              ▼
Products Orders    Reports
 │        │            │
 ▼        ▼            ▼
CRUD    CRUD      PDF Report
      │
      ▼
Settings
```

---

# 📚 What I Learned

Building this project helped me improve my understanding of:

- ASP.NET MVC Architecture
- CRUD Operations
- SQL Server Stored Procedures
- Repository Pattern
- Session-Based Authentication
- Business Dashboard Design
- PDF Report Generation
- Building a complete inventory management system

---

# 🔮 Future Improvements

Some features I plan to add in future versions:

- Product Image Upload
- Sales Analytics Dashboard
- Excel Export
- Invoice Generation
- Customer Management
- Supplier Management

---

# 👨‍💻 Developed By

**Abhishek Karande**

B.Tech Information Technology

Passionate about building practical web applications and continuously improving my full-stack development skills.

If you have any suggestions or feedback, feel free to connect with me.

⭐ If you found this project helpful, consider giving it a star.
