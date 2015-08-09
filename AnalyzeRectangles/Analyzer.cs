using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AnalyzeRectangles
{
    public struct Rect
    {
        private int x, y, width, height;

        public Rect(int p1, int p2, int _width, int _height)
        {
            x = p1;
            y = p2;
            width = _width;
            height = _height;
        }
        public int Left
        {
            get
            {
                return x;
            }
        }

        public int Right
        {
            get
            {
                return x + width;
            }
        }

        public int Top
        {
            get
            {
                return y + height;
            }
        }

        public int Bottom
        {
            get
            {
                return y;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }
    }

    public struct Point
    {
        private int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        override public string ToString()
        {
            return String.Format(" ({0},{1})", x, y);
        }
    }
    public class Analyzer
    {
                
        /// <summary>
        /// Checks whether two rectangles intersect by finding out the intersection points.
        /// </summary>
        /// <param name="rectangleA"></param>
        /// <param name="rectangleB"></param>
        /// <returns>True if rectangles intersect else false</returns>
        public static bool CheckIntersection(Rect rectangleA, Rect rectangleB, out ArrayList InterSectingPoints)
        {
            InterSectingPoints = new ArrayList();
            if (!ValidateRectangle(rectangleA) || !ValidateRectangle(rectangleB))
            {
                return false;
            }
            if (rectangleA.Left > rectangleB.Left && rectangleA.Left < rectangleB.Right)
            {
                // Left side of rectangle A lies in between rectangle B edges. 
                // Check if it intersects
                if (rectangleB.Top < rectangleA.Top && rectangleB.Top > rectangleA.Bottom)
                {
                    Point pointIntersection = new Point(rectangleA.Left, rectangleB.Top);
                    InterSectingPoints.Add(pointIntersection);
                }
                if (rectangleB.Bottom < rectangleA.Top && rectangleB.Bottom > rectangleA.Bottom)
                {
                    Point pointIntersection = new Point(rectangleA.Left, rectangleB.Bottom);
                    InterSectingPoints.Add(pointIntersection);
                }
            }

            if (rectangleA.Right > rectangleB.Left && rectangleA.Right < rectangleB.Right)
            {
                // Right side of rectangle A lies in between rectangle B edges. 
                // Check if it intersects
                if (rectangleB.Top < rectangleA.Top && rectangleB.Top > rectangleA.Bottom)
                {
                    Point pointIntersection = new Point(rectangleA.Right, rectangleB.Top);
                    InterSectingPoints.Add(pointIntersection);
                }
                if (rectangleB.Bottom < rectangleA.Top && rectangleB.Bottom > rectangleA.Bottom)
                {
                    Point pointIntersection = new Point(rectangleA.Right, rectangleB.Bottom);
                    InterSectingPoints.Add(pointIntersection);
                }
            }

            if (rectangleA.Top > rectangleB.Bottom && rectangleA.Top < rectangleB.Top)
            {
                // Top side of rectangle A lies in between rectangle B Top and Bottom. 
                // Check if it intersects
                if (rectangleB.Left < rectangleA.Right && rectangleB.Left > rectangleA.Left)
                {
                    Point pointIntersection = new Point(rectangleB.Left, rectangleA.Top);
                    InterSectingPoints.Add(pointIntersection);
                }
                if (rectangleB.Right < rectangleA.Right && rectangleB.Right > rectangleA.Left)
                {
                    Point pointIntersection = new Point(rectangleB.Right, rectangleA.Top);
                    InterSectingPoints.Add(pointIntersection);
                }
            }

            if (rectangleA.Bottom > rectangleB.Bottom && rectangleA.Bottom < rectangleB.Top)
            {
                // Top side of rectangle A lies in between rectangle B Top and Bottom. 
                // Check if it intersects
                if (rectangleB.Left < rectangleA.Right && rectangleB.Left > rectangleA.Left)
                {
                    Point pointIntersection = new Point(rectangleB.Left, rectangleA.Bottom);
                    InterSectingPoints.Add(pointIntersection);
                }
                if (rectangleB.Right < rectangleA.Right && rectangleB.Right > rectangleA.Left)
                {
                    Point pointIntersection = new Point(rectangleB.Right, rectangleA.Bottom);
                    InterSectingPoints.Add(pointIntersection);
                }
            }
            return (InterSectingPoints.Count > 0);
        }

        /// <summary>
        /// Checks for containment relationship between two rectangles.
        /// </summary>
        /// <param name="rectangleA"></param>
        /// <param name="rectangleB"></param>
        /// <returns> Returns true if RectangleA entirely contains RectangleB or 
        /// if RectangleB entirely contains RectangleA</returns>
        public static bool CheckContainment(Rect rectangleA, Rect rectangleB)
        {
            if (!ValidateRectangle(rectangleA) || !ValidateRectangle(rectangleB))
            {
                return false;
            }
            bool outside = false;
            // look for an edge in the (potentially) smaller rectangle outside the bigger rectangle
            if (rectangleA.Width > rectangleB.Width)
            {
                outside = ((rectangleB.Left < rectangleA.Left) ||
                           (rectangleB.Right > rectangleA.Right) ||
                           (rectangleB.Top > rectangleA.Top) ||
                           (rectangleB.Bottom < rectangleA.Bottom));
            }
            else 
            {
                outside = ((rectangleA.Left < rectangleB.Left) ||
                           (rectangleA.Right > rectangleB.Right) ||
                           (rectangleA.Top > rectangleB.Top) ||
                           (rectangleA.Bottom < rectangleB.Bottom));
            }
            return !outside;
        }

        /// <summary>
        /// Checks if two rectangles have adjacent edges
        /// </summary>
        /// <param name="rectangleA"></param>
        /// <param name="rectangleB"></param>
        /// <returns>True if there is adjacency</returns>
        public static bool CheckAdjacent(Rect rectangleA, Rect rectangleB)
        {
            if(!ValidateRectangle(rectangleA) || !ValidateRectangle(rectangleB))
            {
                return false;
            }
            bool adjacent = false;
            if (rectangleA.Left == rectangleB.Right || 
                rectangleA.Right == rectangleB.Left ||
                rectangleA.Left == rectangleB.Left ||
                rectangleA.Right == rectangleB.Right)
            {
                // Now that we have a common side check if it is proper or sub-line
                if (rectangleA.Top >= rectangleB.Top)
                {
                    adjacent = (rectangleB.Bottom >= rectangleA.Bottom);
                }
                if (!adjacent && rectangleB.Top >= rectangleA.Top)
                {
                    adjacent = (rectangleA.Bottom >= rectangleB.Bottom);
                }
            }
            if (rectangleA.Top == rectangleB.Bottom ||
                rectangleA.Bottom == rectangleB.Top ||
                rectangleA.Top == rectangleB.Top ||
                rectangleA.Bottom == rectangleB.Bottom)
            {
                if (rectangleA.Right >= rectangleB.Right)
                {
                    adjacent = (rectangleB.Left >= rectangleA.Left);
                }
                if (!adjacent && rectangleB.Right >= rectangleA.Right)
                {
                    adjacent = (rectangleA.Left >= rectangleB.Left);
                }
            }
            return adjacent;
        }

        private static bool ValidateRectangle (Rect rectangleA)
        {
            if(rectangleA.Width < 1 || rectangleA.Height < 1)
            {
                return false;
            }
            return true;
        }
    }
}
