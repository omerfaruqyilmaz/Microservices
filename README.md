# Microservices:
## Microservice structure
![map](https://github.com/omerfaruqyilmaz/Microservices/assets/89321861/95aa28f7-5c90-47f9-b047-b1dc2acf75cd)

## Catalog Microservice
Responsible for storing and presenting information related to our courses. We use MongoDB as the database. Additionally, we manage One-To-Many and One-To-One relationships.
## Basket Microservice
Responsible for handling shopping cart operations. We use RedisDB as the database.
## Discount Microservice
Responsible for managing discount coupons assigned to users. We use PostgreSQL as the database.
## Order Microservice
Handles order-related processes. We develop this microservice using the Domain Driven Design approach and implement the CQRS design pattern with the MediatR library. The database used is SQL Server.
## FakePayment Microservice
Responsible for payment transactions.
## IdentityServer Microservice
Manages user data storage, token, and refresh token generation. We use SQL Server as the database.
## PhotoStock Microservice
Responsible for storing and presenting course photos.
## API Gateway
A component that directs API traffic and routes it to microservices from a central point. In this project, we use the Ocelot library.
## Message Broker
We use RabbitMQ as the message queue system. Additionally, we communicate with RabbitMQ using the MassTransit library.
## Identity Server
Responsible for generating tokens and refresh tokens, securing microservices with access tokens, and building a structure compliant with OAuth 2.0 / OpenID Connect protocols.
## Asp.Net Core MVC Microservice
Responsible for displaying data obtained from microservices to users and interacting with users through the UI.
