# 👔 Atelier OS – Clothing Management System

A modern Inventory Management System built for clothing stores to simplify product management, order tracking and inventory monitoring.

Instead of maintaining products and orders in Excel sheets or paper registers, this application provides a centralized admin dashboard where everything can be managed from one place.

This project was developed as a full-stack ASP.NET MVC application following the Repository Pattern and using SQL Server Stored Procedures for database operations.

---

# 📖 About the Project

Managing inventory manually becomes difficult as the number of products and customer orders grows.

Common problems include:

- Products going out of stock without notice
- Manual revenue calculation
- Difficulty tracking customer orders
- No centralized business overview
- Time-consuming report generation

**Atelier OS** solves these problems by providing a clean admin dashboard where products, inventory and orders can be managed efficiently.

---

# ✨ Key Features

## 🔐 Authentication

- Admin Login
- Session-based Authentication
- Protected Modules
- Logout Confirmation

---

## 📊 Dashboard

The dashboard provides a quick overview of the business.

It displays:

- Total Products
- Total Categories
- Inventory Value
- Low Stock Products
- Recent Products
- Recent Orders
- Business Summary

This allows the admin to understand the overall business performance at a glance.

---

## 👕 Product Management

The Product module allows complete inventory management.

### Features

- Add Product
- Update Product
- Delete Product
- Search Products
- Product Details
- Category Management
- Inventory Tracking

Each product contains:

- Product Name
- Category
- Price
- Available Stock
- Description
- Product Image

---

## 📦 Order Management

Orders can be managed directly from the admin panel.

### Features

- Create Order
- Update Order
- Delete Order
- Search Orders

Supported Order Status

- Pending
- Processing
- Completed
- Cancelled

Total Amount is calculated automatically based on quantity and price.

---

## 📈 Reports

The Reports module generates a business summary containing:

- Total Products
- Total Orders
- Total Revenue
- Low Stock Products
- Recent Orders

The report can also be exported as a PDF.

---

## ⚙️ Settings

The Settings page contains read-only business information.

- Store Name
- Owner Information
- Contact Details
- Application Version
- Database
- Framework
- Theme

---

# 🖥 Screenshots

| Login | Dashboard |
|-------|-----------|
| *(Add Screenshot)* | *(Add Screenshot)* |

| Products | Orders |
|----------|---------|
| *(Add Screenshot)* | *(Add Screenshot)* |

| Reports | Settings |
|----------|-----------|
| *(Add Screenshot)* | *(Add Screenshot)* |

---

# 🛠 Tech Stack

### Frontend

- HTML5
- CSS3
- JavaScript
- Razor View Engine

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
- iTextSharp PDF
- Remix Icons

---

# 📂 Project Structure

```
Controllers
Models
Repository
DAL
Views
Content
Scripts
SQL Scripts
```

---

# 📋 Database Design

### Main Tables

- Admin
- Products
- Orders

### Stored Procedures

Products

- USP_AddProduct
- USP_UpdateProduct
- USP_DeleteProduct
- USP_GetProducts
- USP_GetProductById

Orders

- USP_AddOrder
- USP_UpdateOrder
- USP_DeleteOrder
- USP_GetOrders
- USP_GetOrderById

---

# 🚀 Application Workflow

```text
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
CRUD    CRUD     PDF Export
      │
      ▼
Settings
```

---

# 💡 What I Learned

While building this project I gained practical experience with:

- ASP.NET MVC Architecture
- Repository Pattern
- SQL Server Stored Procedures
- CRUD Operations
- Session Authentication
- Dashboard Design
- PDF Report Generation
- Search Functionality
- Business Logic Implementation

---

# 🔮 Future Improvements

Features planned for future versions:

- Image Upload
- Sales Analytics Dashboard
- Charts & Graphs
- Supplier Management
- Customer Management
- Invoice Generation
- Excel Export
- Email Notifications

---

# 👨‍💻 Developer

**Abhishek Karande**

Java Full Stack Developer

**Tech Interests**

- Java
- Spring Boot
- ASP.NET MVC
- SQL Server
- React
- Full Stack Development

---

## ⭐ Support

If you found this project useful, consider giving it a **⭐ Star** on GitHub.

Feedback and suggestions are always welcome.
