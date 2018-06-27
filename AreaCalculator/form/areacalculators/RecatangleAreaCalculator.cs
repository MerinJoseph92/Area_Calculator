using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class RecatangleAreaCalculator:AreaCalculatorForm
    {
        private System.Windows.Forms.TextBox lengthTextbox;
        private System.Windows.Forms.Label RectBreadthLabel;
        private System.Windows.Forms.TextBox breadthTextbox;
        private System.Windows.Forms.Button RectAreaButton;
        private System.Windows.Forms.Label AreaofRectArea;
        private System.Windows.Forms.Label RectLengthLabel;

        public RecatangleAreaCalculator():base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.RectLengthLabel = new System.Windows.Forms.Label();
            this.lengthTextbox = new System.Windows.Forms.TextBox();
            this.RectBreadthLabel = new System.Windows.Forms.Label();
            this.breadthTextbox = new System.Windows.Forms.TextBox();
            this.RectAreaButton = new System.Windows.Forms.Button();
            this.AreaofRectArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RectLengthLabel
            // 
            this.RectLengthLabel.AutoSize = true;
            this.RectLengthLabel.Location = new System.Drawing.Point(13, 25);
            this.RectLengthLabel.Name = "RectLengthLabel";
            this.RectLengthLabel.Size = new System.Drawing.Size(85, 13);
            this.RectLengthLabel.TabIndex = 0;
            this.RectLengthLabel.Text = "Enter the length:";
            // 
            // lengthTextbox
            // 
            this.lengthTextbox.Location = new System.Drawing.Point(105, 25);
            this.lengthTextbox.Name = "lengthTextbox";
            this.lengthTextbox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextbox.TabIndex = 1;
            this.lengthTextbox.MaxLength = 7;
            // 
            // RectBreadthLabel
            // 
            this.RectBreadthLabel.AutoSize = true;
            this.RectBreadthLabel.Location = new System.Drawing.Point(16, 57);
            this.RectBreadthLabel.Name = "RectBreadthLabel";
            this.RectBreadthLabel.Size = new System.Drawing.Size(92, 13);
            this.RectBreadthLabel.TabIndex = 2;
            this.RectBreadthLabel.Text = "Enter the breadth:";
            // 
            // breadthTextbox
            // 
            this.breadthTextbox.Location = new System.Drawing.Point(105, 57);
            this.breadthTextbox.Name = "breadthTextbox";
            this.breadthTextbox.Size = new System.Drawing.Size(100, 20);
            this.breadthTextbox.TabIndex = 3;
            this.breadthTextbox.MaxLength = 7;
            // 
            // RectAreaButton
            // 
            this.RectAreaButton.Location = new System.Drawing.Point(12, 92);
            this.RectAreaButton.Name = "RectAreaButton";
            this.RectAreaButton.Size = new System.Drawing.Size(75, 23);
            this.RectAreaButton.TabIndex = 4;
            this.RectAreaButton.Text = "Calculate Area";
            this.RectAreaButton.UseVisualStyleBackColor = true;
            this.RectAreaButton.Click += new System.EventHandler(this.RectAreaButton_Click);
            // 
            // AreaofRectArea
            // 
            this.AreaofRectArea.AutoSize = true;
            this.AreaofRectArea.Location = new System.Drawing.Point(13, 137);
            this.AreaofRectArea.Name = "AreaofRectArea";
            this.AreaofRectArea.Size = new System.Drawing.Size(124, 13);
            this.AreaofRectArea.TabIndex = 5;
            this.AreaofRectArea.Text = "Area of the Rectangle is ";
            this.AreaofRectArea.Visible = false;
            // 
            // RecatangleAreaCalculator
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AreaofRectArea);
            this.Controls.Add(this.RectAreaButton);
            this.Controls.Add(this.breadthTextbox);
            this.Controls.Add(this.RectBreadthLabel);
            this.Controls.Add(this.lengthTextbox);
            this.Controls.Add(this.RectLengthLabel);
            this.Name = "RecatangleAreaCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RectAreaButton_Click(object sender, EventArgs e)
        {

            if (breadthTextbox.Text.Length != 0 && lengthTextbox.Text.Length != 0)
            {
                try
                {
                    double area = CalculateArea();
                    AreaofRectArea.Text = "Area of the Rectangle is " + Convert.ToString(area);
                }
                catch (FormatException)
                {
                    AreaofRectArea.Text = "Please enter a valid value";
                }
                AreaofRectArea.Visible = true;
            }
            else
            {
                AreaofRectArea.Visible = true;
                AreaofRectArea.Text = "Length/Breadth cannot be empty";
            }
        }

        public override double CalculateArea()
        {
            double length = Convert.ToDouble(lengthTextbox.Text);
            double breadth = Convert.ToDouble(breadthTextbox.Text);
            return  length * breadth;
        }
        
    }
}
