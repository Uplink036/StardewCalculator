using System.Collections;

namespace StardewCalculator.Components.Classes
{
    public class SimpleCalculator
    {
        public float lhs;
        public float rhs;
        public char op;
        public SimpleCalculator() {
            lhs = 0;
            rhs = 0;
            op = '=';
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
                case '=':
                    lhs = rhs;
                    break;
                default:
                    throw new InvalidOperationException();
            }
            rhs = 0;
            return lhs;
        }

        public void setOp(char op)
        {
            if (lhs == 0)
            {
                lhs = rhs;
                rhs = 0;
            }
            this.op = op; 
        }

        public void add(float input)
        {

            rhs = rhs * 10 + input; // Add the input to the number
        }

        public void clear()
        {
            lhs = 0;
        }
    }
}
