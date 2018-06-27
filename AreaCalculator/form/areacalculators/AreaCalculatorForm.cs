using System.Windows.Forms;

namespace AreaCalculator
{
   public abstract class AreaCalculatorForm:Form
    {
        public AreaCalculatorForm() : base() { 
        }

        public abstract double CalculateArea();
    }
}