using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Design
{
    class DesignParkingLotClass
    {

//        1. Handle Ambugity
//          -- What kind of problem area he wants to get into
//          -- Do you want me to come up with System Design
//          -- Do you want me to come up with class hierachy
//          -- Do you want me to answer some specific questions and write some specific methods


//2. Systematic Approach 
//          -- How you approach the problem
//          -- Ask intelligent questions and Find out left details
          
//3. 4 Sizes Cars 
//          -- small, Medium, large, XL


//     Abstract Vehicle
//        -- string license plate
//        -- enum color
//    |     |     |     |
//    |     |     |     |
//   Car Motor  Bus Truck
//         Cycle




//Class Parkinglot
//{
//     // Constructor
//     Parkinglot(int zipCode)
//        {

//        }

//        // Spot placeVehicle(Vehicle objVehicle);

//    }

//    //
//    Class Spot
//   -- long id
//   -- enum size

//--------------------------------------------

//Coding Part - 

//To place the vehicle we need to make sure that we should be able to get the space availability in O(1) time, List of spots can be option but that would be linear approach where to find out free space we need to traverse the list and check for the space one by one.

//Stack can be better option - 

// 4 stacks for 4 size cars
//   ** place vehicle O(1)

 // Remove Vehicle
     //** use Hashmap


    }
}
