# Lumos – Light Store (Portfolio Project)

A responsive online lighting store with a **React** frontend and an **ASP.NET Core Web API** backend. The API is hosted on **Azure** and serves product data from **Azure SQL Database**.

Visit the [Lumos storefront](https://lumos-peach.vercel.app) or view the [Figma prototype](https://www.figma.com/proto/DCGOOoQtu7mB2CuXVNoSvk/Lumos?page-id=0%3A1&node-id=6-2&p=f&viewport=127%2C61%2C0.22&t=WGOCdKC5SPJOe3ZC-1&scaling=scale-down&content-scaling=fixed&starting-point-node-id=6%3A2).

## ✨ Features

- Browse lighting products loaded from the backend API
- Filter products by type and browse themed collections
- View product details and add products to the shopping cart
- Adjust cart quantities; cart contents persist in browser local storage
- Responsive pages built with React Bootstrap and React Router

## 🔧 Tech Stack

- **Frontend:** React 19, JavaScript (ES6+), React Router DOM, React Bootstrap, Bootstrap 5, React Icons, CSS
- **Build tool:** Vite
- **Backend:** ASP.NET Core Web API and .NET 10
- **Database:** Azure SQL Database, accessed with Entity Framework Core
- **Hosting:** Vercel (frontend) and Azure (API)
- **Data import:** .NET console application and JSON
- **Testing:** Jest and React Testing Library

## 📁 Folder Structure

```text
backend/
├── Controllers/       API controllers
├── Data/              Entity Framework database context
├── Migrations/        Entity Framework migrations and model snapshot
├── Models/            Database models
├── Program.cs         API startup and service configuration
└── backend.csproj

DataImporter/
├── Program.cs         Imports product records into the database
└── DataImporter.csproj

frontend/
├── public/             Static public assets
├── src/
│   ├── components/     Shared UI, cart context, and hooks
│   ├── img/            Frontend images and logos
│   ├── pages/          Shop and collection pages
│   ├── App.jsx         Application routes and layout
│   └── index.jsx       Frontend entry point
├── package.json
└── vite.config.mjs
```

## 📝 Notes

The frontend fetches product and collection data from the ASP.NET Core API hosted on Azure. The API uses Entity Framework Core to read product information from Azure SQL Database.

The `DataImporter` console app can import product records from a JSON file. Configure its SQL Server connection string and provide the catalog JSON file before running it. Keep credentials out of source control.

## 📌 Goals

- Build a complete e-commerce experience with a React frontend and .NET API
- Practice component-based UI development, routing, and responsive design
- Work with Entity Framework Core and Azure SQL Database

## 📫 Contact

Feel free to reach out via [LinkedIn](https://www.linkedin.com/in/yevheniia-lukianchykova/) if you'd like to connect!
