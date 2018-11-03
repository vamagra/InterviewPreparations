using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MicrosoftInterviewQuestionsList
    {
        #region Algorithm Questions

        //1. Given a long string and a small pattern, find whether any permutation of the pattern in present in the string 
        //   (Working Code  and a dry run expected, not pseudocode). Find the space and time complexity.

        //2. Given an array of integers, write pseudocode to find the smallest non-negative integer not present in the array (can use additional space)

        //3. Consider a n*n grid. Suppose each cell in the grid has a value assigned.  
        //   We can go from each cell in row i to a diagonally higher cell in row i+1 only [i.e from cell(i,j) to cell(i+1, j-1) and cell(i+1, j+1) only] . Write a pseudocode to find a path from bottom row to top row such that the maximum value is obtained.

        //4. Suppose you have a binary tree. What is the best way to serialize and send this information such that the receiver can construct the tree correctly.

        //5. Given a n*n grid where most cells are cubicles and m cells (m << n^2) are pantries.
        //   There can be walls between two cubicles through which we cannot have a path. Given the locations of walls and pantries, for a given cubicle find the nearest pantry. Working code expected.

        //6. time complexity to find 10th largest number in a heap

        //7. time complexity to find 10th largest number in an array

        //8. Consider twitter. The requirement is to show the top 10 trending hashtags at a given time. How will you analyze/store the twitter feed to show this data.

        //9. Design an Elevator System for a building where number of elevators can be increased later.

        //10. Write a C function that takes a string and delimiter as input, splits the string based on the delimiter and returns a list of resulting sub strings.

        //11. Implement stack using queue and reverse of it.

        //12. Find loop in a linklist and remove loop.

        //13. Implement word search using LL and arrays only.

        //14. Flipkart use case, what all web services and module you can think of and how load is distributed and then discussion on search service.

        //15. Singleton Pattern detail discussion

        //16. Give next closest greater time e.g. 13:45 –>13:51

        //17. Reverse a stack using recursion.

        #endregion

        #region Telephonic Preparation

        //Q. Difference between process and thread
        // Answer -

        //Q2. Discussion on sharding and distributed Concepts

        //Q3. One design question for car factory.. basically checking DI for car and engine relationship.

        //**Q4. Design discussion on dependency injection, Implementation, IOC, SL and IOC Containers
        //Answer -  , 
        //         https://stackoverflow.com/questions/130794/what-is-dependency-injection

        // Q. Scrolling Performance
        // Answer - https://www.html5rocks.com/en/tutorials/speed/scrolling/#toc-specifics

        //**Q6. Design your own logger - https://www.infoworld.com/article/2980677/application-development/implement-a-simple-logger-in-c.html

        //Q5. Question related to Https and database security

        //Q1.      What is the differnce between stateless request and state request **
        //Answer - https://stackoverflow.com/questions/5329618/stateless-vs-stateful-i-could-use-some-concrete-information,
        // https://nordicapis.com/defining-stateful-vs-stateless-web-services/

        // Q2. What is the best practise to design Rest Api **
        // Answer - https://blog.mwaysolutions.com/2014/06/05/10-best-practices-for-better-restful-api/, 
        // https://hackernoon.com/restful-api-designing-guidelines-the-best-practices-60e1d954e7c9

        // Q - Webapi Patch verb operation 
        // Answer - http://benfoster.io/blog/aspnet-core-json-patch-partial-api-updates

        //Q2.1   - Explain CORS **
        //Answer - https://www.codecademy.com/articles/what-is-cors

        //Q3. Rest Api and Web Api
        //Answer - https://blogs.msdn.microsoft.com/martinkearn/2015/01/05/introduction-to-rest-and-net-web-api/, 
        //  https://nordicapis.com/rest-vs-soap-nordic-apis-infographic-comparison/

        //Q4. Web Services vs Web Apis
        //Answer - https://stackoverflow.com/questions/19336347/what-is-the-difference-between-a-web-api-and-a-web-service

        //Q5 - MVC Interview Questions List **
        //Answer - https://www.c-sharpcorner.com/UploadFile/8ef97c/most-asked-Asp-Net-mvc-interview-questions-and-answers/

        // #Design
        //Q6 - Design Principle
        //Answer - http://www2.cs.uh.edu/~svenkat/SoftwareDesign/slides/ObjectOrientedDesignPrinciples.pdf, https://www.codeproject.com/Articles/567768/Object-Oriented-Design-Principles

        // Builder Pattern
        // https://vivekcek.wordpress.com/tag/builder-pattern-real-world-example/


        //Javascript Question

        // Answer - https://www.tutorialspoint.com/javascript/javascript_interview_questions.htm, 
        //          https://github.com/ganqqwerty/123-Essential-JavaScript-Interview-Question

        // - Difference between ES5 and ES6
        // - Event Delegation
        // - https://davidwalsh.name/event-delegate

        // - Explain 'this'
        // - https://codeburst.io/the-simple-rules-to-this-in-javascript-35d97f31bde3

        // - prototypal inheritance
        // - https://medium.com/javascript-scene/master-the-javascript-interview-what-s-the-difference-between-class-prototypal-inheritance-e4cd0a7562e9

        // Jaavscript - what the heck is callback
        // Answer - https://codeburst.io/javascript-what-the-heck-is-a-callback-aba4da2deced

        // Difference between apply, call, bind
        // https://medium.com/@ivansifrim/the-differences-between-call-apply-bind-276724bb825b

        // Javscript - Null vs. Undefined
        // https://basarat.gitbooks.io/typescript/content/docs/javascript/null-undefined.html

        // - difference between a variable that is: null, undefined or undeclared?
        // - https://stackoverflow.com/questions/15985875/effect-of-declared-and-undeclared-variables

        // - IIFE stands for Immediately Invoked Function Expressions
        // - http://lucybain.com/blog/2014/immediately-invoked-function-expression/

        // - What do you think of AMD vs CommonJS?
        // - https://stackoverflow.com/questions/16521471/relation-between-commonjs-amd-and-requirejs

        // - What is a closure, and how/why would you use one?
        // - http://javascriptissexy.com/understand-javascript-closures-with-ease/

        // - What is the difference between =,==, and ===
        // - https://www.codecademy.com/en/forum_questions/558ea4f5e39efed371000508

        // - Cross-site scripting (XSS) - 
        // - https://excess-xss.com/




        // TypeScript - Difference between var, let and const
        // - https://codeburst.io/difference-between-let-and-var-in-javascript-537410b2d707
        // - https://dev.to/sarah_chima/var-let-and-const--whats-the-difference-69e

        // TypeScript (https://basarat.gitbooks.io/typescript/docs/types/never.html, http://www.tutorialsteacher.com/typescript/typescript-union)
        //  - TypeAnnotations
        //  - ReverseMapping Enums
        //  - Any
        //  - Union Datatype
        //  - Never 
        //  - let, var and const
        //  - Type Inference
        //  - Type Assestion
        //  - for-of loop
        //  - for-in loop
        //  - Named Function
        //  - Anonymous Funcion
        //  - Optional Paramter
        //  - Default Paramenter
        //  - Arrow Function (fat arrow)   
        //  - Function Overloading
        // -  Rest Parameters
        // -  Interfaces
        // -  Interface as Type of Variable
        // -  Interface as Function Type
        // -  Interface as Array Type
        // -  Optional Properties in Interfaces
        // -  Readonly Properties in Interfaces
        // -  Class 
        // -  Class extents Interfaces
        // -  Interfaces extens Classes
        // -  Method Overriding
        // -  Method Overloading (number of parameter should be same)
        // -  Abstract Class
        // -  Static ( Class cannot be static in Typescript)
        // -  Module
        // -  Export and Import Modules
        // -  Module Compiling
        // -  Namespaces
        // -  




        // C# Language

        // - Value Type vs Reference Type
        // - https://www.educative.io/collection/page/5679346740101120/5707702298738688/5685265389584384

        // C# - Difference between Static Class and Singleton Pattern in C#
        // Answer- https://stackoverflow.com/questions/519520/difference-between-static-class-and-singleton-pattern

        // C# - What is [Serializable] and when should I use it?
        // Answer - https://stackoverflow.com/questions/5877808/what-is-serializable-and-when-should-i-use-it, https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/index

        // C# - Singleton Design Pattern OOPS
        // Answer - http://www.csharpstar.com/singleton-design-pattern-csharp/
        //        - http://csharpindepth.com/Articles/General/Singleton.aspx

        // C# - Object Oriented Programming Language
        // i)   https://www.codementor.io/codementorteam/11-important-c-sharp-interview-questions-and-oop-concepts-hd5e7g2s6
        // ii)  http://www.csharpstar.com/top-30-oops-interview-questions/

        // C# - Serialize and Deserialize data
        //      http://www.csharpstar.com/serialize-and-deserialize-data-csharp/

        // C# - Extension Methods
        // http://www.csharpstar.com/extension-methods-csharp/

        // C# - Best Practises
        // 

        // HashTable, HashMap and HashSet Difference
        // => Hashtable
        //Hashtable is basically a data structure to retain values of key-value pair.

        //It does not allow null for both key and value. It will throw NullPointerException.
        //Hashtable does not maintain insertion order. The order is defined by the Hash function.So only use this if you do not need data in order.
        //It is synchronized.It is slow.Only one thread can access in one time.
        //HashTable rea thread safe.
        //HashTable uses Enumerator to iterate through elements.
        //Hashtable<Integer, String>; myTable= new Hashtable<Integer, String>();
        //myTable.put(1, "John");
        //myTable.put(2, "Cena");
        //myTable.put(3, null); /* NullPointerEcxeption at runtime*/
        //System.out.println(myTable.get(1));
        //System.out.println(myTable.get(2));
        //System.out.println(myTable.get(3));

        // => HashMap

        //Like Hashtable it also accepts key value pair.

        //It allows null for both key and value.
        //HashMap does not maintain insertion order.The order is defined by the Hash function.
        //It is not synchronized. It will have better performance.
        //HashMap are not thread safe, but you can use Collections.synchronizedMap(new HashMap<K, V>())
        //HashMap<Integer, String> myMap = new HashMap<Integer, String>();
        //        myMap.put(1, "First");
        //myMap.put(2,"Second");
        //myMap.put(3, null);

        //  => HashSet

        //HashSet does not allow duplicate values.

        //It provides add method rather put method.
        //You also use its contain method to check whether the object is already available in HashSet.HashSet can be used where you want to maintain a unique list.
        //HashSet<String> mySet= new HashSet<String>();
        //        mySet.add ("First");
        //mySet.add ("Second");
        //mySet.add ("Third");

        //if(mySet.contains("First")){
        //	System.out.println("The Set already contains First");
        //    }



        // OOPS - Dependecy Injection
        // https://www.dotnettricks.com/learn/dependencyinjection/implementation-of-dependency-injection-pattern-in-csharp


        // C# - How to update web.config programatically?
        // Answer - http://www.dotnetcurry.com/ShowArticle.aspx?ID=102

        //Q10: Design Pattern Questions and Answer
        //Answer - http://www.tutorialspoint.com/design_pattern/design_pattern_interview_questions.htm, https://github.com/MaximAbramchuck/awesome-interview-questions#c-2

        // C# Interview Questions
        // Answer - http://www.csharpstar.com/csharp-interview-questions-part-1/

        // AngularJs  Interview Questions
        // Answer - https://github.com/twang281314/frontEnd/blob/master/book/AngularJS%20Interview%20Questions%20&%20Answers%20-%20By%20Shailendra%20Chauhan.pdf

        // Full Stack Developer Topics
        // Answer - https://github.com/indy256/Full-stack-Developer-Interview-Questions-and-Answers

        // Q8 - Frontend Interview Questions and Answers
        // Answer - http://www.thatjsdude.com/interview/js2.html,  http://www.thatjsdude.com/interview/js1.html, http://www.thatjsdude.com/interview/dom.html, http://www.thatjsdude.com/interview/css.html
        //        - http://www.thatjsdude.com/interview/html.html, https://github.com/yangshun/front-end-interview-handbook/blob/master/questions/javascript-questions.md

        //Q9. Cheat Sheet Technical Interview
        // Answer - https://gist.github.com/TSiege/cbb0507082bb18ff7e4b

        // CSharp Star

        // AngularJs Questions

        // OOPS Questions 

        //https://www.pramp.com/about#/

        #endregion
    }
}
