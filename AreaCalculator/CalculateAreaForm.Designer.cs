namespace AreaCalculator
{
    partial class CalculateAreaForm
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
            this.SelectShapeLabel = new System.Windows.Forms.Label();
            this.ShapeDropdown = new System.Windows.Forms.ComboBox();
            this.CalculateAreaButton = new System.Windows.Forms.Button();
            this.SelectShapeErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectShapeLabel
            // 
            this.SelectShapeLabel.AutoSize = true;
            this.SelectShapeLabel.Location = new System.Drawing.Point(13, 31);
            this.SelectShapeLabel.Name = "SelectShapeLabel";
            this.SelectShapeLabel.Size = new System.Drawing.Size(78, 13);
            this.SelectShapeLabel.TabIndex = 0;
            this.SelectShapeLabel.Text = "Select a shape";
            // 
            // ShapeDropdown
            // 
            this.ShapeDropdown.FormattingEnabled = true;
            this.ShapeDropdown.Items.AddRange(new object[] {
            "Circle",
            "Rectangle"});
            this.ShapeDropdown.Location = new System.Drawing.Point(98, 31);
            this.ShapeDropdown.Name = "ShapeDropdown";
            this.ShapeDropdown.Size = new System.Drawing.Size(121, 21);
            this.ShapeDropdown.TabIndex = 1;
            // 
            // CalculateAreaButton
            // 
            this.CalculateAreaButton.Location = new System.Drawing.Point(246, 29);
            this.CalculateAreaButton.Name = "CalculateAreaButton";
            this.CalculateAreaButton.Size = new System.Drawing.Size(94, 23);
            this.CalculateAreaButton.TabIndex = 2;
            this.CalculateAreaButton.Text = "Calculate Area";
            this.CalculateAreaButton.UseVisualStyleBackColor = true;
            this.CalculateAreaButton.Click += new System.EventHandler(this.CalculateAreaButton_Click);
            // 
            // SelectShapeErrorLabel
            // 
            this.SelectShapeErrorLabel.AutoSize = true;
            this.SelectShapeErrorLabel.Location = new System.Drawing.Point(16, 65);
            this.SelectShapeErrorLabel.Name = "SelectShapeErrorLabel";
            this.SelectShapeErrorLabel.Size = new System.Drawing.Size(211, 13);
            this.SelectShapeErrorLabel.TabIndex = 3;
            this.SelectShapeErrorLabel.Text = "Please select a shape from the drop down!!";
            this.SelectShapeErrorLabel.Visible = false;
            // 
            // CalculateAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 109);
            this.Controls.Add(this.SelectShapeErrorLabel);
            this.Controls.Add(this.CalculateAreaButton);
            this.Controls.Add(this.ShapeDropdown);
            this.Controls.Add(this.SelectShapeLabel);
            this.Name = "CalculateAreaForm";
            this.Text = "CalculateAreaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectShapeLabel;
        private System.Windows.Forms.ComboBox ShapeDropdown;
        private System.Windows.Forms.Button CalculateAreaButton;
        private System.Windows.Forms.Label SelectShapeErrorLabel;
    }
}