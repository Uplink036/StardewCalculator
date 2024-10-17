using System.Collections;

namespace StardewCalculator.Components.Classes
{
    public class SimpleCalculator
    {
        private float lhs, rhs;
        private char op;
        public SimpleCalculator() {
            lhs = 0;
            rhs = 0;
            op = '+';
        }

        public float calculate()
        {
            switch (op)
            {
                case '+':
                    lhs = lhs + rhs;
                    break;
                case '-':
                    lhs = lhs - rhs;
                    break;
                case '*':
                    lhs = lhs * rhs;
                    break;
                case '/':
                    lhs = lhs / rhs;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return lhs;
        }

        public void setOp(char op)
        { 
            this.op = op; 
        }

        public void add(float input)
        {
            rhs = rhs * 10 + input; // Add the input to the number
        }
    }
}
