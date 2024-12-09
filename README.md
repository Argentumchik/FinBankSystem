# FinBankSystem

FinBankSystem is a comprehensive banking system built with .NET Core. This project aims to provide a robust platform for managing customer accounts, transactions, and various financial operations.

## Features
- Customer Management: Create, read, update, and delete customer information.
- Account Management: Manage customer accounts and their associated transactions.
- Secure Authentication: Implement JWT-based authentication for secure access.
- Modular Architecture: Clean separation of concerns with different layers for core, application, and infrastructure.

## Getting Started

### Prerequisites
- .NET 8.0 SDK
- PostgreSQL

### Installation
1. Clone the repository:
   - <code>git clone https://github.com/Argentumchik/FinBankSystem.git</code>
   - <code>cd FinBankSystem</code>
2. Set up the database:
   - Update the connection string in <code>appsettings.Development.json</code> with your PostgreSQL credentials.
3. Apply the migrations:
   - <code>dotnet ef database update --project FBS.Infrastructure</code>
4. Run the application:
   - <code>dotnet run --project FBS.API</code>
## Usage
Once the application is running, you can access the API endpoints through the Swagger UI at <code>http://localhost:5000/swagger</code>.

## Contributing
Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Contact
For any inquiries or issues, please contact: [argentumchik@gmail.com]
