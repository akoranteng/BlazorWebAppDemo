# BlazorWebAppDemo
“A structured Blazor Web App demonstrating database integration, CRUD workflows, and scalable .NET architecture.
📌 Project Overview
This project is a clean, modular Blazor Web App designed for teaching and demonstrating:
- Blazor component structure
- EF Core integration
- SQLite database setup
- CRUD workflows
- Clean Git branching strategies
- Professional project organization
The goal is to create a reproducible, curriculum‑ready template that learners can follow step by step.
📁 Branch Structure (Teaching Pipeline)
Each branch represents a self‑contained teaching milestone:
|  |  | 
| 01-setup-efcore | ProductAppDbContext | 
| 02-ui-products-list |  | 
| 03-ui-product-create |  | 
| 04-ui-product-edit |  | 
| 05-ui-product-delete |  | 


This structure keeps the project modular and easy to teach.
🗄️ Database Setup (EF Core + SQLite)
- EF Core is configured using SQLite for simplicity and portability
- Migrations are stored in the Migrations/ folder
- The .gitignore excludes runtime database files:
*.db
*.sqlite


This prevents volatile database files from polluting the repo.
🧱 Models
Product.cs
A simple model used throughout the CRUD workflow:
- Id
- Name
- Description
- Price
- Quantity

🧩 Lessons Learned (from the first attempt)
1. Folder structure matters
Visual Studio’s “Place solution and project in the same directory” can cause confusion.
A clean repo should look like:
BlazorWebDemoApp/
    BlazorWebDemoApp/
        Data/
        Pages/
        Migrations/

2. Git only sees files relative to your working directory
Running Git commands from the wrong folder leads to missing file errors.
3. .gitignore must be correct before migrations
Ignoring .db and .sqlite prevents accidental commits of runtime databases.
4. EF Core migrations must be run from the correct project
Running migrations from the wrong directory results in missing folders or misplaced files.
5. Keep paths short
Long Windows paths can break MAUI/Android builds and cause friction in .NET projects.
   
⚠️ Gotchas to Avoid
- Don’t commit .vs/ or runtime database files
- Don’t run migrations from the solution root
- Don’t mix solution and project files in the same directory
- Don’t skip the .gitignore setup
- Don’t rely on Solution Explorer to reflect the actual disk structure

🚀 Next Steps
- Scaffold the Products list page
- Add Create/Edit/Delete pages
- Add validation
- Add navigation
- Expand the README with screenshots and diagrams
   








