# 👔 Atelier OS - Clothing Management System

Atelier OS is a simple Clothing Inventory Management System built using **ASP.NET MVC 5**, **C#**, and **SQL Server**.

I built this project to practice full-stack development by creating a real-world application. The system helps a store owner manage products, customer orders, inventory, and business reports from one dashboard.

---

## 📌 Why I Built This

While learning ASP.NET MVC, I wanted to build more than just a basic CRUD project.

A clothing inventory system allowed me to work with different modules like products, orders, reports, authentication, and dashboard design in a single application.

This project helped me understand how a real business application is developed.

---

# ✨ Features

## 🔐 Admin Login

- Secure Admin Login
- Session Authentication
- Logout Confirmation

---

## 📊 Dashboard

The dashboard gives a quick overview of the business.

It shows:

- Total Products
- Total Categories
- Inventory Value
- Low Stock Products
- Recent Products
- Recent Orders

---

## 👕 Product Management

The admin can:

- Add Products
- Edit Products
- Delete Products
- Search Products

Each product includes:

- Product Name
- Category
- Price
- Stock
- Description
- Product Image

---

## 📦 Order Management

The admin can:

- Create Orders
- Update Orders
- Delete Orders
- Search Orders

Order status includes:

- Pending
- Processing
- Completed
- Cancelled

The total amount is calculated automatically.

---

## 📄 Reports

The Reports page shows:

- Total Products
- Total Orders
- Total Revenue
- Low Stock Products
- Recent Orders

Reports can also be downloaded as a PDF.

---

## ⚙️ Settings

The Settings page displays:

- Store Information
- Owner Details
- Application Version
- Database
- Framework

These details are read-only.

---

# 🛠 Tech Stack

### Frontend

- HTML
- CSS
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
- iTextSharp
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

# 🚀 Project Workflow

```
Admin Login
      │
      ▼
Dashboard
      │
 ┌────┼────────────┐
 │    │            │
 ▼    ▼            ▼
Products Orders  Reports
 │       │         │
 ▼       ▼         ▼
CRUD    CRUD    PDF Report
      │
      ▼
Settings
```

---

# 📚 What I Learned

While building this project, I learned:

- ASP.NET MVC Architecture
- CRUD Operations
- SQL Server Stored Procedures
- Repository Pattern
- Session Authentication
- Dashboard Design
- PDF Generation
- Building a complete business application

---

# 🔮 Future Improvements

Some features I would like to add in the future:

- Image Upload
- Sales Charts
- Excel Export
- Invoice Generation
- Customer Module
- Supplier Management

---

# 👨‍💻 Developed By

**Abhishek Karande**

B.Tech Information Technology

I enjoy building practical web applications and improving my backend development skills.

If you have any suggestions or feedback, feel free to share them.

⭐ If you like this project, please consider giving it a star.
