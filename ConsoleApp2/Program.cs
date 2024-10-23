// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1
{
    class Operation
    {
        public double dDigit1;
        public double dDigit2;
        public double dDigit3;
        public String sOper;
        public void Operate()
        {
            if (sOper == "+")
                dDigit3 = dDigit1 + dDigit2;
            else if (sOper == "-")
                dDigit3 = dDigit1 - dDigit2;
            else if (sOper == "x")
                dDigit3 = dDigit1 * dDigit2;
            else if (sOper == "÷")
                dDigit3 = dDigit1 / dDigit2;
            else if (sOper == "나머지")
                dDigit3 = dDigit1 % dDigit2;
            else if (sOper == "제곱")
                dDigit3 = Math.Pow(dDigit1, dDigit2);

            Console.WriteLine(dDigit1 + "" + sOper + dDigit2 + "=" + dDigit3);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.dDigit1 = 25;
            operation.dDigit2 = 17;

            operation.sOper = "+";
            operation.Operate();

            operation.sOper = "-";
            operation.Operate();

            operation.sOper = "x";
            operation.Operate();

            operation.sOper = "÷";
            operation.Operate();

            operation.sOper = "나머지";
            operation.Operate();

            operation.sOper = "제곱";
            operation.Operate();

        }
    }
}