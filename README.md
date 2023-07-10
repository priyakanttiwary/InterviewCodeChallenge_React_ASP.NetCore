# InterviewCodeChallenge_React_ASP.NetCore

The company you work for recently bought the source code of a ASP.Net Core Web API and React project used to manage products in system for ecommerce business. The original development team left a few comments in the source code regarding issues they could not fix. You have been tasked to fix code and fulfil are requirements defined [below](#requirements). You have full freedom to completely modify the source code and re-arrange the solution as you see fit. Keep in that mind after your work is done, another team will take over to maintain and extend the project.

## Development requirements
* [.Net Core 3.1] (https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
* Visual Studio.
* [Node.Js] (https://nodejs.org/en/blog/release/v16.20.1)
* [npm] (npm install -g npm)

## Already developed screen
Product Listing Page
  ![image](https://github.com/priyakanttiwary/InterviewCodeChallenge_React_ASP.NetCore/assets/87647599/e81e7d2b-2267-404f-89b0-f6aa3b0642e5)

Add Product Page
  ![image](https://github.com/priyakanttiwary/InterviewCodeChallenge_React_ASP.NetCore/assets/87647599/e7f12c74-32a5-45cc-ba88-6100a9ae1cb9)

## Requirements
Add/Update the existing code in order to satisfy the following requirements:

* Existing codes have lots of code quality issue  in terms of SOLID principle , Design pattern , asynchronous programming , file write/read reusability of code in react and c#, react component, services segregation and XSS attack, Please fix all code quality and XSS attack issue as per your knowledge.
  
* Implement cascading dropdown binding between Category and Subcategory and Search listing product on the basis of category and subcategory selection.
  
* On add product page implement feature to upload image of product and display same image in product listing grid inside Image column.

* Log all server side exception globally and log  all client side exception on server instead of console.log()

* Implement appropriate clint side and server-side validation of add product functionality.
     * Price field should accept only number decimal point and after decimal point max 2 digit and before decimal point accept max 10 digit number(Same validation will be applicable for input and copy past).
     * Quantity field should accept only number between 1 to 1000.(Same validation will be applicable for input and copy past) 
     * Image size should not be more that 1MB. 
  
* Implement the feature If product quantity is less than 10 then product list grid row background should be in red colour and if quantity between 10 to 100 it should be in orange colour 
  and if quantity is more than 100 then it should be in green colure.

* Implement Server side pagination for product listing grid where page size should be 5 only.
  
* Log the elapsed time of each API method in millisecond  to check performance of API. 

* Write Unit test cases of server side code only.

  ## Completing the challenge

- Upload on your git account and share link with HR in email.



  
