using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class WebApiInterviewQuestions
    {
        //        Top ASP.Net Web API Interview Questions and Answers for freshers and 2-5 year experienced dot net developers with explanation and examples.

        //1) What is Web API?
        //It is a framework which helps us to build/develop HTTP services.So there will a client server communication using HTTP protocol.

        //-------------------------

        //2) What is Representational state transfer or REST?
        //REST is architectural style, which has defined guidelines for creating services which are scalable.REST used with HTTP protocol using its 
        //verbs GET, POST, PUT and DELETE.

        //-------------------------

        //3) Explain Web API Routing?
        //Routing is the mechanism of pattern matching as we have in MVC.These routes will get registered in Route Tables.Below is the sample route in Web API –

        //Routes.MapHttpRoute(

        //Name: "MyFirstWebAPIRoute",
        //routeTemplate: “api/{ controller}/{id
        //}
        //defaults: new { id = RouteParameter.Optional}
        //};

        //-------------------------

        //4) List out the differences between WCF and Web API?

        //WCF

        //It is framework build for building or developing service oriented applications.
        //WCF can be consumed by clients which can understand XML.
        //WCF supports protocols like – HTTP, TCP, Named Pipes etc.
        //Web API

        //It is a framework which helps us to build/develop HTTP services
        //Web API is an open source platform.
        //It supports most of the MVC features which keep Web API over WCF.

        //-------------------------

        //5) What are the advantages of using REST in Web API?
        //REST always used to make less data transfers between client and server which makes REST an ideal for using it in mobile apps.Web API supports HTTP protocol thereby it reintroduces the old way of HTTP verbs for communication.

        //-------------------------

        //6) Difference between WCF Rest and Web API?

        //WCF Rest

        //“WebHttpBinding” to be enabled for WCF Rest.
        //For each method there has to be attributes like – “WebGet” and “WebInvoke”
        //For GET and POST verbs respectively.
        //Web API

        //Unlike WCF Rest we can use full features of HTTP in Web API.
        //Web API can be hosted in IIS or in application.

        //-------------------------


        //7) List out differences between MVC and Web API?

        //Below are some of the differences between MVC and Web API

        //MVC

        //MVC is used to create a web app, in which we can build web pages.
        //For JSON it will return JSONResult from action method.
        //All requests are mapped to the respective action methods.
        //Web API

        //This is used to create a service using HTTP verbs.
        //This returns XML or JSON to client.
        //All requests are mapped to actions using HTTP verbs.

        //-------------------------

        //8) What are the advantages of Web API?

        //Below are the list of support given by Web API –

        //OData
        //Filters
        //Content Negotiation
        //Self Hosting
        //Routing
        //Model Bindings
        //-------------------------


        //9) Can we unit test Web API?
        //Yes we can unit test Web API.

        //-------------------------

        //10) How to unit test Web API?

        //We can unit test the Web API using Fiddler tool.Below are the settings to be done in Fiddler –
        //Compose Tab -> Enter Request Headers -> Enter the Request Body and execute

        //-------------------------

        //11) Can we return view from Web API?

        //No.We cannot return view from Web API.

        //-------------------------

        //12) How we can restrict access to methods with specific HTTP verbs in Web API?

        //Attribute programming is used for this functionality.Web API will support to restrict access of calling methods with specific HTTP verbs. We can define HTTP verbs as attribute over method as shown below

        //[HttpPost]
        // public void UpdateTestCustomer(Customer c)
        //{
        //    TestCustomerRepository.AddCustomer(c);
        //}

        //-------------------------

        //13) Can we use Web API with ASP.NET Web Forms?

        //Yes.We can use Web API with ASP.NET Webforms.

        //-------------------------

        //14) List out the steps to be made for Web API to work in Web Forms?

        //Below are the steps to be followed –

        //Creating new controller for Web API.
        //Adding routing table to “Application_Start” method in Global.asax
        //Make a AJAX call to Web API actions.
        //-------------------------


        //15) Explain how to give alias name for action methods in Web API?

        //Using attribute “ActionName” we can give alias name for Web API actions.Eg:

        //[HttpPost]
        //[ActionName("AliasTestAction")]
        //public void UpdateTestCustomer(Customer c)
        //{
        //    TestCustomerRepository.AddCustomer(c);
        //}

        //-------------------------


        //        1) Differentiate between MVC Routing and Web API Routing?
        //There must be at least one route defined for MVC and Web API to run MVC and Web API application respectively.In Web API pattern you can find “api/” at the beginning which makes it distinct from MVC routing. In Web API routing “action” parameter is not mandatory but it can be a part of routing.

        //-------------------------
        //2) What is Exception Filters
        //Exception filters will be executed whenever controller methods throw an exception which remains unhandled.Exception filters will implement “IExceptionFilter” interface.

        //-------------------------

        //3) Explain about the new attributes added in Web API 2.0 version?
        //Here is the list of attributes introduced in Web API 2.0 –
        //OWIN
        //Attribute Routing
        //External Authentication
        //Web API OData

        //-------------------------


        //4) How can we pass multiple complex types in Web API?
        //Here are mentioned the methods to pass the complex types in Web API –
        //Using ArrayList
        //Newtonsoft Jarray

        //-------------------------


        //5) Write a code snippet for passing arraylist in Web API?
        //ArrayList paramList = new ArrayList();
        //        Category c = new Category { CategoryId = 1, CategoryName = “SmartPhones”};
        //        Product p = new Product { ProductId = 1, Name = “Iphone”, Price = 500, CategoryID = 1 };

        //        paramList.Add(c);
        //paramList.Add(p);

        //-------------------------


        //6) Give an example of Web API Routing?
        //config.Routes.MapHttpRoute(
        //name: “MyRoute”,//route name
        //routeTemplate: “api/{ controller}/{action
        //    }/{id
        //}”,//as you can see “api” is at the beginning.
        //defaults: new { id = RouteParameter.Optional }
        //);

        //-------------------------


        //7) Give an example of MVC Routing?
        //routes.MapRoute(
        // name: “MyRoute”, //route name
        // url: “{ controller}/{action}/{id}”, //route pattern
        // defaults: new 
        // { 
        // controller = “a4academicsController”, 
        // action = “a4academicsAction”, 
        // id = UrlParameter.Optional
        // } 
        // );

        //-------------------------


        //8) How we can handle errors in Web API?
        //Here are the lists of classes which could be used for error handling -
        //HttpResponseException
        //Exception Filters
        //Registering Exception Filters
        //HttpError
        //-------------------------


        //9) Explain how we can handle error from “HttpResponseException”?
        //This returns the HTTP status code what you specify in the constructor.Eg :
        //public TestClass MyTestAction(int id)
        //{
        //    TestClass c = repository.Get(id);
        //    if (c == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return c;
        //}
        //-------------------------


        //10) How to register Web API exception filters?
        //Here are the options to register Web API exception filters –
        //From Action
        //From Controller
        //Global registration
        //-------------------------


        //11) Write a code snippet to register exception filters from action?
        //Here is the code snippet for registering exception filters from action –
        //[NotImplExceptionFilter]
        //public TestCustomer GetMyTestCustomer(int custid)
        //{
        //    //Your code goes here
        //}

        //-------------------------


        //12) Write a code snippet to register exception filters from controller?
        //[NotImplExceptionFilter]
        //public class TestCustomerController : Controller
        //{
        //    //Your code goes here
        //}
        //-------------------------


        //13) Write a code snippet to register exception filters globally?
        //Here is the code snippet for registering exception filters globally –
        //GlobalConfiguration.Configuration.Filters.Add( new MyTestCustomerStore.NotImplExceptionFilterAttribute());
        //-------------------------

        //14) How to handle error using HttpError?
        //HttpError will be used to throw the error info in response body. “CreateErrorResponse” method is used along with this, which is an extension method defined in “HttpRequestMessageExtensions”.
        //-------------------------

        //15) Write a code snippet to show how we can return 404 errors from HttpError?
        //Here is the code snippet for returning 404 error from HttpError
        //string message = string.Format(“TestCustomer id = {0} not found”, customerid);
        //return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);

        //-------------------------
    }
}
