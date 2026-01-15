# 01 – EF Core Setup (SQLite + Product Model + Initial Migration)

This branch introduces the foundational data layer for the **BlazorWebAppDemo** project.  
It configures Entity Framework Core with SQLite, defines the `Product` entity, creates the `AppDbContext`, and applies the first migration to generate the `products.db` database.

---

## ✅ What Was Added in This Branch

### **1. Product Entity**
A simple model representing products in the system:
- `Id` (int, primary key)
- `Name`
- `Description`
- `Price`

### **2. AppDbContext**
The EF Core database context that exposes:
- `DbSet<Product> Products`

### **3. AppDbContextFactory**
A design‑time factory enabling EF Core CLI and PowerShell migrations.

### **4. InitialCreate Migration**
Generated using: