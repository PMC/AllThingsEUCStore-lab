# AllThingsEUCStore-lab

Welcome to the AllThingsEUCStore-lab repository! This repository contains the code for a comprehensive End-User Computing (EUC) Store lab, designed to provide a practical and educational environment for exploring the functionalities and capabilities of an EUC store application.


## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Database](#database)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The AllThingsEUCStore-lab is a project that simulates an EUC store environment. It is designed for educational purposes, allowing users to interact with and understand the workings of an EUC store application. The project includes a web interface for managing products and orders.

## Features

- **Product Management**: Add, update, and delete products in the store.
- **Order Management**: Create and manage customer orders.
- **SQLite Database**: Uses SQLite for data storage, ensuring a lightweight and easy-to-use database solution.
- **RESTful API**: StoreApi provides a RESTful API to interact with the database.

## Technologies Used

- **HTML**: 56.4%
- **Blazor C#**: 43.3%
- **CSS**: 0.3%

## Setup and Installation

To set up the project locally, follow these steps:

1. **Clone the repository**:
    ```bash
    git clone https://github.com/PMC/AllThingsEUCStore-lab.git
    cd AllThingsEUCStore-lab
    ```

2. **Run the Store API**:
    - Ensure you have the .NET SDK installed on your machine.
    - Navigate to the project directory and restore the dependencies:
    ```bash
    cd StoreApi
	dotnet run -lp https
    ```

3. **Run the Web Application**:
    ```bash
	cd WebApp
    dotnet run
    ```

## Usage

Once the application is running, you can access the web interface by navigating to 
`https://localhost:7266/`
or
`http://localhost:5050` in your web browser.


## Store API

To interact with the database, you can use the provided RESTful API endpoints.
The API documentation is available in the `StoreApi` project directory.

Navigate to https://localhost:7110/scalar/v1.666 to access the Store API.

## Database

The project uses an SQLite database, which is provided by the `StoreApi`. The database file is included in the project, and the connection string is configured in the `appsettings.json` file.

 

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

---

## Example Post for order:

{
  "customerId": "5f5a3c1c-3e38-49a0-b2c4-0b702b2b73d6",
  "firstName": "John",
  "lastName": "Doe",
  "address1": "Doe road 666",
  "address2": "",
  "city": "Doe City",
  "zipCode": "666 33",
  "email": "john@doe.com",
  "phoneNumber": "+46000333",
  "totalAmount": 1,
  "status": "pending",
"orderItems": [
    {
      "productId": 1,
      "quantity": 1
    },
    {
      "productId": 7,
      "quantity": 2
    }	
  ]
}
