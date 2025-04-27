# Short Info
Project will be a E-Commerce website, selling EUCs and Accessories.
Will contain a Cart, Tree view or similar of categories, items for sale (EUCs and accessories)
Admin side will contain users with roles, order handling, CRUD items for sale.

See Tasks for breakdown

## Frontend and Backend breakdown
### Backend
	- Authentication and Authorization using a guide to avoid "template hell" and overly complicated user tables (SQL)
	- Rolles: Admin and Customer
	- API (OpenApi) for access to database, actually not needed but good for training and showcase

#### Database - SQLIte
	- Design Tables

### Frontend
	- Front Page
	- Header
	- Navbar menu with categories, like brand, suspension, etc
	- Information about the project
	- Footer with links
	- Items with filter possibilities (search basically)
	- Description of items - Detail, Spec, nr of items in store, price etc
	- Add to cart
	- Contact page (if got time)
	- About page

#### Frontend Auth
	- Register, first user will be assigned Admin role
	- Login
	- Use address for Cart
	- Must login to proceed with buying items from the cart
	- Cart handling

#### Frontend Admin
	- CRUD items in the store
	- CRUD Categories
	- View new unhandled orders
	- View old orders
	- View all orders
	- View Users
	- Assign Roles
	- Contact messages

## *** Tasks Breakdown ***

### Tasks Category: Foundations and Establish the core authentication and registration functionality
	- Set up the frontend project structure.
	- Plan the authentication flow (e.g., JWT, session-based).
	- Design the registration and login forms.
	- Implement the user registration form.
	- Connect the registration form to the backend API.
	- Implement the logic to assign the first registered user as an admin.
	- Implement the user login form.
	- Connect the login form to the backend API.
	- Store the authentication token (e.g., in local storage or cookies).
	- Basic testing of registration and login.

### Tasks Category: Cart & User Address Integration
	- Design and implement the cart data structure (e.g., array of items).
	- Implement functions to add, remove, and update items in the cart.
	- Implement the display of the cart.
	- Create the user address form.
	- Connect the address form to the user profile in the backend.
	- Allow the user to save and edit their address.
	- Implement the logic to require login before proceeding to checkout.
	- Integrate the user's address into the cart/checkout process.

### Tasks Category: Develop the core admin functionalities for managing store items and categories
	- Create the admin dashboard layout.
	- Implement the "Create Item" functionality (form, API integration).
	- Implement the "Read Items" functionality (display items in a table/list).
	- Implement the "Update Item" functionality (form, API integration).
	- Implement the "Delete Item" functionality (confirmation, API integration).
	- Implement the "Create Categories" functionality (form, API integration).
	- Implement the "Read Categories" functionality (display Categories in a table/list).
	- Implement the "Update Categories" functionality (form, API integration).
	- Implement the "Delete Categories" functionality (confirmation, API integration).

### Tasks Category: Implement the remaining admin functionalities for order management, user management, and contact messages
	- Implement the "View New Unhandled Orders" functionality (API integration, display).
	- Implement "View Old Orders" and "View all orders".
	- Implement the order detail view.
	- Implement the "View Users" functionality (API integration, display).
	- Implement the "Assign Roles" functionality (form, API integration).
	- Implement the "Contact messages" view.

### Tasks other
	- Final testing, bug fixes, and code cleanup.
	- Documentation and deployment preparation.
	- Final Presentation preparation.
	- GitHub Readme Documentation.

# Technologies
	- Blazor and MudBlazor pages
	- OpenApi with Scala
	- Net 9 project
	- JavaScript
	- SQLite might migrate to postgres when Aspire (container) is up and kicking, depends on time

