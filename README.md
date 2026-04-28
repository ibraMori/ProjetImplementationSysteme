# Project Documentation Overview

This repository contains the core documentation used to structure and guide the software project throughout its lifecycle.


## Documents Included

### 1. `SRS.md` — Software Requirements Specification
This document describes **what the system must do**.  
It defines:
- the project scope (included and excluded features),
- functional requirements,
- non-functional requirements (performance, security, usability, etc.),
- constraints (platform, tools, deadlines),
- assumptions and dependencies.

The SRS serves as the **reference for understanding the system requirements** and as the foundation for design and development decisions.

---

### 2. `ADR.md` — Architecture Decision Records
This document records **why key architectural and technical decisions were made**.

Each ADR captures:
- the context of the decision,
- the selected solution,
- alternatives considered,
- justifications,
- consequences and trade-offs.

ADR entries ensure **traceability, consistency, and clarity** throughout the evolution of the system architecture.

---

## How These Documents Are Used Together

- The **SRS** defines *what* the system should be.
- The **ADR** explains *how and why* architectural decisions are taken to meet those requirements.

Together, they provide a clear, professional, and maintainable documentation framework aligned with modern software engineering practices.


## Documentation Tree
- [SRS.md](documentation/SRS.md)
- [ADR.md](documentation/ADR.md)
- [Methode Agile Asana](https://app.asana.com/1/1213020052577483/project/1213318108160994/list/1213318237113192)
- [diagramme des composants](documentation/ComponentIntegImm.drawio.png)
- [diagramme des cas d'utilisation](documentation/diagrammeCasUtilisations.png)
- [diagramme des classes](documentation/diagrammeDeClasses.png)
- [rapport](documentation/report.md)


Execution video

[lien pour la video](https://www.youtube.com/watch?v=17o72OzV3Ak)


How to Run
Prerequisites

Before running the project, ensure the following are installed:

Windows OS
Visual Studio (recommended)
SQL Server LocalDB
IIS (for running the published version)
.NET Framework 4.x
Database Configuration

The application relies on a SQL Server database.

1. Database Setup
Open SQL Server Object Explorer in Visual Studio
Locate or attach the local database in App_Data:
welcomeCanadaDB
2. Required Tables

The database already contains the necessary tables:

Utilisateurs
Guide
Logements
Admin
3. Connection String

Verify the connection string in Web.config:

<connectionStrings>
  <add name="DefaultConnection"
       connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=welcomeCanDB;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>

Make sure the database name matches your local configuration.

Test Data

The local database already includes sample users and an administrator account.

You can use these credentials directly to test the application.

Administrator
AdminId: 1234
Password: 1234
Sample Users
marc@gmail.com / marc
yuji@gmail.com / yuji
gojo@gmail.com / gojo

Option 1 — Run with Visual Studio (Recommended)
Open the solution file located in the /code directory
Ensure the database is correctly configured and accessible
Press F5 or click Start
The application will launch automatically in your browser

Access the login page:

/PageConnexion.aspx
Option 2 — Run with IIS (Published Version)
1. Enable IIS

Go to:

Control Panel → Programs → Turn Windows features on or off

Enable the following:

Internet Information Services
ASP.NET
.NET Extensibility
2. Configure Website

Open IIS Manager and add a new website:

Site name: welcomeCanada
Physical path: executable/welcomeCanada
3. Configure Application Pool
.NET CLR Version: v4.0
Managed Pipeline Mode: Integrated
4. Run the Application

Open your browser and navigate to:

http://localhost

or directly:

http://localhost/PageConnexion.aspx
Troubleshooting

If the application does not run correctly, verify the following:

The database is properly attached
The connection string in Web.config is correct
SQL Server LocalDB is running
Required tables exist in the database
IIS has access permissions to the project folder
Features to Test
User authentication (Student / Worker)
Guide filtering based on user type (Observer Pattern)
Home page state transitions (State Pattern)
Admin functionalities (guide management, user filtering)
Housing search functionality
## Students tasks
- [ ] Complete the `student_readmefile.md` file.
- [ ] Use the template file `SRS.md` to create your own SRS.
- [ ] Use the template file `ADR.md` to create your own ADRs .
- [ ] You will add your code in the `/code` folder.
- [ ] You will add your documentation in the `/documentation` folder.

## Read more
- [Architecture Decision Records (ADR) template by Joel Parker Henderson](https://github.com/joelparkerhenderson/architecture-decision-record?tab=readme-ov-file)
- [ADR Website](https://adr.github.io/)
