using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Geometry
{
    /*
     On an infinite plane, a robot initially stands at (0, 0) and faces north. The robot can receive one of three instructions:

"G": go straight 1 unit;
"L": turn 90 degrees to the left;
"R": turn 90 degrees to the right.
The robot performs the instructions given in order, and repeats them forever.

Return true if and only if there exists a circle in the plane such that the robot never leaves the circle.

 

Example 1:

Input: instructions = "GGLLGG"
Output: true
Explanation: The robot moves from (0,0) to (0,2), turns 180 degrees, and then returns to (0,0).
When repeating these instructions, the robot remains in the circle of radius 2 centered at the origin.
    */
    public class RobotBoundInCircle
    {
        public static bool IsRobotBounded(string instructions)
        {
            int dirX = 0;
            int dirY = 1;
            int x = 0;
            int y = 0;

            foreach (var i in instructions)
            {
                if (i == 'G')
                {
                    x = x + dirX;
                    y = y + dirY;
                }
                // Need to store dirX and dirY in temp, as they are getting overwritten
                else if (i == 'L')
                {
                    var temp = dirX;
                    dirX = -1 * dirY;
                    dirY = temp;
                }
                else if (i == 'R')
                {
                    var temp2 = dirX;
                    dirX = dirY;
                    dirY = -1 * temp2;
                }
            }

            // if x and y are still 0,0 or direction has changed
            if ((x == 0 && y == 0) || (dirX != 0 || dirY != 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
