# 👔 Atelier OS - Clothing Management System

A modern **Clothing Inventory Management System** built using **ASP.NET MVC 5, C#, SQL Server, ADO.NET, and Stored Procedures**. This application helps clothing stores manage products, customer orders, inventory, reports, and business information through a clean and professional admin dashboard.

---

## 📸 Preview

> *(Add your project screenshots here)*

- Login Page
- Dashboard
- Products
- Orders
- Reports
- Settings

---

# ✨ Features

## 🔐 Admin Authentication

- Secure Admin Login
- Session-Based Authentication
- Protected Dashboard Access
- Logout Confirmation (SweetAlert)

---

## 📊 Dashboard

- Business Overview
- Total Products
- Total Categories
- Inventory Value
- Low Stock Products
- Recent Products
- Recent Activity
- Quick Actions

---

## 👕 Product Management

- Add Product
- Edit Product
- Delete Product
- Search Products
- Product Details
- Inventory Tracking
- Category Management

---

## 📦 Order Management

- Create Order
- Edit Order
- Delete Order
- Search Orders
- Order Status

Supported Status:

- Pending
- Processing
- Completed
- Cancelled

---

## 📈 Reports

Generate Business Reports including:

- Total Products
- Total Orders
- Total Revenue
- Low Stock Products
- Recent Orders
- Download PDF Report

---

## ⚙️ Settings

Read-only System Information

- Store Name
- Owner Name
- Email
- Phone
- Address
- Application Version
- Framework
- Database
- Theme

---

# 🛠 Tech Stack

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

- SQL Server
- Stored Procedures

### Libraries

- SweetAlert2
- iTextSharp (PDF Generation)
- Remix Icons

---

# 🗂 Project Structure

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
├── Filters
└── SQL Scripts
```

---

# 📋 Modules

| Module | Status |
|---------|--------|
| Login | ✅ |
| Dashboard | ✅ |
| Products | ✅ |
| Orders | ✅ |
| Reports | ✅ |
| PDF Report | ✅ |
| Settings | ✅ |
| Search | ✅ |
| SweetAlert | ✅ |

---

# 🚀 Workflow

```
Admin Login
      │
      ▼
Dashboard
      │
 ┌────┼─────────────┐
 │    │             │
 ▼    ▼             ▼
Products Orders   Reports
 │        │          │
 ▼        ▼          ▼
CRUD    CRUD     PDF Report
 │
 ▼
Settings
```

---

# 💡 Highlights

- Modern Glassmorphism UI
- Responsive Dashboard
- Professional Sidebar Navigation
- Business Report Generation
- PDF Export
- Search Functionality
- Low Stock Monitoring
- Session-Based Authentication
- Clean Repository Pattern
- Stored Procedure Based Database Operations

---

# 🧩 Database

SQL Server Database

Main Tables

- Products
- Orders
- Admin

Stored Procedures

- USP_AddProduct
- USP_UpdateProduct
- USP_DeleteProduct
- USP_GetProducts
- USP_GetProductById
- USP_AddOrder
- USP_UpdateOrder
- USP_DeleteOrder
- USP_GetOrders
- USP_GetOrderById

---

# 🎯 Future Enhancements

- Image Upload
- Sales Analytics Charts
- Invoice Generation
- Excel Export
- Email Notifications
- Multi Admin Support
- Customer Module
- Supplier Management

---

# 👨‍💻 Developed By

**Abhishek Karande**

Java Full Stack Developer

- ASP.NET MVC
- Java
- Spring Boot
- SQL Server
- MySQL
- React

---

# ⭐ If you like this project

Give this repository a ⭐ on GitHub.
