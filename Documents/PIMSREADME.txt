Patient Information Management System README

This software is designed to provide a clear and concise view of the data stored for patients in a database.
Medical staff of various levels of access will be able to easily log on and check information that is privy to them,
along with the ability to add or remove the data.



------------------------------------------SETUP---------------------------------------------------------

The following setup is intended for use by whoever is in charge of managing the database at the given hospital.


Aside from this software, you will need Microsoft's SQL Server (Recommended 2014 version) to host the server.
You can find the downloads page through this url: https://www.microsoft.com/en-US/download/details.aspx?id=42299

(The following is to help you install Sql Server, if you don't need it, you may skip down past it)

After clicking download, in the pop up, you will want to select ExpressAdv 64BIT\SQLEXPRADV_x64_ENU.exe
(This is a large download, so it is recommended you have a decent, stable internet connection)

Once it is downloaded, you will want to find the .exe (the executable) file in your downloads folder.
Click ok until you get to the SQL Server Installation Center window. Here you will be able to 
install a new copy of SQL Server and SQL Server Management Studio. To do this, click the 
"New SQL Server stand-alone installation or add features to an existing installation" option from the right side of the window.
This should take you to a SQL Server 2014 Setup window and advance through the steps until you are on the Installation Type step. 
Here you will want to select the "Perform a new installation of SQL Server 2014" option and click next.
Agree to the license terms to proceed to the Feature Selection screen. 
Ensure that all checkboxes in the Features box are checked, with the exception of LocalDB. Now click next. 
Continue clicking next for each step after this until you have completed the installation.

Now you can launch SQL Server Management Studio. This program allows you to view your databases. To do this, open you windows search bar and type "
Management Studio" and hit enter. This should open up the management studio so that you can interact with the database tables. 
It will prompt you to connect each time you log on. Simply click connect for now. This will bring you to the main screen where you can edit and view tables.

Before you can view your database, you need to make sure it is "attached" in SQL Server Management Studio. To do this, locate the database files provided to you
- you are looking for the .mdf and .ldf files. After finding them, copy them, and navigate to the default DATA folder location for SQL Server Management Studio: 

C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA

Paste the .mdf and .ldf files there, overwriting existing files if necessary. 
Having completed this step, open up SQL Server management studio and open the object explorer window.

Menu bar->view->object explorer

Once in the object explorer, right click the databases folder and then select "Attach..." to attach the database file that you added to the DATA folder.
You only need to attach the .mdf file.

After attaching the file, you should be able to view your database in SQL Server Management Studio.



(The rest of this setup assumes you have installed Microsoft SQL Server and have your database setup through it)

Now that you have SQL Server, and a database, you are ready to setup usernames and passwords - the general login information.
To create a login, open Microsoft SQL Server Management Studio. In the object explorer view, you should see a file hierarchy containing a folder labeled Security.
Expand Security, then expand Logins. Under Logins, you will see all of the current logins that have been made for the database.

To add a new login, right click on the login folder and select "New Login." Once you get to the popup, you'll be able to enter the login name, but no password.
You will need to check the "SQL Server Authentication" box instead of the "Windows authentication" box, which will allow you to enter and confirm the requested password.
Enter a name and password for the user and uncheck the "Enforce password expiration" checkbox.
Finally, on the left side of the window you will see a Select a page section. Here, click the Server Roles option.
You will need to assign appropriate server roles to each user. For the admin account, please select the "sysadmin" box to give full access to the database.
For all other accounts, select the User Mapping page. Select the database that you want to give the user access to, check the Map button next to the database name, then 
select datareader and datawriter options from the bottom list.

After checking through every option based on your rules, you can create the new login.

Now that you have a login(s) created, you need to add them to the user table in the database to assign correct access levels, in order to keep information privy to certain employees.
You'll need to go into the user's table in the database, and add each login to it, assigning access levels to them. The current access levels are:
4-Doctor
3-Nurse
2-Office Staff
1-Volunteer

It is recommended that you give the database admin user a level 4 access.
After they have been added to the users table in the database, they can now login through the P.I.M.S software login screen.

As for the P.I.M.S Software, you will need to make sure that the "Server" and "Database" fields on the login screen are set to the name of your server (Which you can find in the 
SQL Server Management Studio) and the name of the database (Which can also be found in the SQL Server Management Studio).


Once those fields are set up, the software can be used by the staff.



-----------------------------------------------HOW TO USE THE SOFTWARE-------------------------------------

The Patient Information Management System (P.I.M.S) is design to allow medical staff to easily access patient information stored in their local database. After making a login through their
resident Database Manager, they will be able to login through the software.

What the individual is able to access will be based off of their access level given to their title, with Doctors having access to everything. Upon login, The user will see the home screen,
which has various buttons related to the information they can access.

PATIENTS: Clicking this button will take the user to a page that will show them the patients that are registered in the database. Should they wish to find a specific patient, they
can use the search bar. The search bar uses first or last names to search, and if the full name is not known, they may enter part of it followed by an asterisk "*" to have the search find all
patients with names similar to what was entered.
They will be able to view the information, but also able to remove patients
from the list, or add new patients, each with a respective button. Upon attempting to add a patient, several subsequent windows will pop up, with fields that can be filled out related to 
patient information. Not all information in the software will be able to be entered in here.

ADMISSIONS:This button will take the user to a page that lists information related to when patients are admitted or discharged. Like Patients, you can search, using the same rules.

VISITORS:This button will take the user to a page that lists information related to the visitors patients have. Like Patients, you can search, using the same rules. As visitors are 
information not given through adding a patient, you will be able to add and delete visitor information like with Patients

INSURANCE:This button will take the user to a page that lists information related to the insurance patients have. Like Patients, you can search, using the same rules.

CHARGES:This button will take the user to a page that lists information related to the charges assigned to patients. Like Patients, you can search, using the same rules.
As charges are information not given through adding a patient, you will be able to add and delete charges information like with Patients

BILLS:This button will take the user to a page that lists information related to the bills assigned to patients. Like Patients, you can search, using the same rules.
As bills are information not given through adding a patient, you will be able to add and delete bills information like with Patients

NOTES:This button will take the user to a page that lists the notes that have been written for each patient. The notes are written by doctors or nurses. Like Patients, you can search, 
using the same rules. You can also add or remove notes, if you are the correct access level, using the correct buttons.

REPORTS:This button will take the user to a page that lists patients, and allows you to search for a patient the same way as the other pages,
and after selecting a patient, will allow you to print a report of various information assigned to the selected patient. Upon selecting a "Generate ____ Report" button,
the user will be taken to their file explorer on the current computer, where they may name and save the spreadsheet of information, allowing them to print it out at
their leisure. You may also select all patients using the bottom button.

LOGOUT: Hitting this button will log the user out and return to the login screen. To completely exit the program, you have to hit the X button on the login screen.


