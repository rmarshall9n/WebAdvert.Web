# Project Objectives

The system will allow users to advertise their products or services on the Internet. Public users can browse
through the advertisements or search by keywords.

## Scope

This system will not include payments. It will be assumed that advertising on this product will be free.

## Personas

1. Registered user: A user who has created an account in the website, and is logged in to the system using
   their username and password.
2. Public user: All users whether they are registered users or unregistered users.

Technologies and Environment

- The system architecture will be based on Microservices Architecture
- The system will be built using .NET Core and ASP.NET Core
- The system will be coded using C#
- The system will be deployed to Amazon Web Services
- The system will use the AWS services when needed and when possible

## Requirements

1. Users register in the system and create an account
   1. Email address must be used as the username
   2. Password must be at least 6 character long
2. Only registered users can create an advertisement
3. An advertisement will include the below attributes:
   1. Title
   2. Description
   3. Expiry Date
   4. Price
   5. One image
4. Public users must be able to browse through the advertisements

5. Public users must be able to see the details of an advertisement
6. Public users must be able to search for advertisements by keyword(s)
