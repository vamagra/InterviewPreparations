using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Design.BrainTeasers
{
    class BrainTeasers
    {
        #region Teaser 1 Two Ropes
        // You have two ropes, and each takes exactly one hour to burn.How would you use them
        // to time exactly 15 minutes? Note that the ropes are of uneven densities, 
        // so half the rope length-wise does not necessarily 
        // take half an hour to burn.
        // Solution -
        // From start to end, our approach is as follows:
        // 1. Light rope 1 at both ends and rope 2 at one end.
        // 2. When the two flames on Rope 1 meet, 30 minutes will have passed.Rope 2 has 30
        //  minutes left of burn-time.
        // 3. At that point, light Rope 2 at the other end.
        // 4. In exactly fifteen minutes, Rope 2 will be completely burnt.
        #endregion

        #region Teaser 2 Nine Balls
        // The "nine balls" question is a classic interview question.You have nine balls.Eight are
        // of the same weight, and one is heavier.You are given a balance which tells you only
        // whether the left side or the right side is heavier.Find the heavy ball in just two uses of
        // the scale.
        // Solution
        // If we divide the balls into sets of three items each, we will know after just one weighing
        //which set has the heavy one.We can even formalize this into a rule: given N balls, where
        //N is divisible by 3, one use of the scale will point us to a set of N/3 balls with the heavy
        //ball.
        //For the final set of three balls, we simply repeat this: put one ball off to the side and
        //weigh two. Pick the heavier of the two. Or, if the balls are the same weight, pick the third
        //one.
        #endregion

        #region Teaser 3 20 bottles of pills - No Solution Yet 
        // You have 20 bottles of pills. 19 bottles have 1.0 gram pills, 
        // but one has pills of weight 1.1 grams.Given a scale that provides an 
        // exact measurement, how would you find the heavy bottle? You can only 
        // use the scale once.

        // Solution - 
        // 1. Take the 1 pill from bottle 1, 2 pills from bottle 2 and so on.
        // 2. ideally  
        #endregion

        #region Teaser 4 - 8x8 chessboard Covered by dominoes
        // There is an 8x8 chess board in which two diagonally opposite corners have
        // been cut off.You are given 31 dominos, and a single domino can cover exactly
        // two squares.Can you use the 31 dominos to cover the entire board? Prove your
        // answer(by providing an example or showing why it's impossible).
        // Solution - http://puzzles.nigelcoldwell.co.uk/sixteen.htm
        // Do you notice anything about the squares at 1,1 and 8,8? Well they are both the same colour. 
        // If you think about a Domino placed anywhere on the board it will necessarily cover a black 
        // square and a white square.We have in our example a 32 black squares and 30 white squares to cover. 
        // So it just can't be done.
        #endregion

        #region Teaser 5 - Fill Water 5lt & 3lt - Measure 4 lt
        // You have a five-quart jug, a three-quart jug, and an unlimited supply of water
        // (but no measuring cups). How would you come up with exactly four quarts of
        // water? Note that the jugs are oddly shaped, such that filling up exactly "half"of
        // the jug would be impossible.
        // Solution - http://puzzles.nigelcoldwell.co.uk/twentytwo.htm
        // 1. Fill 3lt water 
        // 2. now pour this 3lt to 5 lt jug
        // 3. now fill 3lt again
        // 4. now fill 2lt from 3lt jug to 5 lt (beacuse it has only 2 lt space)
        // 5. 3lt will have 1 lt left
        // 6. throw 5 lt water
        // 7. fill 1lt from 3lt jug to 5 lt.
        // 8. fill 3lt jug again
        // 9. now pour water from 3lt jug to 5 lt
        // 10. 5lt will have 4 lt water
        #endregion

        #region Teaser 6 - Blue eye person on Island
        // A bunch of people are living on an island, when a visitor comes with a strange
        // order: all blue-eyed people must leave the island as soon as possible.There will be a flight out at 8:00pm every evening.
        // Each person can see everyone else's eye color, but they do not know their own (nor is anyone allowed to tell them).
        // Additionally, they do not know how many people have blue eyes, although they do know that at least one person does. How many days will it take the blue-eyed people to leave?
        // Solution
        // Solution: Assume that there are n people on the island and c of them have blue eyes. We are explicitly told that c > 0.
        // Case c = 1: Exactly one person has blue eyes
        // The blue-eyed person should look around and realize that no one else has blue eyes.Since, he knows that at least one person has blue eyes, he must conclude that it is he who has blue eyes.Therefore he would take the flight that evening.
        // Case c = 2: Exactly two person has blue eyes
        // The two blue-eyed people see each other, but are unsure whether c is 1 or 2. They know from the previous case that if c = 1, the blue eyed-person would leave on the first night.
        // Therefore, if the other blue-eyed person is still there, he must deduce that c= 2 which means he himself has blue eyes.Both men would then leave on the second night.
        // Case c > 2: The general case
        // As we increase c, we can see that this logic continues to apply. If c = 3, then those three people will immediately know that there are either 2 or 3 people with blue eyes. 
        // If there were two people, then those two people would have left on the second night.So, when the others are still around after that night, each person would conclude that c = 3 and that they, 
        // therefore, have blue eyes too. They would leave that night.
        // This same pattern extends up through any value of c. Therefore, if c men have blue eyes, it will take c nights for the blue-eyed men to leave. All will leave on the same night.
        #endregion

        #region Teaser 7 - Two Egss Drop Problem
        // There is a building of 100 floors. If an egg drops from the Nth floor or above, 
        // it will break. If it's dropped from any floor below, it will not break. 
        // You're given two eggs.Find N, while minimizing the number of 
        // drops for the worst case.
        // Solution - https://medium.com/@khopsickle/2-eggs-and-100-floors-a032beb77aaa
        #endregion

        #region Teaser 8 - 100 Doors
        // There are 100 closed lockers in a hallway.A man begins by opening all 100
        // lockers.Next, he closes every second locker.Then, on his third pass, he toggles
        // every third locker (closes it if it is open or opens it if it is closed). 
        // This process continues for 100 passes, such that on each pass i, the man toggles 
        // every ith locker.After his 100th pass in the hallway, in which he toggles
        // only locker #100, how many lockers are open?
        // Solution
        // The number of toggles of a door determines its final status.If a door is toggled for odd times, 
        // it will end up with open.If even time, the door will be closed at the end.
        // Also noticed that, after nth pass, door number <= n will not be touched anymore.
        // For door #1, it will be toggled once therefore it will end up open.
        // For door #2, it will be toggled twice (in pass 1 and 2) and is end up closed.
        // For door #3, it is toggled twice (pass 1, 3) and ends up closed.
        // For door #4, it is toggled 3 times (pass 1, 2, 4) and ends up open. 
        // ....
        // For door #100, it is toggled 9 times (pass 1, 2, 4, 5, 10, 20, 25, 50 and 100) and ends up open.
        // Therefore, this problem can be reduced to finding the numbers that have odd number of factors 
        // between 1 and itself, and 1, 4, 9, 16, 25, 36, 49, 64, 81 and 100 has this property.This is because 
        // all other numbers have even number of factors that can multiply to itself while the above 10 have 
        // one mroe, which is the square root of itself.
        #endregion

        #region Teaser 9 - Basket Ball Choose Game
        // You have a basketball hoop and someone says that you can play one of two games.
        // Game 1: You get one shot to make the hoop.
        // Game 2: You get three shots and you have to make two of three shots.
        // If p is the probability of making a particular shot, for which values of p should
        // you pick one game or the other?
        // Solution - 
        // Game 1:
        // P(game1) = p
        // Game 2: 
        // P(game2)=P(make 1 and 2) + P(make 1 and 3) + P(make 2 and 3) + P(make 1, 2 and 3)
        // = p * p * (1-p) + p *(1-p) *p + (1-p)* p *p + p * p * p
        // = 3p^2 - 2p^3
        // play Game 1 if:
        // P(game1) > P(game2)
        // => p > 3p^2 - 2p^3
        // => p(p-1)(2p-1) > 0 note that 0<=p<=1
        // => p< 1/2
        // If p = 0 or p = 1/2 or p = 1, then it doesn't matter which game to play.

        #endregion

        #region Teaser 10 - Ants Collision
        //  There are three ants on different vertices of a triangle.What is the probability of
        //  collision (between any two or all of them) if they start walking on the sides of the
        //  triangle? Assume that each ant randomly picks a direction, with either direction
        //  being equally likely to be chosen, and that they walk at the same speed.
        //  Similarly, find the probability of collision with n ants on an n-vertex polygon.


        #endregion
    }
}
