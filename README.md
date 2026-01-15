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
Add-Migration InitialCreate
This migration creates the `Products` table.

### **5. SQLite Database**
The migration was applied using:
Update-Database

This generated `products.db` in the project folder.

---

## 📂 Project Structure (after EF Core setup)
BlazoWebAppDemo/ │   BlazoWebAppDemo.csproj │   products.db │   Program.cs │   appsettings.json │ ├── Data/ │     Product.cs │     AppDbContext.cs │     AppDbContextFactory.cs │ ├── Migrations/ │     20260114215632_InitialCreate.cs │     BlazoWebAppDemoModelSnapshot.cs

---

## ▶️ How to Run This Branch

1. Restore packages  
2. Build the solution  
3. Run the app  
4. Confirm `products.db` exists next to the `.csproj` file  
5. Use DB Browser for SQLite to inspect the `Products` table

   ## 🔀 Next Steps

The next branch will introduce:
- Products listing page  
- Navigation  
- Basic CRUD scaffolding 









