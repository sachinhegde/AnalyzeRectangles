# AnalyzeRectangles
A Windows C# application which compares two rectangles for Intersection, Containment, Adjacency relationship

The solution contains two projects "AnalyzeRectangle" and "AnalyzeRectangleTest"

AnalyzeRectangles - 
  This is a C# windows forms application. On running this project it creates a "AnalyzeRectangle.exe" program which presents a UI for the user to add two rectangles (X, Y, Width, Height). Once the user enters this information it draws the two rectangles and states the relation between them. Relations are defined in the appendix below.
  Key files in this project-
  1)Analyzer.cs - This class file implements the main logic for analyzing the two rectangles.
  2)EntryForm.cs - This file contains the UI logic for getting user input and drawing the rectangles.
  
AnalyzeRectanglesTest
  This is the unit test project for the solution. The main file in this project is-
  1) AnalyzerTests.cs - This file contains the unit tests for the Analyze rectangle methods
  
  
  Appendix
1.	Intersection: 
You must be able to determine whether two rectangles have one or more intersecting lines and produce a result identifying the points of intersection. Two rectangles are defined to have intersecting lines if any side of one rectangle cuts (not just touches) any side of the other rectangle.
 
2.	Containment: 
You must be able to determine whether a rectangle is wholly contained within another rectangle. Sides of the two rectangles can overlap.
 
3.	Adjacency:
Implement the ability to detect whether two rectangles are adjacent. Adjacency is defined as the sharing of a side. Side sharing may be proper or sub-line, where a sub-line share is one where one side of rectangle A is a line that exists as a set of points wholly contained on some other side of rectangle B.
Contained and Adjacency are not mutually exclusive.
 

