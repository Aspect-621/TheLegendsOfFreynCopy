﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_FinalProj
{
    internal class MovementPlayer
    {
        public int[] Movement(int x, int y, int right, int bottom, int keypressed, int[,] obstacles)
        {
            int[] newPosition = new int[4];
            newPosition[0] = x;
            newPosition[1] = y;
            newPosition[2] = right;
            newPosition[3] = bottom;
            switch (keypressed)
            {
                case 87:
                    newPosition[1] -= 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[1] == obstacles[i, 3] || newPosition[1] == obstacles[i, 3] + 1 || newPosition[1] == obstacles[i, 3] + 2 || newPosition[1] == obstacles[i, 3] + 3 || newPosition[1] == obstacles[i, 3] + 4 || newPosition[1] == obstacles[i, 3] + 5) &&
                           ((newPosition[0] > obstacles[i, 0] && newPosition[2] < obstacles[i, 2]) ||
                           (newPosition[0] <= obstacles[i, 0] && newPosition[2] >= obstacles[i, 0]) ||
                           (newPosition[2] >= obstacles[i, 2] && newPosition[0] <= obstacles[i, 2])))
                        {
                            newPosition[1] += 5;
                            break;
                        }
                    }
                    break;
                case 65:
                    newPosition[0] -= 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[0] == obstacles[i, 2] || newPosition[0] == obstacles[i, 2] + 1 || newPosition[0] == obstacles[i, 2] + 2 || newPosition[0] == obstacles[i, 2] + 3 || newPosition[0] == obstacles[i, 2] + 4 || newPosition[0] == obstacles[i, 2] + 5) &&
                           ((newPosition[1] > obstacles[i, 1] && newPosition[3] < obstacles[i, 3]) ||
                           (newPosition[1] <= obstacles[i, 1] && newPosition[3] >= obstacles[i, 1]) ||
                           (newPosition[3] >= obstacles[i, 3] && newPosition[1] <= obstacles[i, 3])))
                        {
                            newPosition[0] += 5;
                            break;
                        }
                    }

                    break;
                case 83:
                    newPosition[1] += 5;
                    newPosition[3] += 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[3] == obstacles[i, 1] || newPosition[3] == obstacles[i, 1] + 1 || newPosition[3] == obstacles[i, 1] + 2 || newPosition[3] == obstacles[i, 1] + 3 || newPosition[3] == obstacles[i, 1] + 4 || newPosition[3] == obstacles[i, 1] + 5) &&
                           ((newPosition[0] > obstacles[i, 0] && newPosition[2] < obstacles[i, 2]) ||
                           (newPosition[0] <= obstacles[i, 0] && newPosition[2] >= obstacles[i, 0]) ||
                           (newPosition[2] >= obstacles[i, 2] && newPosition[0] <= obstacles[i, 2])))
                        {
                            newPosition[1] -= 5;
                            break;
                        }
                    }
                    break;
                case 68:
                    newPosition[0] += 5;
                    newPosition[2] += 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[2] == obstacles[i, 0] || newPosition[2] == obstacles[i, 0] + 1 || newPosition[2] == obstacles[i, 0] + 2 || newPosition[2] == obstacles[i, 0] + 3 || newPosition[2] == obstacles[i, 0] + 4 || newPosition[2] == obstacles[i, 0] + 5) &&
                           ((newPosition[1] > obstacles[i, 1] && newPosition[3] < obstacles[i, 3]) ||
                           (newPosition[1] <= obstacles[i, 1] && newPosition[3] >= obstacles[i, 1]) ||
                           (newPosition[3] >= obstacles[i, 3] && newPosition[1] <= obstacles[i, 3])))
                        {
                            newPosition[0] -= 5;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
            return newPosition;
        }

        public int collisionChecker(int[] newPosition, int[,] moblocation, string[] mob)
        {

            for (int i = 0; i < moblocation.GetLength(0); i++)
            {
                if ((newPosition[1] <= moblocation[i, 3] + 5 && newPosition[1] >= moblocation[i, 1] - 5) &&
                    ((newPosition[0] > moblocation[i, 0] && newPosition[2] < moblocation[i, 2]) ||
                    (newPosition[0] <= moblocation[i, 0] && newPosition[2] >= moblocation[i, 0]) ||
                    (newPosition[2] >= moblocation[i, 2] && newPosition[0] <= moblocation[i, 2])))
                {
                    if (mob[i] == "Goblin")
                    {
                        MessageBox.Show("GOBLIN HEHE");
                        return 1;
                    }
                    else if (mob[i] == "Teleport")
                    {
                        return 2;
                    }
                    break;
                }

                else if (newPosition[0] <= moblocation[i, 2] + 5 && newPosition[0] >= moblocation[i, 0] - 5 &&
                   ((newPosition[1] > moblocation[i, 1] && newPosition[3] < moblocation[i, 3]) ||
                   (newPosition[1] <= moblocation[i, 1] && newPosition[3] >= moblocation[i, 1]) ||
                   (newPosition[3] >= moblocation[i, 3] && newPosition[1] <= moblocation[i, 3])))
                {
                    if (mob[i] == "Goblin")
                    {
                        MessageBox.Show("GOBLIN HEHE");
                        return 1;
                    }
                    else if (mob[i] == "Teleport")
                    {
                        return 2;
                    }
                    break;
                }

                else if (newPosition[3] >= moblocation[i, 1] - 5 && newPosition[3] <= moblocation[i, 3] + 5 &&
                   ((newPosition[0] > moblocation[i, 0] && newPosition[2] < moblocation[i, 2]) ||
                   (newPosition[0] <= moblocation[i, 0] && newPosition[2] >= moblocation[i, 0]) ||
                   (newPosition[2] >= moblocation[i, 2] && newPosition[0] <= moblocation[i, 2])))
                {
                    if (mob[i] == "Goblin")
                    {
                        MessageBox.Show("GOBLIN HEHE");
                        return 1;
                    }
                    else if (mob[i] == "Teleport")
                    {
                        return 2;
                    }
                    break;
                }

                else if (newPosition[2] >= moblocation[i, 0] - 5 && newPosition[2] <= moblocation[i, 2] + 5 &&
                   ((newPosition[1] > moblocation[i, 1] && newPosition[3] < moblocation[i, 3]) ||
                   (newPosition[1] <= moblocation[i, 1] && newPosition[3] >= moblocation[i, 1]) ||
                   (newPosition[3] >= moblocation[i, 3] && newPosition[1] <= moblocation[i, 3])))
                {
                    if (mob[i] == "Goblin")
                    {
                        MessageBox.Show("GOBLIN HEHE");
                        return 1;
                    }
                    else if (mob[i] == "Teleport")
                    {
                        return 2;
                    }
                    break;
                }
            }
            return 0;
        }
    }
}
