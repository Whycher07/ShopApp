Step 1
 Entity model create 

 -- nuget manage packages install
 ----**IMPOTANT**--------------
 PLEASE PACKAGE VERSION CONTROL

 - Core
 - Core Design
 - Core Tools
 - Core sql Server

 Step 2
	Use the configurations after complate configurations Add context

Step 3
	Program.cs Add Service Context with use SqlServer=>Connection String

Step 4
	Migration
	Sql Connection create database use script
	vs->tool->NuGet Package->Package Manager Console(PMC)
	open->PMC
	add-migration intialcreate -outputDir migrations
	created migrations update SqlServer script code
	update-database
	check up SqlServer

	
