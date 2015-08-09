using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using AnalyzeRectangles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AnalyzeRectangles.Tests
{
   
    [TestClass()]
    public class AnalyzerTests
    {

#region TestData

        //
        // Multidimensional array containing pairs of rectangles
        // Each row contains two rectangles in the form of 
        // { X1 , Y1 , Width1 , Height1 , X2 , Y2 , Width2 , Height2 }
        //

        int[,] ContainingRectangles = { { 2, 3, 4, 6, 3, 4, 2, 3 },
                                        { 9, 4, 6, 4, 9, 5, 4, 3 },
                                        { 2, 3, 4, 6, 2, 3, 4, 6 } };

        int[,] NonContainingRectangles = { {15, 20, 30, 15, 55, 5, 25, 32 },
                                        { 0, 0, 0, 0, 0, 0, 0, 0 },
                                        { 2, 3, 4, 6, 2, 4, 5, 7 } };

        int[,] AdjacentRectangles = { { 1, 2, 3, 4, 4, 3, 2, 3 },
                                      { 1, 2, 6, 5, 2, 7, 4, 2 },
                                      { 1, 2, 2, 2, 3, 2, 7, 8 },
                                      { 2, 3, 4, 6, 2, 3, 4, 6 }};

        int[,] NonAdjacentRectangles = { { 15, 20, 20, 10, 20, 20, 20, 20 },
                                         { 15, 20, 20, 10, 10, 20, 10, 20 },
                                         { 0, 0, 0, 0, 0, 0, 0, 0 } };

        int[,] NonIntersectingRectangles = {{ 15, 20, 30, 15, 55, 5, 25, 32 },
                                            { 0, 0, 0, 0, 0, 0, 0, 0 }};

        int[,] IntersectingRectangles = {{ 7, 4, 7, 9, 10, 8, 8, 8 },
                                         { 2, 3, 2, 6, 1, 5, 2, 3 },
                                         { 10, 4, 6, 4, 13, 4, 3, 8 },
                                         { 4, 2, 4, 8, 2, 4, 8, 4 }};

        // Multidimensional array containing the intersection points of the
        // intersecting rectangles in the form of {X1, Y1, X2, Y2, ....}

        int[][] IntersectingPoints = new int[][] { new int[] { 14, 8, 10, 13 },
                                                   new int[] { 2, 5 , 2, 8 },
                                                   new int[] { 13, 8 },
                                                   new int[] { 4, 4, 4, 8, 8, 4, 8, 8 }};
#endregion

        [TestMethod()]
        public void CheckIntersectionTrueTest()
        {
            Debug.WriteLine("CheckIntersectionTrueTest Start");
            for (int i = 0; i < IntersectingRectangles.GetLength(0); i += 1)
            {
                ArrayList arrayIntersectingPoints;
                Rect testRect1 = new Rect(IntersectingRectangles[i, 0], IntersectingRectangles[i, 1], IntersectingRectangles[i, 2], IntersectingRectangles[i, 3]);
                Rect testRect2 = new Rect(IntersectingRectangles[i, 4], IntersectingRectangles[i, 5], IntersectingRectangles[i, 6], IntersectingRectangles[i, 7]);
                Assert.IsTrue(AnalyzeRectangles.Analyzer.CheckIntersection(testRect1, testRect2, out arrayIntersectingPoints));
                Debug.WriteLine(" Intersect True Pass ", i.ToString());
                int[] arrayReferenseIntersectingPoints = IntersectingPoints[i];
                Assert.AreEqual(arrayIntersectingPoints.Count, arrayReferenseIntersectingPoints.GetLength(0) / 2);

                foreach (Point intersectionPoint in arrayIntersectingPoints)
                {
                    bool found = false;
                    // Check if all the intersection points match with test reference array
                    for(int index = 0; index < arrayReferenseIntersectingPoints.GetLength(0); index+=2)
                    {
                        if(intersectionPoint.X == arrayReferenseIntersectingPoints[index] && 
                           intersectionPoint.Y == arrayReferenseIntersectingPoints[index+1])
                        {
                            found = true;
                            Debug.Write(intersectionPoint.X.ToString(), " x ");
                            Debug.WriteLine(intersectionPoint.Y.ToString(), " y ");
                
                            break;
                        }
                    }
                    if (!found)
                    {
                        Debug.WriteLine("Wrong intersection point returned");
                        Debug.Write(intersectionPoint.X.ToString(), " x ");
                        Debug.WriteLine(intersectionPoint.Y.ToString(), " y ");
                        Assert.Fail();
                    }
                }

            }
            Debug.WriteLine("CheckIntersectionTrueTest End");
        }

        [TestMethod()]
        public void CheckIntersectionFalseTest()
        {
            Debug.WriteLine("CheckIntersectionFalseTest Start");
            for (int i = 0; i < NonIntersectingRectangles.GetLength(0); i += 1)
            {
                ArrayList arrayIntersectingPoints;
                Rect testRect1 = new Rect(NonIntersectingRectangles[i, 0], NonIntersectingRectangles[i, 1], NonIntersectingRectangles[i, 2], NonIntersectingRectangles[i, 3]);
                Rect testRect2 = new Rect(NonIntersectingRectangles[i, 4], NonIntersectingRectangles[i, 5], NonIntersectingRectangles[i, 6], NonIntersectingRectangles[i, 7]);
                Assert.IsFalse(AnalyzeRectangles.Analyzer.CheckIntersection(testRect1, testRect2, out arrayIntersectingPoints));
                Debug.WriteLine(" Pass ", i.ToString());
            }

            Debug.WriteLine("Test containing rectangles for intersection");
            for (int i = 0; i < ContainingRectangles.GetLength(0); i += 1)
            {
                ArrayList arrayIntersectingPoints;
                Rect testRect1 = new Rect(ContainingRectangles[i, 0], ContainingRectangles[i, 1], ContainingRectangles[i, 2], ContainingRectangles[i, 3]);
                Rect testRect2 = new Rect(ContainingRectangles[i, 4], ContainingRectangles[i, 5], ContainingRectangles[i, 6], ContainingRectangles[i, 7]);
                Assert.IsFalse(AnalyzeRectangles.Analyzer.CheckIntersection(testRect1, testRect2, out arrayIntersectingPoints));
                Debug.WriteLine(" Pass ", i.ToString());
            }
        }

        [TestMethod()]
        public void CheckContainmentTrueTest()
        {
            Debug.WriteLine("CheckContainmentTrueTest Start");
            for (int i = 0; i < ContainingRectangles.GetLength(0); i += 1)
            {
                Rect testRect1 = new Rect(ContainingRectangles[i, 0], ContainingRectangles[i, 1], ContainingRectangles[i, 2], ContainingRectangles[i, 3]);
                Rect testRect2 = new Rect(ContainingRectangles[i, 4], ContainingRectangles[i, 5], ContainingRectangles[i, 6], ContainingRectangles[i, 7]);
                Assert.IsTrue(AnalyzeRectangles.Analyzer.CheckContainment(testRect1, testRect2));
            }
            Debug.WriteLine("CheckContainmentTrueTest End");
        }

        [TestMethod()]
        public void CheckContainmentFalseTest()
        {
            Debug.WriteLine("CheckContainmentFalseTest Start");
            for (int i = 0; i < NonContainingRectangles.GetLength(0); i += 1)
            {
                Rect testRect1 = new Rect(NonContainingRectangles[i, 0], NonContainingRectangles[i, 1], NonContainingRectangles[i, 2], NonContainingRectangles[i, 3]);
                Rect testRect2 = new Rect(NonContainingRectangles[i, 4], NonContainingRectangles[i, 5], NonContainingRectangles[i, 6], NonContainingRectangles[i, 7]);
                Assert.IsFalse(AnalyzeRectangles.Analyzer.CheckContainment(testRect1, testRect2));
                Debug.WriteLine(" Pass ", i.ToString());
            }

            Debug.WriteLine("Test intersecting rectangles for containment");
            for (int i = 0; i < IntersectingRectangles.GetLength(0); i += 1)
            {
                Rect testRect1 = new Rect(IntersectingRectangles[i, 0], IntersectingRectangles[i, 1], IntersectingRectangles[i, 2], IntersectingRectangles[i, 3]);
                Rect testRect2 = new Rect(IntersectingRectangles[i, 4], IntersectingRectangles[i, 5], IntersectingRectangles[i, 6], IntersectingRectangles[i, 7]);
                Assert.IsFalse(AnalyzeRectangles.Analyzer.CheckContainment(testRect1, testRect2));
                Debug.WriteLine(" Pass ", i.ToString());
            }
            
            Debug.WriteLine("CheckContainmentFalseTest End");
        }

        [TestMethod()]
        public void CheckAdjacentTrueTest()
        {
            Debug.WriteLine("CheckAdjacentTrueTest Start");
            for (int i = 0; i < AdjacentRectangles.GetLength(0); i += 1)
            {
                Rect testRect1 = new Rect(AdjacentRectangles[i, 0], AdjacentRectangles[i, 1], AdjacentRectangles[i, 2], AdjacentRectangles[i, 3]);
                Rect testRect2 = new Rect(AdjacentRectangles[i, 4], AdjacentRectangles[i, 5], AdjacentRectangles[i, 6], AdjacentRectangles[i, 7]);
                Assert.IsTrue(AnalyzeRectangles.Analyzer.CheckAdjacent(testRect1, testRect2));
                Console.WriteLine("CheckAdjacent Pass #", i );
            }
            Debug.WriteLine("CheckAdjacentTrueTest End");
        }

        [TestMethod()]
        public void CheckAdjacentFalseTest()
        {
            Debug.WriteLine("CheckAdjacentFalseTest Start");
            Debug.WriteLine("Test intersecting rectangles");
            for (int i = 0; i < NonAdjacentRectangles.GetLength(0); i += 1)
            {
                Rect testRect1 = new Rect(NonAdjacentRectangles[i, 0], NonAdjacentRectangles[i, 1], NonAdjacentRectangles[i, 2], NonAdjacentRectangles[i, 3]);
                Rect testRect2 = new Rect(NonAdjacentRectangles[i, 4], NonAdjacentRectangles[i, 5], NonAdjacentRectangles[i, 6], NonAdjacentRectangles[i, 7]);
                Assert.IsFalse(AnalyzeRectangles.Analyzer.CheckContainment(testRect1, testRect2));
                Debug.WriteLine(" Pass ", i.ToString());
            }
          
            Debug.WriteLine("CheckAdjacentFalseTest End");
        }

    }
}
