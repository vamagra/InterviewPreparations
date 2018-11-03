using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode._CrakingTheCodeInterview
{
    /// <summary>
    /// /**
	//  * 
	//  *  3.4 In the classic problem of the Towers of Hanoi, you have 3 towers and N disks of
    //   * different sizes which can slide onto any tower.The puzzle starts with disks sorted   
    //  *  in ascending order of size from top to bottom(i.e., each disk sits on top of an even
	//*  larger one). You have the following constraints:
    //   *  (1) Only one disk can be moved at a time.
    //   *  (2) A disk is slid off the top of one tower onto the next tower.
    //   *  (3) A disk can only be placed on top of a larger disk.
	//*  Write a program to move the disks from the first tower to the last using stacks.
    //   *
    //   * Solution:
    //   * To move N disks from tower A to tower B:
    //   *  1. move top N -1 disks from tower A to tower C
    //   *  2. move N'th disk from tower A to tower B
    //   *  3. move top N-1 disks from tower C to tower B
    /// </summary>
    class TowerOfHanoiDiskArrangements
    {
        int diskNumber = 3;
        Tower[] myTower = new Tower[3];

        // Initialize all three towers

        TowerOfHanoiDiskArrangements()
        {
            for (int i = 0; i < 3; i++)
            {
                myTower[i] = new Tower(i);
            }

            for (int i = diskNumber - 1; i >= 0; i--)
            {
                myTower[0].add(i);
            }

            myTower[0].moveDisk(diskNumber, myTower[1], myTower[2]);
        }
    }

    class Tower
    {
        Stack<int> disks;
        int index;

        public Tower(int i)
        {
            disks = new Stack<int>();
            index = i;
        }

        public void add(int data)
        {
            if (disks.Peek() < data)
            {
                throw new Exception("Error placing disk on tower");
            }

            disks.Push(data);
        }

        public void moveDisk(int diskNumber, Tower buffer, Tower destination)
        {

        }
    }
}
