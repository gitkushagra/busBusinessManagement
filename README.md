# busBusinessManagement
 Developed a bus business management system which solves the problem of  bus business owners of managing their booking system and their customers. It offers following:  USERS Prospective: 
+ Shows all routes and prices to the user.
+ Display all bus information based on locations, capacity and prices. Availabale seats are only shown to logged in users.
+ Users can start booking after creating the account.
+ Users can view their bookings. They can cancel their booking based on locations.
+ User personal background bank is created in which their bookings cost is monitored. It affects the earnings of owner.
+ Users can delete their account. All their related data is vanished once deleted.
ADMIN Prospective:
+ A default admin credential is provided as "admin" and password "12345".
+ Admin create a new credential and delete the existing one. The credential is only deleted when atleast one credential is available.
+ Admin is provided full control with CRUD operations to manage bookings based on username,manage buses, view and manage feedbacks, manage routes.
+ Total earnings is displayed.
DATABASE information:
+ "busBusinessDatabase" database is created to manage all records.
+  7 Tables created:
       -- adminlogins
       -- Bookings
       -- Bus_Details
       -- Feedbacks
       -- Route
       -- userbank
       -- userinfo
+ 25 Stored Procedures created to manage all CRUD operations through web application based on conditions applicable.
+ In booking, a check constraint is added if age >=18.
+ Foreign keys added:
           -- If username doesn't exist in userinfo, it cannot be added into bookings.
           -- If routeid is not added in route table, it will not be allowed to be added in bus table.
Technologies used:
+ Visual Studio 2019
+ SQL Server Management Studio 19 Express
+ ASP.NET web application (.NET Framework)
+ MVC (Model View Controller)
+ HTML, CSS and JavaScript
+ RDBMS (Relational Database Management System)
