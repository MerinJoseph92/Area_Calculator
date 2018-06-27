using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class FormFactory
    {
        public AreaCalculatorForm GetAreaCalculatorForm(string shapeType)
        {
            AreaCalculatorForm areaCalculatorForm;
            switch (shapeType)
            {
                case "Circle":
                    areaCalculatorForm = new CircleAreaCalculator();
                    break;
                case "Rectangle":
                    areaCalculatorForm = new RecatangleAreaCalculator();
                    break;
                default:
                    throw new NotSupportedException();
            }
            return areaCalculatorForm;
        }
    }
}
