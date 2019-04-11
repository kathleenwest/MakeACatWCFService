# MakeACatWCFService

WCF “Make a Cat” Service Application & Client "Tester" Windows Form Application

Project Blog Article here: 



About

This project presents a simple, but fun “Make a Cat” Service Application. The service provides a factory creational design pattern to create and return a single Cat object (complete with a cute photo), or group of five cats in a CatList object (with multiple cats). It is hosted using IIS Express to quickly demo and test the service with a client. 
A client “tester” windows form application tests the service and provides output to the user in a simple GUI.  


Architecture

The demo project consists of these component topics:

•	Make A Cat WCF Service Application
o	Cat (Data Model Contract)
o	IMakeACatService (Interface for Service)
o	MakeACatService (Code that Implements the Service Interface)

•	Client “Tester to Service” Windows Form Application
o	Connected Service “Proxy Reference” MakeACatServiceRef
o	Main Form GUI User Interface
o	Form Code – Processes GUI User Interface
