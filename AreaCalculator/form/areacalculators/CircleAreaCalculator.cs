using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AreaCalculator
{
    class CircleAreaCalculator:AreaCalculatorForm
    {
        private System.Windows.Forms.TextBox RadiusTextbox;
        private System.Windows.Forms.Button CalculateCircleAreaButton;
        private System.Windows.Forms.Label CircleAreaLabel;
        private System.Windows.Forms.Label RadiusLabel;

        public CircleAreaCalculator():base()
        {   
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextbox = new System.Windows.Forms.TextBox();
            this.CalculateCircleAreaButton = new System.Windows.Forms.Button();
            this.CircleAreaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(13, 24);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(142, 13);
            this.RadiusLabel.TabIndex = 0;
            this.RadiusLabel.Text = "Enter the radius of the circle:";
            // 
            // RadiusTextbox
            // 
            this.RadiusTextbox.Location = new System.Drawing.Point(162, 24);
            this.RadiusTextbox.Name = "RadiusTextbox";
            this.RadiusTextbox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextbox.TabIndex = 1;
            this.RadiusTextbox.MaxLength = 7;
            // 
            // CalculateCircleAreaButton
            // 
            this.CalculateCircleAreaButton.Location = new System.Drawing.Point(16, 56);
            this.CalculateCircleAreaButton.Name = "CalculateCircleAreaButton";
            this.CalculateCircleAreaButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateCircleAreaButton.TabIndex = 2;
            this.CalculateCircleAreaButton.Text = "Calculate Area of the circle";
            this.CalculateCircleAreaButton.UseVisualStyleBackColor = true;
            this.CalculateCircleAreaButton.Click += new System.EventHandler(this.CalculateCircleAreaButton_Click);
            // 
            // CircleAreaLabel
            // 
            this.CircleAreaLabel.AutoSize = true;
            this.CircleAreaLabel.Location = new System.Drawing.Point(16, 110);
            this.CircleAreaLabel.Name = "CircleAreaLabel";
            this.CircleAreaLabel.Size = new System.Drawing.Size(93, 13);
            this.CircleAreaLabel.TabIndex = 3;
            this.CircleAreaLabel.Text = "Area of the circle :";
            this.CircleAreaLabel.Visible = false;
            //
            // CircleAreaCalculator
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
           
            this.Controls.Add(this.CircleAreaLabel);
            this.Controls.Add(this.CalculateCircleAreaButton);
            this.Controls.Add(this.RadiusTextbox);
            this.Controls.Add(this.RadiusLabel);
            this.Name = "CircleAreaCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CalculateCircleAreaButton_Click(object sender, EventArgs e)
        {
            
            if (RadiusTextbox.Text.Length!=0)
            {
                try
                {
                   double area =CalculateArea();
                    CircleAreaLabel.Text = "Area of the Circle is " + Convert.ToString(area);
                }           
                catch (FormatException)
                {                  
                    CircleAreaLabel.Text = "Please enter a valid value";
                }           
                CircleAreaLabel.Visible = true;
            }
            else
            {
                CircleAreaLabel.Visible = true;
                CircleAreaLabel.Text ="Radius cannot be empty";
            }
        }

        public override double CalculateArea()
        {         
            double radius = Convert.ToDouble(RadiusTextbox.Text);
            return 3.14 * radius * radius;
        }
       
    }
}
