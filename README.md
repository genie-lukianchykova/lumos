# Lumos – Light Store (Portfolio Project)

A simple and elegant online lighting store built with **React** and **React Bootstrap**.  
This project is part of my frontend developer portfolio to demonstrate my skills in building responsive, component-based UIs.
You can visit the website [here](https://lumos-shop.onrender.com).
See Figma prototype [here](https://www.figma.com/proto/DCGOOoQtu7mB2CuXVNoSvk/Lumos?page-id=0%3A1&node-id=6-2&p=f&viewport=127%2C61%2C0.22&t=WGOCdKC5SPJOe3ZC-1&scaling=scale-down&content-scaling=fixed&starting-point-node-id=6%3A2) 

## ✨ Features

- Product catalog of lamps and light fixtures loaded from the backend API
- Filter products by type and browse themed collections
- View product details and add items to the shopping cart
- Cart quantities and items saved in browser local storage
- Responsive layout and page navigation using React Bootstrap and React Router

## 🔧 Tech Stack

- **React**
- **React Bootstrap**
- **React Router DOM**
- **JavaScript (ES6+)**
- **CSS / Bootstrap 5**

## 📁 Folder Structure
```
src/
├── components/
├── pages/
├── data/
├── App.js
├── index.js
```

## 📝 Notes

- The React frontend gets product and collection data from the ASP.NET Core API.
- Product information is stored in a SQL Server database and accessed with Entity Framework Core.
- The `DataImporter` console app can import product data from a JSON file into the database.

## 📌 Goals

- Practice building a functional e-commerce interface
- Work with React component structure and routing
- Implement a clean, responsive layout using Bootstrap

## 🖥️ Backend

The project also includes an ASP.NET Core Web API built with .NET 10. It serves product data from a SQL Server database through the `GET /api/items` endpoint, using Entity Framework Core for database access and migrations.

## 📫 Contact

Feel free to reach out via [LinkedIn](www.linkedin.com/in/yevheniia-lukianchykova) if you'd like to connect!
