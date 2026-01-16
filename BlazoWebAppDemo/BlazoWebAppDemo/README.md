# 02-ui-counter-fetchdata

This branch completes the foundational UI for the Blazor Web App by adding the **Counter** and **Fetch Data** pages and wiring them into the existing navigation and layout. These pages finalize the starter experience and ensure the application feels functional and cohesive before moving into the Product CRUD workflow.

---

## 🎯 Purpose of This Branch

This branch focuses on:

- Adding the **Counter** page (`/counter`)
- Adding the **Fetch Data** page (`/fetchdata`)
- Creating the supporting **WeatherForecast** model and service
- Registering the service in `Program.cs`
- Ensuring both pages render correctly within the custom layout
- Verifying navigation links work end‑to‑end

This completes the baseline UI that every Blazor Web App typically starts with.

---

## 📁 Files Added in This Branch

### Components/Pages/
- `Counter.razor`
- `FetchData.razor`

### Data/
- `WeatherForecast.cs`
- `WeatherForecastService.cs`

### Program.cs
- Added DI registration for `WeatherForecastService`

---

## 🧩 Key Features Implemented

### 1. Counter Page
A simple interactive component demonstrating:

- Event handling  
- State updates  
- Component rendering  

### 2. Fetch Data Page
A data‑driven component demonstrating:

- Dependency injection  
- Async data loading  
- Table rendering with Bootstrap  
- Component lifecycle (`OnInitializedAsync`)  

### 3. Weather Forecast Service
A lightweight in‑memory service that returns sample weather data for the Fetch Data page.

### 4. Navigation Integration
Both pages are now fully accessible from the sidebar navigation.

---

## 🚀 How to Test This Branch

Run the application and navigate to:

- `/counter`
- `/fetchdata`

Or use the sidebar links.

You should see:

- A working counter with increment logic  
- A fully rendered weather forecast table  
- Clean Bootstrap styling  
- Smooth navigation within the custom layout  

---

## 📚 Learning Outcomes

By the end of this branch, learners understand:

- How to add new pages to a Blazor Web App  
- How routing works under `Components/Pages`  
- How to inject and consume services  
- How to render dynamic data in Razor components  
- How to integrate new UI pages into a custom layout and navigation  

This sets the stage for the next major milestone: **building the Products List page** and beginning the CRUD workflow.