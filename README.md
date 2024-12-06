# Shopping System in C#

This project implements a **Shopping System** using **Object-Oriented Programming (OOP)** principles in C#. It allows users to manage a shopping experience with features like viewing products, adding items to a cart, placing orders, and undoing actions.

---

## Features

- **Display Available Products**: View a list of available products with their details (name, price, stock).
- **Add Product to Cart**: Add products to the shopping cart and reduce their stock.
- **View Cart**: Check the items in your cart, their quantities, and the total price.
- **Remove Product from Cart**: Remove a product from the cart and restore its stock.
- **Place an Order**: Finalize the purchase, clear the cart, and view the order summary.
- **Undo Last Action**: Undo the last action (e.g., adding or removing an item).
- **Exit**: Exit the application.

---

## Project Structure

### Classes
- **`Product`**: Represents a product with properties like `Id`, `Name`, `Price`, and `Stock`.
- **`CartItem`**: Represents an item in the shopping cart with the product and its quantity.
- **`ShoppingCart`**: Handles adding, removing, and viewing items in the cart.
- **`Action`**: Represents an action (Add/Remove) for undo functionality.
- **`ActionHistory`**: Maintains a history of actions for the undo feature.
- **`Shop`**: Manages the overall system, coordinates user interactions, and handles products and the cart.

---


