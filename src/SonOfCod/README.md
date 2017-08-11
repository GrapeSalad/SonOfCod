# Son Of Cod Fishmonger Website

Mock-Up for the Son of Cod online marketing portal.

## Specs/Wishlist

| Page | Results |
|---|---|
| / | Marketing home page, info about site and links to the other paths |
| /Marketing/ViewAll | list of all available fish |
| /Marketing/SignUp | allow user to sign up for mailing list/if admin is logged in they can go to another page to see list of recipients |
| /Marketing/Recipients | if admin, list of all current people signed up for newsletter |
| /Account | Admin login page, can register/login/return |
| /Account/Register | Add new admin account | 
| /Account/Login | Log in with created admin account |


| Page | Needed |
|---|---|
| / | Styling |
| /Marketing/ViewAll | Styling, link home |
| /Marketing/SignUp | Styling, form data validation, link home |
| /Marketing/Recipients | Styling, link emails to pull up email program |
| /Account | Styling |
| /Account/Register | Styling | 
| /Account/Login | Styling |

<hr>

## Project Build

Download from the [repo](https://github.com/GrapeSalad/SonOfCod)

Open Viual Studio 2015 and choose the Open Project option.

Navigate to the directory in which you downloaded the repo and open the project file.

### Migration

Navigate to `....\project-name\src\projectname`.
Run this command in your terminal: `dotnet ef database update`.

### Data Entry

Open [SSMS](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms), Log in to the default database, Find the open file button in the tool ribbon, navigate to and double click on the file named Data_For_Migration in the SQL_Queries folder.

### Running the Server

After installation and Migration, press f5 or the play button in the toolbar to run the server and have the site appear in your default browser.

## Known Bugs

Not the prettiest site.

## Technologies Utilized

* C#
* Visual Studio
* ASP.NET MVC
* ASP.NET
* CSS

## Credits

* David Wilson