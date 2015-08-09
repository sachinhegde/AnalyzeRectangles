using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AnalyzeRectangles
{
    public partial class EntryForm : Form
    {

#region Form Events

        public EntryForm()
        {
            InitializeComponent();
        }
              

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void panelDrawArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics panelGraphics = panelDrawArea.CreateGraphics();
            SolidBrush brushBlack = new SolidBrush(Color.Black);
            Pen penBlack = new Pen(brushBlack, 1);
            // Create array of points that define lines to draw.
            System.Drawing.Point[] points = { new System.Drawing.Point(400, 10),
                                              new System.Drawing.Point(10, 10),
                                              new System.Drawing.Point(10, 400)};
            panelGraphics.DrawLines(penBlack, points);
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            x1 = GetNumber(textBoxX1.Text, sender);
            DrawRectangles();
        }

        private void textBoxY1_TextChanged(object sender, EventArgs e)
        {
            y1 = GetNumber(textBoxY1.Text, sender);
            DrawRectangles();
        }

        private void textBoxWidth1_TextChanged(object sender, EventArgs e)
        {
            width1 = GetNumber(textBoxWidth1.Text, sender);
            DrawRectangles();
        }

        private void textBoxHeight1_TextChanged(object sender, EventArgs e)
        {
            height1 = GetNumber(textBoxHeight1.Text, sender);
            DrawRectangles();
        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {
            x2 = GetNumber(textBoxX2.Text, sender);
            DrawRectangles();
        }

        private void textBoxY2_TextChanged(object sender, EventArgs e)
        {
            y2 = GetNumber(textBoxY2.Text, sender);
            DrawRectangles();
        }

        private void textBoxWidth2_TextChanged(object sender, EventArgs e)
        {
            width2 = GetNumber(textBoxWidth2.Text, sender);
            DrawRectangles();
        }

        private void textBoxHeight2_TextChanged(object sender, EventArgs e)
        {
            height2 = GetNumber(textBoxHeight2.Text, sender);
            DrawRectangles();
        }

#endregion

#region Helper Methods
        private int GetNumber(string strText, object sender)
        {
            int number = 0;
            try
            {
                if (strText.Length > 0)
                {
                    number = Int32.Parse(strText);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
                ((TextBox)sender).Text = "";

            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a valid number");
                ((TextBox)sender).Text = "";
            }
            return number;
        }

        private bool ValidateRectangleA()
        {
            if (x1 > 0 && y1 > 0 && width1 > 0 && height1 > 0)
            {
                return true;
            }
            return false;
        }

        private bool ValidateRectangleB()
        {
            if (x2 > 0 && y2 > 0 && width2 > 0 && height2 > 0)
            {
                return true;
            }
            return false;
        }

        void CalculateScale()
        {
            int maxX = Math.Max(x1 + width1, x2 + width2);
            int maxY = Math.Max(y1 + height1, y2 + height2);
            float maxLength = Math.Max(maxX, maxY);
            scale = (panelDrawArea.Size.Width - 100) / maxLength;
        
        }

        void DrawRectangles()
        {
            Graphics panelGraphics = panelDrawArea.CreateGraphics();
            panelGraphics.Clear(Color.White);

            SolidBrush brushBlack = new SolidBrush(Color.Black);
            Pen penBlack = new Pen(brushBlack, 1);
            // Create array of points that define lines to draw.
            System.Drawing.Point[] points = { new System.Drawing.Point(400, 10),
                                              new System.Drawing.Point(10, 10),
                                              new System.Drawing.Point(10, 400)};
            panelGraphics.DrawLines(penBlack, points);


            if (ValidateRectangleA() || ValidateRectangleB())
            {
                CalculateScale();
                labelXExtent.Text = ((int)(panelDrawArea.Size.Width / scale)).ToString();
                labelYExtent.Text = labelXExtent.Text;
            }

            if (ValidateRectangleA())
            {
                SolidBrush brushRed = new SolidBrush(Color.Red);
                Pen penRed = new Pen(brushRed, 2);
                // Offsetting by 10 since we drew the x,y axis at 10
                int offsetX1 = (int)(x1 * scale) + 10;
                int offsetY1 = (int)(y1 * scale) + 10;
                int scaledWitdh1 = (int)(width1 * scale);
                int scaledHeight1 = (int)(height1 * scale);
                panelGraphics.DrawRectangle(penRed, new Rectangle(offsetX1, offsetY1, scaledWitdh1, scaledHeight1));
                brushRed.Dispose();
                penRed.Dispose();
            }

            if (ValidateRectangleB())
            {
                SolidBrush brushBlue = new SolidBrush(Color.Blue);
                Pen penBlue = new Pen(brushBlue, 2);
                // Offsetting by 10 since we drew the x,y axis at 10
                int offsetX2 = (int)(x2 * scale) + 10;
                int offsetY2 = (int)(y2 * scale) + 10;
                int scaledWitdh2 = (int)(width2 * scale);
                int scaledHeight2 = (int)(height2 * scale);
                panelGraphics.DrawRectangle(penBlue, new Rectangle(offsetX2, offsetY2, scaledWitdh2, scaledHeight2));
                penBlue.Dispose();
                brushBlue.Dispose();
            }

            panelGraphics.Dispose();

            labelResult.Text = "";
            labelIntersectionPoints.Text = "";

            if (ValidateRectangleA() && ValidateRectangleB())
            {
                AnalyzeRectangles();
            }
        }

        private void AnalyzeRectangles()
        {
            
            if (ValidateRectangleA() && ValidateRectangleB())
            {

                AnalyzeRectangles.Rect rectangleA = new AnalyzeRectangles.Rect(x1, y1, width1, height1);
                AnalyzeRectangles.Rect rectangleB = new AnalyzeRectangles.Rect(x2, y2, width2, height2);

                ArrayList arrayIntersectionPoints;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                if (Analyzer.CheckIntersection(rectangleA, rectangleB, out arrayIntersectionPoints))
                {
                    sb.AppendFormat("Intersecting rectangles {0} intersecting points found - ", arrayIntersectionPoints.Count);
                    foreach (Point point in arrayIntersectionPoints)
                    {
                        sb.Append(point.ToString());
                    }
                    sb.AppendLine("");
                }
                if (Analyzer.CheckContainment(rectangleA, rectangleB))
                {
                    sb.AppendLine("Containing rectangles");
                }
                if (Analyzer.CheckAdjacent(rectangleA, rectangleB))
                {
                    sb.AppendLine("Adjacent rectangles");
                }

                if (sb.ToString().Length > 0)
                {
                    labelResult.Text = sb.ToString();
                }
                else
                {
                    labelResult.Text = "No relations";
                }
            }
            else
            {
                MessageBox.Show("Please enter all values with postive integers");
            }
        }

#endregion


#region Member Variables

        private int x1, y1, width1, height1, x2, y2, width2, height2 ;
        private float scale;

#endregion

    }
}
