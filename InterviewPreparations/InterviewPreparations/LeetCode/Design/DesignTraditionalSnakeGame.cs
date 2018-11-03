using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparations.LeetCode.Design
{
    class DesignTraditionalSnakeGame
    {
        int len;
        int foodIdx;

        ScreenNode head;
        ScreenNode tail;
        bool over;
        ScreenNode[,] screen;
        List<int[,]> food; 

        DesignTraditionalSnakeGame(int width, int height, List<int[,]> food)
        {
            screen = new ScreenNode[width + 1, height + 1];
            len = 0;
            foodIdx = 0;
            over = false;

            head = new ScreenNode(0, 0);
            tail = head;
            this.food = food;
        }

        public int Move(char direction)
        {
            int x = head.x;
            int y = head.y;

            // move the snake coordinate based on direction
            if (direction == 'U')
            {
                y++;
            }
            else if (direction == 'L')
            {
                x--;
            }
            else if (direction == 'D')
            {
                y--;
            }
            else if (direction == 'R')
            {
                x++;
            }
            else
            {
                return -1;
            }

            // check the move after position update
            if (!check(x, y))
            {
                over = true;
                return -1;
            }

            // move the snake position in the screen
            Move(x, y);

            len += eat(x, y);

            return len - 1;
        }

        private int eat(int x, int y)
        {
            throw new NotImplementedException();
        }

        private void Move(int x, int y)
        {
            ScreenNode node = new ScreenNode(x, y);
            screen[x, y] = node;

            head.prev = node;
            head = node;
        }

        // check if snake coordinated are within screen coordinates
        private bool check(int x, int y)
        {
            return (!over && x >= 0 && y >= 0 && x <= screen.GetLength(0) && y <= screen.GetLength(1));
        }
    }

    public class ScreenNode
    {
        public int x;
        public int y;
        public ScreenNode prev;

        public ScreenNode(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
    }
}
