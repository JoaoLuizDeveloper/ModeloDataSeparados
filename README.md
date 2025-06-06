ProjetoTempus
A modular ASP.NET Core MVC project demonstrating clean architecture principles by separating concerns into distinct layers for data access, models, utilities, and presentation.

📁 Project Structure
ProjetoTempus.AccessData: Handles data access and repository implementations.

ProjetoTempus.Models: Contains domain models and entity definitions.

ProjetoTempus.Utility: Provides helper classes and utility functions.

ProjetoTempus: The main ASP.NET Core MVC application (frontend).

ProjetoTempus.sln: Visual Studio solution file.

🛠️ Technologies Used
ASP.NET Core MVC
Entity Framework Core
C#
HTML, CSS, JavaScript

🚀 Getting Started
Clone the repository:

git clone https://github.com/JoaoLuizDeveloper/ModeloDataSeparados.git
<br />
cd ModeloDataSeparados
Open the solution:

Open ProjetoTempus.sln in Visual Studio.

Configure the database:

Update the connection string in appsettings.json within the ProjetoTempus project.

Apply migrations and update the database:

dotnet ef database update
Run the application:

Press F5 in Visual Studio or use the .NET CLI:

dotnet run --project ProjetoTempus
The application will be available at http://localhost:5000.

📄 License
This project is licensed under the MIT License.
