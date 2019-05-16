# Technical Overview
Gateway API application is created using Microsoft .NET Core 2.2 C# as backend logic.
Ocelot Gateway

# GateWay API Overview 
When you are working on microservice environment and have multiple micro services exposed to end user it is very difficult to manage and maintain endpoints. To resolve this issue, you require a common gateway which you can not only share to end-users but also a centralized place to manage all your endponints. This project helps you overcome this issue and give you a very simple and nice example about how to create a API Gateway. 
I am using Ocelot to implement this solution. For more info please refer to Readme.txt file inside GateWayAPi project.

# Project Overview
1) OrderAPI --> A simple API which return a string array
2) CatelogAPI --> A simple API which return a list of orders
3) GatewayAPI --> API Gateway, which handles and route all the request for above 2 APIs. Please look into ocelot.json file

# Intall Ocelot nuget package
https://ocelot.readthedocs.io/en/latest/features/routing.html
