namespace AnalyzeRectangles
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxWidth1 = new System.Windows.Forms.TextBox();
            this.textBoxHeight1 = new System.Windows.Forms.TextBox();
            this.textBoxHeight2 = new System.Windows.Forms.TextBox();
            this.textBoxWidth2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelDrawArea = new System.Windows.Forms.Panel();
            this.labelYExtent = new System.Windows.Forms.Label();
            this.labelXExtent = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelIntersectionPoints = new System.Windows.Forms.Label();
            this.panelDrawArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rectangle A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(92, 75);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(77, 20);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(92, 101);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(77, 20);
            this.textBoxY1.TabIndex = 2;
            this.textBoxY1.TextChanged += new System.EventHandler(this.textBoxY1_TextChanged);
            // 
            // textBoxWidth1
            // 
            this.textBoxWidth1.Location = new System.Drawing.Point(92, 127);
            this.textBoxWidth1.Name = "textBoxWidth1";
            this.textBoxWidth1.Size = new System.Drawing.Size(77, 20);
            this.textBoxWidth1.TabIndex = 3;
            this.textBoxWidth1.TextChanged += new System.EventHandler(this.textBoxWidth1_TextChanged);
            // 
            // textBoxHeight1
            // 
            this.textBoxHeight1.Location = new System.Drawing.Point(92, 153);
            this.textBoxHeight1.Name = "textBoxHeight1";
            this.textBoxHeight1.Size = new System.Drawing.Size(77, 20);
            this.textBoxHeight1.TabIndex = 4;
            this.textBoxHeight1.TextChanged += new System.EventHandler(this.textBoxHeight1_TextChanged);
            // 
            // textBoxHeight2
            // 
            this.textBoxHeight2.Location = new System.Drawing.Point(92, 375);
            this.textBoxHeight2.Name = "textBoxHeight2";
            this.textBoxHeight2.Size = new System.Drawing.Size(77, 20);
            this.textBoxHeight2.TabIndex = 8;
            this.textBoxHeight2.TextChanged += new System.EventHandler(this.textBoxHeight2_TextChanged);
            // 
            // textBoxWidth2
            // 
            this.textBoxWidth2.Location = new System.Drawing.Point(92, 349);
            this.textBoxWidth2.Name = "textBoxWidth2";
            this.textBoxWidth2.Size = new System.Drawing.Size(77, 20);
            this.textBoxWidth2.TabIndex = 7;
            this.textBoxWidth2.TextChanged += new System.EventHandler(this.textBoxWidth2_TextChanged);
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(92, 323);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(77, 20);
            this.textBoxY2.TabIndex = 6;
            this.textBoxY2.TextChanged += new System.EventHandler(this.textBoxY2_TextChanged);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(92, 297);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(77, 20);
            this.textBoxX2.TabIndex = 5;
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Height";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(12, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rectangle B";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(13, 452);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 17);
            this.labelResult.TabIndex = 19;
            // 
            // panelDrawArea
            // 
            this.panelDrawArea.BackColor = System.Drawing.Color.White;
            this.panelDrawArea.Controls.Add(this.labelYExtent);
            this.panelDrawArea.Controls.Add(this.labelXExtent);
            this.panelDrawArea.Controls.Add(this.labelOrigin);
            this.panelDrawArea.Location = new System.Drawing.Point(210, 41);
            this.panelDrawArea.Name = "panelDrawArea";
            this.panelDrawArea.Size = new System.Drawing.Size(410, 410);
            this.panelDrawArea.TabIndex = 9;
            this.panelDrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawArea_Paint);
            // 
            // labelYExtent
            // 
            this.labelYExtent.AutoSize = true;
            this.labelYExtent.Location = new System.Drawing.Point(-3, 397);
            this.labelYExtent.Name = "labelYExtent";
            this.labelYExtent.Size = new System.Drawing.Size(25, 13);
            this.labelYExtent.TabIndex = 2;
            this.labelYExtent.Text = "400";
            // 
            // labelXExtent
            // 
            this.labelXExtent.AutoSize = true;
            this.labelXExtent.Location = new System.Drawing.Point(382, 0);
            this.labelXExtent.Name = "labelXExtent";
            this.labelXExtent.Size = new System.Drawing.Size(25, 13);
            this.labelXExtent.TabIndex = 1;
            this.labelXExtent.Text = "400";
            this.labelXExtent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(-3, 0);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(22, 13);
            this.labelOrigin.TabIndex = 0;
            this.labelOrigin.Text = "0,0";
            // 
            // labelIntersectionPoints
            // 
            this.labelIntersectionPoints.AutoSize = true;
            this.labelIntersectionPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntersectionPoints.Location = new System.Drawing.Point(12, 478);
            this.labelIntersectionPoints.Name = "labelIntersectionPoints";
            this.labelIntersectionPoints.Size = new System.Drawing.Size(0, 17);
            this.labelIntersectionPoints.TabIndex = 21;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 515);
            this.Controls.Add(this.labelIntersectionPoints);
            this.Controls.Add(this.panelDrawArea);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxHeight2);
            this.Controls.Add(this.textBoxWidth2);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxHeight1);
            this.Controls.Add(this.textBoxWidth1);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(655, 554);
            this.MinimumSize = new System.Drawing.Size(655, 554);
            this.Name = "EntryForm";
            this.Text = "Rectangle Analyzer";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.panelDrawArea.ResumeLayout(false);
            this.panelDrawArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxWidth1;
        private System.Windows.Forms.TextBox textBoxHeight1;
        private System.Windows.Forms.TextBox textBoxHeight2;
        private System.Windows.Forms.TextBox textBoxWidth2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Panel panelDrawArea;
        private System.Windows.Forms.Label labelIntersectionPoints;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelYExtent;
        private System.Windows.Forms.Label labelXExtent;
    }
}

