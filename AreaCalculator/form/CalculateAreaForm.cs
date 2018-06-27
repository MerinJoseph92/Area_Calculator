using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculator
{
    public partial class CalculateAreaForm : Form
    {
        private FormFactory formFactory;

        public CalculateAreaForm()
        {
            InitializeComponent();
            formFactory = new FormFactory();
        }

        private void CalculateAreaButton_Click(object sender, EventArgs e)
        {
            try
            {
                AreaCalculatorForm areaCalculatorForm = formFactory.GetAreaCalculatorForm(ShapeDropdown.Text);
                areaCalculatorForm.ShowDialog();
                SelectShapeErrorLabel.Visible = false;
            } catch (NotSupportedException) {
                SelectShapeErrorLabel.Visible = true;
            } 

        }
       
    }
}
