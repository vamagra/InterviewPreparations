﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class WebApiDesignGuidelines
    {


        //Web Api Design Points https://www.toptal.com/api-developers/5-golden-rules-for-designing-a-great-web-api


        //        Ever found yourself wondering “what were they thinking?” when integrating a web service via its API? If not, you’ve been far luckier than I have.

        //Any software developer knows how easy it is to let a project devolve into spaghetti code, and web APIs are no less prone to resulting in a tangled web.But it doesn’t need to be that way.In truth, it’s possible to design great web APIs that people will actually enjoy using, and that you’ll enjoy creating as well.But how? The answer to that question is what this post is all about.


        //Perspective

        //Most of the time when you’re building solutions, you’re designing for end users who are not programmers, or who are generally not technically sophisticated.You’re giving them a graphical interface and, if you’ve been doing your job right, you’ve gleaned a pretty good idea from them of what they need the interface to do.
        //But API development is different.You’re designing an interface for programmers, probably without even knowing who they are.And whoever they are, they will have the technical sophistication(or at least will think they have the technical sophistication) to point out every little flaw in your software.Your users are likely to be as critical of your API as you would be of theirs, and will thoroughly enjoy critiquing it.
        //And therein lies part of the irony, by the way.If anyone should understand how to make a web API that’s easy-to-use, it’s you. After all, you’re a software engineer just like the users of your API, so you share their perspective.Don’t you?
        //Well, while you certainly understand their perspective, you don’t necessarily share their perspective.When you’re developing or enhancing your API, you have the perspective of an API designer whereas they have the perspective of an API user.
        //API designers typically focus on questions like “What does this service need to do?” or “What does this service need to provide?”, while API users are focused on “How can I use this API to do what I need?”, or more accurately, “How can I spend the bare minimum of effort to get what I need out of this API?”.
        //These different questions lead to two vastly different perspectives.As a result, the necessary prerequisite to designing a great API is to shift your perspective from that of the API designer to that of the API user. In other words, continually ask yourself the questions you would naturally ask if you were your own user.Rather than thinking about what your API can do, think about the different ways it may need or want to be used and then focus on making those tasks as easy as possible for your API’s users.
        //While this may sound easy and obvious, it’s astounding how infrequently APIs appear to be designed this way.Think about the APIs you’ve encountered in your career. How frequently do they appear to have been designed with this perspective in mind? Web API design can be challenging.
        //So with that said, let’s proceed and talk about the 5 Golden Rules for Designing a Great Web API, namely:


        //Documentation
        //Stability and Consistency
        //Flexibility
        //Security
        //Ease of Adoption


        //A diagram of users accessing a well-designed web API

        //Rule 1: Documentation

        //Documentation. Yes, I’m starting here.
        //Do you hate documentation? Well, I can empathize, but put on your “user perspective” hat and I’ll bet that the one thing you hate more than having to write documentation is having to try to use an undocumented API.I rest my case.
        //The bottom line is that, if you want anyone to use your API, documentation is essential.You’ve simply got to get this right.It’s the first thing users will see, so in some ways it’s like the gift wrap.Present well, and people are more likely to use your API and put up with any idiosyncrasies.
        //So how do we write good documentation?
        //The relatively easy part is documenting the API methods themselves; i.e., example requests and responses, along with descriptions of each of the elements in both.Fortunately, there are an increasing number of software tools that facilitate and simplify the task of generating documentation.Or you can write something yourself that introspects your API, endpoints, and functions, and generates the corresponding documentation for you.

        //But what separates great documentation from adequate documentation is the inclusion of usage examples and, ideally, tutorials. This is what helps the user understand your API and where to start.It orients them and helps them load your API into their brain.

        //For example, if the developers of Twilio were to list out every class, every method, and every possible response to their API, but didn’t bother to mention that you can send an SMS, track a call, or buy a phone number through their API, it would take a really long time for the API user to find that information and understand it cohesively.Can you imagine sorting through a giant tree of classes and methods without any insight into what they were used for, other than their name? Sounds terrible right? But that’s exactly what so many API providers do, thereby leaving their APIs opaque to anybody but themselves.The Rackspace CloudFiles developer and API guide is one such example; it’s difficult to get your bearings unless you already understand what they’re doing and what they’re providing.

        //So write concise tutorials that help get the developer up and running quickly, with at least a skeleton of what they’re trying to do, and then point them in the direction of the more detailed, fully-documented list of functionality so they can expand on what they have.


        //Once you’re done with your documentation, be sure to validate that it makes sense to people other than yourself.Send it out to other developers in your network, give them no instruction other than pointing them to the documentation, and ask them to follow a tutorial or build something really basic in about 15 minutes.If they can’t have a basic integration with your API in 15 minutes, you have more work to do.


        //For some noteworthy examples of excellent and detailed documentation, check out Twilio, Django, and MailChimp. None of these products are necessarily the best in their markets (although they are all good products), yet they do distinguish themeselves by providing some of the best documentation within their markets, which has certainly facilitated their wide acceptance and market share.



        //Rule 2: Stability and Consistency

        //If you’ve ever used Facebook’s API, you know how often they deprecate and completely rewrite their APIs.No matter how much you respect their hacker culture, or their product, theirs is not a developer-friendly perspective. The reason they are still successful is because they have a billion users, not because their API is great.

        //But you probably don’t have the luxury of such a mammoth user base and market share, so you’re going to need have a much less volatile API, keeping old versions running and supported for quite a long period of time. Maybe even years.So toward that end, here are some tips and tricks.


        //Let’s say, for example, that your API is accessible via the URL http://myapisite.com/api/widgets and provides its response in JSON format. While this may seem fine at first blush, what happens when you need to modify the format of the JSON response? Everyone that’s already integrated with you is going to break. Oops.


        //So do some planning ahead, and version your API from the outset, explicitly incorporating a version number into the URL (e.g., http://myapisite.com/api/widgets?version=1 or http://myapisite.com/api/widgets/v1) so that people can rely on version 1 working and can upgrade to any subsequent version when they’re ready to do so. If you need to phase out a prior version at some point, go ahead, but give plenty of notice and offer some sort of transition plan.


        //A good URL scheme will include major versions in the URL. Any change to the output format or supported data types should result in bumping up to a new major version.Generally, it’s acceptable to keep the same version if all you are doing is adding keys or nodes to your output, but to be on the safe side, any time the output changes, bump a version.

        //In addition to being stable over time, APIs need to be internally consistent. I’ve seen many APIs that change parameter names or methods of POSTing data, depending on the endpoint that is being used. Instead, you should handle common parameters globally within your API and use inheritance or a shared architecture to reuse the same naming conventions and data handling consistently throughout your API.

        //Finally, you need to record and publish a changelog to show differences between versions of your API so that users know exactly how to upgrade.



        //Related: Grape Gem Tutorial: How To Build A REST-Like API In Ruby
        //Rule 3: Flexibility

        //Garbage in, garbage out (GIGO) is a well known mantra to most programmers.As applied to web API design, this guiding principle tends to dictate a fairly rigid approach to request validation. Sounds great, right? No mess, no problem.


        //Yet as with everything, there needs to be some balance. As it is not possible to anticipate every way that users will want to employ your service, and since not every client platform is consistent (i.e., not every platform has very good JSON support, a decent OAuth library, etc.), it’s good to have at least some degree of flexibility or tolerance with regard to your input and output constraints.

        //For example, many APIs will support a variety of output formats, like JSON, YAML, XML, et. al., but will only support specifying the format in the URL itself. In the spirit of remaining flexible, you could allow this to also be specified in the URL (e.g., /api/v1/widgets.json), or you might also read and recognize an Accept: application/json HTTP header, or support a querystring variable such as ?format=JSON, and so on.

        //And while we’re at it, why not allow for the format specified to be case-insensitive, so the user could specify ?format=json as well? That’s a classic example of a way to alleviate unnecessary frustration for the user of your API.

        //Another example is allowing for different ways of inputting variables. So, just like you have a variety of output formats, allow for a variety of input formats as well (e.g., plain POST variables, JSON, XML, etc.). You should at least be supporting standard POST variables, and many modern applications support JSON as well, so those two are a good place to start.

        //The point here is that you shouldn’t assume that everyone shares your technical preferences. With a little research into how other APIs work, and through dialog with other developers, you can glean other valuable alternatives that are useful and include them in your API.


        //Like what you're reading?Get the latest updates first.

        //Enter your email address...
        //Get Exclusive Updates
        //No spam. Just great engineering posts.
        //Rule 4: Security

        //Security is obviously one of the most important things to build into your web service, but so many developers make it ridiculously hard to use. As the API provider, you should be offering usable examples of how to authenticate and authorize when accessing your API. This should not be a difficult issue that an end user spends hours working on. Make it your goal that they either don’t have to write any code, or it takes them less than 5 minutes to write it.

        //For most APIs, I prefer a simple token-based authentication, where the token is a random hash assigned to the user and they can reset it at any point if it has been stolen. Allow the token to be passed in through POST or an HTTP header. For example, the user could (and should) send an SHA-1 token as a POST variable, or as a header in a format such as “Authorization: da39a3ee5e6b4b0d3255bfef95601890afd80709”.

        //Also, choose a secure token, not a short numeric identifier. Something irreversible is best. For example, it’s relatively simple to just generate out an SHA token during user creation and store it in the database. Then, you can simply query your database for any users matching that token. You could also do a token generated with a unique identifier and a salt value, something like SHA(User.ID + "abcd123"), and then query for any user that matches; e.g., where TokenFromPost = SHA(User.ID + "abcd123").

        //Another very good option is OAuth 2 + SSL. You should be using SSL anyway, but OAuth 2 is reasonably simple to implement on the server side, and libraries are available for many common programming languages.

        //If the API you have made is supposed to be accessible on a public website via JavaScript, you need to also make sure you validate a list of URLs per-account for the token.That way, nobody can go inspect the calls to your API, steal the token from your user, and go use it for themselves.

        //Here are some other important things to keep in mind:

        //Whitelisting Functionality. APIs generally allow you to do basic create, read, update, and delete operations on data.But you don’t want to allow these operations for every entity, so make sure each has a whitelist of allowable actions. Make sure, for example, that only authorized users can run commands like /user/delete/<id>. Similarly, all useful headers that are sent in the user’s request need to be validated against a whitelist as well.If you are allowing Content-type headers, verify that whatever the user sends in actually matches a whilelist of supported content types. If it doesn’t, then send back an error message such as a 406 Not Acceptable response.Whitelisting is important as a lot of APIs are automatically generated, or use a blacklist instead, which means you have to be explicit about what you don’t want. However, the golden rule of security is to start with absolutely nothing, and only explicitly allow what you do want.
        //Protect yourself against Cross-Site Request Forgery (CSRF). If you are allowing session or cookie authentication, you need to make sure that you’re protecting yourself from CSRF attacks.The Open Web Application Security Project (OWASP) provides useful guidance on ways to preclude these vulnerabilities.
        //Validate access to resources.In every request, you need to verify that a user is in fact allowed access to the specific item they are referencing. So, if you have an endpoint to view a user’s credit card details (e.g., /account/card/view/152423), be sure that the ID “152423” is referencing a resource that the user really is authorized to access.
        //Validate all input.All input from a user needs to be securely parsed, preferably using a well-known library if you are using complicated input like XML or JSON.Don’t build your own parser, or you’re in for a world of hurt.

        //Rule 5: Ease Of Adoption

        //This is really the most important rule in the bunch, and builds on all the others. As I mentioned during the documentation rule, try this out with people that are new to your API.Make sure that they can get up and running with at least a basic implementation of your API, even if it’s just following a tutorial, within a few minutes.I think 15 minutes is a good goal.

        //Here are some specific recommendations to ease and facilitate adoption of your API:


        //Make sure people can actually use your API and that it works the first time, every time. Have new people try to implement your API occasionally to verify that it’s not confusing in some way that you’ve become immune to.
        //Keep it simple. Don’t do any fancy authentication.Don’t do some crazy custom URL scheme.Don’t reinvent SOAP, or JSON, or REST, or anything. Use all the tools you can that have already been implemented and are widely accepted, so that developers only have to learn your API, not your API + 10 obscure new technologies.
        //Provide language-specific libraries to interface with your service.There are some nice tools to automatically generate a library for you, such as Alpaca or Apache Thrift. Currently Alpaca supports Node, PHP, Python, and Ruby. Thrift supports C++, Java, Python, PHP, Ruby, Erlang, Perl, Haskell, C#, Cocoa, JavaScript, Node.js, Smalltalk, OCaml, Delphi and more.
        //Simplify any necessary signup.If you are not developing an open source API, or if there is a signup process of any sort, make sure that upon signup, a user is very quickly directed to a tutorial. And make the signup process completely automated without any need for human interaction on your part.
        //Provide excellent support.A big barrier to adoption is lack of support.How will you handle and respond to a bug report? What about unclear documentation? An unsophisticated user? Forums, bug trackers, and email support are fantastic starts, but do make sure that when someone posts a bug, you really address it. Nobody wants to see a ghost town forum or a giant list of bugs that haven’t been addressed.
        //Web API Wrap-up

        //Web services and their APIs abound.Unfortunately, the vast majority are difficult to use.Reasons range from poor design, to lack of documentation, to volatility, to unresolved bugs, or, in some cases, all of the above.


        //Following the guidance in this post will help ensure that your web API is clean, well-documented, and easy-to-use.Such APIs are truly rare and are therefore that much more likely to be widely adopted and used.



    }
}
