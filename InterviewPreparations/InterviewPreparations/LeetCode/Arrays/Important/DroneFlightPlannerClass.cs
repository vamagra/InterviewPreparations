using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode
{
    class DroneFlightPlannerClass
    {
        // <summary>
        // You’re an engineer at a disruptive drone delivery startup and your CTO asks you to come up with an efficient algorithm that calculates the minimum amount of energy required for the company’s drone to complete its flight. You know that the drone burns 1 kWh (kilowatt-hour is an energy unit) for every mile it ascends, and it gains 1 kWh for every mile it descends. Flying sideways neither burns nor adds any energy.

        //        Given an array route of 3D points, implement a function calcDroneMinEnergy that computes and returns the minimal amount of energy the drone would need to complete its route.Assume that the drone starts its flight at the first point in route.That is, no energy was expended to place the drone at the starting point.

        //      For simplicity, every 3D point will be represented as an integer array whose length is 3. Also, the values at indexes 0, 1, and 2 represent the x, y and z coordinates in a 3D point, respectively.

        //      Explain your solution and analyze its time and space complexities.


        //      Example:


        //      input:  route = [ [0, 2, 10],
        //                        [3,   5,  0],
        //                        [9,  20,  6],
        //                        [10, 12, 15],
        //                        [10, 10,  8] ]

        //output: 5 # less than 5 kWh and the drone would crash before the finish
        //          # line. More than `5` kWh and it’d end up with excess energy
        //Constraints:

        //[time limit] 5000ms

        //[input] array.array.integer route

        //1 ≤ route.length ≤ 100
        //[output] integer
        /// </summary>
        /// <param name="routes"></param>
        /// <returns></returns>
        public static int CalculateDroneMinEnergy(int[,] route)
        {
            /*
 X = 0 

 [0, 2, 10]  x = 0, y = 2, z = 10 height
 [3,   5,  0], 

          - 15 D

10------------------------------------------

8                        - E

6      _  C


0   _ B


------------------
          E  D    C


         B
*/
            //A(0, 2) -> (3, 5 ) -> height change from 10 to 0, gain 10, complete two positions change from (0,2,10) to (3, 5, 0) - (+10 KWH) ->  

            // 0-----------------

            /*[0, 2, 10] - Drone staring point is  (10) -> ( 3 5 0) -> (9, 20, 6)  - [10, 12, 15] 
            => Max (Z point of all routes) - Staring point of Z

            => 10 KWH
            [
              [0, 2, 15]
              [2,5, 10]
              [4, 8, 12]
              [5, 7, 14]
              [4, 5, 25]
            ]*/

            // your code goes here      
            if (route.Length < 1)
            {
                return -1;
            }

            int rows = route.GetLength(0);

            int startZ = route[0, 2];

            int maxEnergy = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                if (route[i, 2] > maxEnergy)
                {
                    maxEnergy = route[i, 2];
                }
            }

            int minEnergy = maxEnergy - startZ;
            return minEnergy;
        }
    }
}
