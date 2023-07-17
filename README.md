# Coding challenge - ReactJS with ASP.NET Core

This is a coding challenge for fullstack developer who is familiar with ASP.Net Core WebAPI and React JS. Your task is to complete all the [requirements](#requirements) using the unfinished source code which already been provided. You have full freedom to completely modify the source code and re-arrange the solution. 

## Development environment specification
* [.Net Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
* Visual Studio or VS Code
* [Node.js 16.20.1 or any latest version](https://nodejs.org/en/blog/release/v16.20.1)
* You do not need any persistent storage

## Requirements
You need to deliver production quality code that conforms to best practices and principles such as SOLID, asynchronous programming, utilize design patterns where appropriate.

* Review the existing code and improve the quality of code where ever applicable.

* Implement cascading dropdown binding between Category and Subcategory and Search listing product on the basis of category and subcategory selection.

* Add image upload feature to Product and also product listing grid should display the uploaded image thumbnail in a new Image column.

* Implement Exception Handling and Logging.

* Implement appropriate client side and server-side validations
     | Field Name  | Data Type  | Required | Validation                               |
     |--           |--          |--        |--                                        |
     |Price        |decimal     |true      |Allow only 2 decimal places               |
     |Quantity     |int         |true      |Allow numbers between 1 and 1000          |
     |Image        |N.A.        |false     |Should be less than 1MB                   |

* Implement Server side pagination for product listing grid where the page size should be 5.

* Implement edit feature for products.

* Write Unit test cases of server side code only.

## Completing the challenge
  
* We will share you a private repository which you should clone and once you are ready to share your work push it to the same private repository and share the update to HR.
