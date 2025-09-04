# High Energy Astrophysics Course Notes Web Page

**High Energy Astrophysics Course Notes Web Page** is a secure web application developed with **ASP.NET Core MVC** and **Entity Framework Core**. The project's main goal is to provide hands-on experience with user **authentication** and **authorization** processes using a **SQL Server** database.

---

### Project Features

* **User Registration System:** A secure system for new users to register, complete with an email verification process.
* **Custom Login & Registration Pages:** User-friendly custom interfaces that replace the standard ASP.NET Core Identity pages.
* **Secure Areas:** Restricted pages that are accessible only to logged-in users.
* **Password Management:** A system that allows users to securely reset their passwords.
* **Database Integration:** Implementation of data operations (Create, Read, Update, Delete) with SQL Server using Entity Framework Core.
* **MVC Architecture:** The project is built with a standard **Model-View-Controller** pattern to separate data, presentation, and control logic.

---

### Technologies Used

* **Architecture:** ASP.NET Core MVC
* **Backend:** C#
* **Database:** SQL Server
* **ORM:** Entity Framework Core
* **Identity:** ASP.NET Core Identity
* **Frontend:** HTML, CSS, JavaScript

---

### Setup and Running the Project

1.  Clone the repository:
    ```bash
    git clone [https://github.com/aleynanurozturk/HighEnergyAstrophysicsCourseNotesWebPage.git](https://github.com/aleynanurozturk/HighEnergyAstrophysicsCourseNotesWebPage.git)
    ```
2.  Open the project in Visual Studio.
3.  Configure your SQL Server **connection string** in the `appsettings.json` file.
4.  Apply database migrations from the Package Manager Console (`Tools > NuGet Package Manager > Package Manager Console`):
    ```bash
    Update-Database
    ```
5.  Run the application (`F5`).

---

### Future Plans

* Adding a Content Management System (CMS) for course notes.
* Developing user profile pages.
* Implementing content filtering and search functionality.
* Further improving responsive design.

---

### Contribution

This project is a result of a learning journey and is open to contributions. All suggestions and improvements are welcome.
