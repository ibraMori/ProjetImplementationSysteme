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
- [rapport](documentation/RAPPORT 1.docx)

## How to Run
Option 1 — Visual Studio (Recommended)
Open the solution file located in /code using Visual Studio
Press F5 or click Start
The application will launch automatically in your browser
Option 2 — IIS (Executable Version)
Enable IIS:
Go to Control Panel → Programs → Turn Windows features on or off
Enable:
Internet Information Services
ASP.NET
.NET Extensibility
Open IIS Manager
Add a new website:
Site name: welcomeCanada

Physical path:

executable/welcomeCanada
Configure Application Pool:
.NET CLR Version: v4.0
Managed pipeline: Integrated

Run the application in your browser:

http://localhost

or directly:

http://localhost/pageConexion.aspx
## Students tasks
- [ ] Complete the `student_readmefile.md` file.
- [ ] Use the template file `SRS.md` to create your own SRS.
- [ ] Use the template file `ADR.md` to create your own ADRs .
- [ ] You will add your code in the `/code` folder.
- [ ] You will add your documentation in the `/documentation` folder.

## Read more
- [Architecture Decision Records (ADR) template by Joel Parker Henderson](https://github.com/joelparkerhenderson/architecture-decision-record?tab=readme-ov-file)
- [ADR Website](https://adr.github.io/)
