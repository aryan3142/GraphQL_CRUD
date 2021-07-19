# 👣 **GraphQL API on ASP.NET CORE**

>## **Project Manager: Aryan Khandelwal**
>## ✍&nbsp; PROJECT OverView

- This project is a demonstration of WEB API built using GraphQL & ASP.NET Core
- GraphQL is an open-source data query and manipulation language for APIs, and a runtime for fulfilling queries with existing data.
- It was developed internally by Facebook in 2012 before being publicly released in 2015

Nuget Packages Used :
- HotChocolate
- HotChocolate.AspNetCore
- HotChocolate.AspNetCore.Playground
- HotChocolate.Types
- HotChocolate.Types.Filters

### GraphQL
#### Building Blocks of GraphQL
The main building blocks of GraphQL include schemas and types.

##### Schema
There is one, and only one endpoint in GraphQL. This endpoint exposes a schema that is 
used to let the API consumer know the functionality available for the clients to consume, 
i.e., what data they can expect and the actions they can perform.

A schema contains a Query, Mutation, and a Subscription.

- Query – Queries enable you to consume data efficiently. The consumer or the client can mention the field or fields it needs in lieu of getting data for all fields from a particular type. Note that the client can only consume the fields that have been exposed by the API.
- Mutation – In GraphQL mutations are used to send data to the server, i.e., you can take advantage of mutations to add, edit, or delete data. The client can only take advantage of the mutations that have been exposed by the schema to modify the data. It should be noted here that if there are no mutations in a GraphQL schema, the client cannot manipulate the data in the API.
- Subscription – Subscriptions allow a server to send data to its clients, hence notifying them when events occur. Subscriptions provide support for event-driven architectures and for real-time notifications they take advantage of WebSockets.

##### GraphQL Object Types
The most fundamental components of a GraphQL schema are object types, which in turn are used to represent the type of object you can retrieve from your API. 
Object Types in GraphQL are represented by the GraphQL.Types.ObjectGraphType class and contain Fields and Methods. While the former is a property in the class, 
the latter is used to modify field values when needed based on a client query.

![alt text](<https://github.com/ryan3142/GraphQL_CRUD/blob/master/GraphQLCRUD/Screenshots/Screenshot%20(817).png>)

![alt text](<https://github.com/ryan3142/GraphQL_CRUD/blob/master/GraphQLCRUD/Screenshots/Screenshot%20(818).png>)

