using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class RestApiDosDont
    {
        //  RESTful API Best Practices and Common Pitfalls

        //As a person who spends his day integrating systems, I’ve found that at least half of the APIs I use radically differ from REST semantics, make changes too often and too quickly, don’t validate enough, and/or don’t have proper documentation.There are tons of resources for making good RESTful APIs already, but I thought I’d add to the mix with some semantic rules and some technical ones that I see broken over and over.
        //Now, I’m not advocating that you should spend your time trying to implement a fully-compliant REST API— very few have and there’s not much benefit to doing so.I’m a believer in pragmatic REST — that is, you should do what makes sense and throw out what doesn’t.I’m being vague on purpose because it really comes down to your particular use case.
        //Honestly, good REST design practices could fill an entire book.For the sake of brevity, I’ve chosen ten– four related to technical implementation, six related to semantic. The examples are done using ASP.NET Web API, but the semantic stuff(and the technical, conceptually!) also applies to RESTful APIs made using other web frameworks and languages.
        //When it comes to RESTful API design, I have two main rules.
        //Do what’s expected. No reason to get creative— a really creative API is probably a bad API. Follow established best practices.
        //Be consistent. Use the same endpoint structure, HTTP status codes, HTTP verbs, etc. for your requests, for the same reasons.A poorly formed request should return 400, not 404.
        //Semantic best practices


        //1. Think nouns, not verbs.
        //The main difference between REST-styled APIs and RPC/SOAP-styled APIs to me is the difference between nouns and verbs. RESTful APIs are based on nouns — you’re performing actions on endpoints that are things. RPC/SOAP endpoints, on the other hand, are verbs — they’re things that are meant to do something.Consider this example:
        //GET /employees
        //GET /employees/123
        //POST /employees
        //versus
        //GET /getAllEmployees
        //GET /getEmployeeWithId
        //POST /createEmployee
        //The former is more intuitive (from the REST perspective) and much more common— the latter is more SOAPy.Stick with the common pattern of CRUDing nouns— the developers consuming your API will thank you. (Actually, they probably won’t, cause that’s what they would have expected you to do.)



        //2. Respect the change management process.Avoid introducing break changes to existing endpoints that people are using.
        //Once published and consumed, your production API should not change in any significant way.Fix bugs— that’s okay, as long as it doesn’t change how your API fundamentally works.If you absolutely need to introduce a breaking change(keep in mind that there is almost always a better choice), warn your consumers way in advance.Avoid large refactors that aren’t backed by a suite of unit tests.
        //And please, whatever you do, don’t have conversations like this (yes, this really happened with a production API we use frequently):
        //Vendor: We refactored a lot of code under a couple of our APIs.We don’t expect any breaking changes, but let us know if you see any.
        //Me: Ok.When should we expect this to be deployed? Can you deploy it to test first so that we can run our integration tests against it?
        //Vendor: Actually, we have to release it tonight for an internal project.
        //(And yeah, I’m pretty sure that they don’t unit test their API.)


        //3. Be consistent.That means with HTTP status codes, general API structure, accepted best practices, etc.
        //Do:
        //…use GETs to get data.
        //Use PUTs/POSTs to change data.
        //Use the same general endpoint structure throughout.
        //Pick a few good status codes to use consistently and use them consistently and correctly throughout your API.
        //Don’t:
        //Use status codes in a way that is not expected. If returning a set of objects, don’t return 404 if the set is empty— return the empty set.That’s what people expect.
        //Use GETs to alter data or PUTs/POSTs to only get data.
        //Use every status code that tangentially relates to what you’re trying to tell your consumer. Use error messages to describe invalid conditions.



        //4. Consider versioning.
        //Let’s face it— your business will change. Your processes will change. What people want will change.Change is inevitable! Do yourself a favor and embrace it.Version your API before you start.
        //There are a few different ways developers version their API — accept different headers, use a different URL, etc.The most semantic and clear way to express a version is to put it in your URL, like this: api/v2/Orders
        //In ASP.NET Web API, you can use the RoutePrefix attribute to do this very easily on your controllers:

        //5. KISS.
        //Keep It Simple, Stupid.Or, Keep It Stupidly Simple if you want to be nicer.Here are a few simple rules to follow.
        //Don’t expose more than you think needs exposing. If a certain property on an object is internal to your business and not useful to a consumer, then don’t return it.
        //Don’t use 43 different status codes — use a few of the most commonly used ones. 200, 201, 302, 404, 400, 500, etc.
        //Keep your DTOs simple.In one particular API I work with, there are four different ways to represent an inactive record. I don’t mean one property with four different states, I mean four different properties are available to determine whether or not something is considered inactive. Further, the impact of these four different properties is not well known or explained.
        //Return things in a similar way.This is just another way of saying be consistent.For 23 endpoints, don’t return 23 different kinds of objects to indicate that a request was bad.Pick one and stick with it!
        //6. Document, document, document.
        //Document your API well. It’s going to save you tons of trouble down the road— you’ll get less developers asking you questions all the time and will allow people to get value out of the thing you invested 10’s of thousands of dollars to build.Don’t waste your time building something for developers and not telling them about it or how to use it.
        //You can use attributes to describe your API and have Web API auto-generate documentation for you.It’s not perfect, but it’s better than nothing at all. Here’s a good place to start.
        //Technical best practices
        //1. Use DTOs to move data back and forth.
        //Consider the following example:


        //See the problem? Your API consumer has the ability to bind to that sensitive property and alter it. Sure, you can use things like the [Bind] attribute to cover those holes, but that means maintaining a comma delimited list of properties in an attribute. Gross.
        //I like to keep things simple. Each controller (and sometimes endpoint, depending on the need) has its own DTO that it uses to process requests.My GETs will often return a subset of data and PUTs/POSTs are limited to updating only fields that I want to update. This makes it very clear and simple for you and your API consumers, while also enforcing a separation of concerns between your entities and your DTOs. This example improves upon the previous code by replacing the Person in the PUT with a PersonDto:

        //2. Validate everything.
        //Data should always be assumed to be bad until it’s been through some kind of validation process. Make no assumptions about the data you’re receiving — someone, somewhere will likely send you a request that will break something at some point. Treat it like you would a UI— always validate your data. Since I always follow technical rule #1, I typically implement IValidatableObject on my DTO and validate using Model.IsValid in the controller.

        //(You can also use an Action Filter to check model validity on each request instead of having the same boilerplate at the top of a controller. See here.)
        //There will be times where this doesn’t have a lot of flexibility — for example, if the DTO needs access to a service that is injected into the controller, then ModelState.IsValid won’t work because the DTO doesn’t know about the service ahead of time. Usually then I hand the object off to a service who knows how to validate my DTO.
        //The importance of this rule can be illustrated by something that happened to me recently.I was performing updates to objects via PUT requests on a service’s API. My PUT requests were mostly valid, but were missing a crucial property (mea culpa.) That property was interpreted on the receiving end as being NULL, which overwrote the property in their system and put the object in an invalid state, such that I couldn’t even find the object via a direct GET (I got 404 instead.) There wasn’t enough protection on their end to ensure that this property wasn’t overwritten, leading to what was effectively data corruption.
        //Don’t let this happen to you! Learn from my mistakes. Validate your data.
        //P.S. FluentValidation is a library that allows you to more clearly compose and express validation rules — it also hooks into Web API very easily. Check it out here: https://github.com/JeremySkinner/FluentValidation


        //3. Keep your controllers as thin as possible. Enforce separation of concerns. Separation of concerns means things are testable.
        //Controllers should only do one thing: hand data off to other services to do work for them. Controllers themselves should only be responsible for moving data to and from your services and should contain no business logic.
        //Why? Because the job of a controller is not to know how to process a certain request — the controller should only know who should process a certain request. This helps keep your controllers and services testable.
        //Consider the following example.




        //So what’s the difference? In the first (bad) example, the OrderService is constructed by the controller. Our controller is now wholly dependent on that implementation of OrderService, which breaks separation of concerns.
        //The second example has the implementation of IOrderService handed to it by something else — dependency injection, your unit tests, anything. It doesn’t know ahead of time what that implementation looks like, and it doesn’t care. The second controller is much more testable and enforces separation of concerns.

        //4. Use async/await if at all possible.
        //This one may not seem like it makes much of a difference, but it can. Consider the following example:

        //What’s the difference? Not much on the surface, but under the hood it can make a difference as the traffic to your app increases. ASP.NET maintains a thread pool for incoming requests. Synchronous requests (such as the first example) will take one of those threads and release it only after the request is finished. However, using the async GET will release the threads as other systems(such as a database call) are doing the work.

    }
}
