using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp19
{
    internal class Program
    {
#pragma warning disable IDE0210 // Convert to top-level statements
        static void Main(string[] args)
        {
            string signal = "";
            double number1 = 0, number2 = 0, result = 0, a = 0, b = 0, c = 0;
            welcometouser("welcome to user in the calculator ");
            printmassege();
            bool bkey = true;
            while (bkey)
            {
                inputsignal(signal,  number1, number2 , a , b , c);
                welcometouser(" do you went to the exit = yes or the not exit = no");
                string sChoise = Console.ReadLine();
                if (sChoise == "yes")
                    bkey = false;
                Console.Clear();
                printmassege();
            }
        }
        static void welcometouser(string massege)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(massege);
            Console.WriteLine("---------------------------------------");
        }
        static void printmassege()
        {
            Console.WriteLine($"the sumation = +    *   the subtraction = -   *     the multiplication = * \n ******************************************************************************************* \n" +
            " the Division = /    *  the percent = %        *   the power = ^ \n *******************************************************************************************\n"+
            " the sqrt            *   the Ln                *     the dy/dx \n *******************************************************************************************\n" +
            " the eqn1            *   the eqn2              *      \n *******************************************************************************************\n" +
            " the sin             *   the cos               *     the tan \n********************************************************************************************\n" +
            " the cosec           *   the sec               *    the cot \n********************************************************************************************\n" +
            " the sin-1           *   the cos-1             *     the tan-1 \n********************************************************************************************\n" +
            " the sinh-1          *   the cosh-1            *     the tanh-1 \n********************************************************************************************\n" +
            " the sinh            *   the cosh              *    the tanh \n********************************************************************************************\n" +
            " the cosech          *   the sech              *     the coth \n********************************************************************************************\n" +
            " 1) Convert from decimal to octal \n********************************************************************************************\n" +
            " 2) Convert from decimal to Binary \n********************************************************************************************\n" +
            " 3) Convert from decimal to hexdecimal \n********************************************************************************************\n");

        }
        static void inputsignal(string signal , double number1 , double number2 , double a , double b , double c) 
        {
            Console.Write(" please enter the signal = ");
            signal = Console.ReadLine();
            if (signal == "+" || signal == "-" || signal == "/" || signal == "%" || signal == "*" || signal == "^")
            {
                if (signal == "+")
                    sum(number1, number2);
                else if (signal == "-")
                    subtraction(number1, number2);
                else if (signal == "*")
                    multiplication(number1, number2);
                else if (signal == "/")
                    Division(number1, number2);
                else if (signal == "%")
                    percent(number1, number2);
                else if (signal == "^")
                    power(number1, number2);
            }
            else if (signal == "sin" || signal == "cos" || signal == "tan" || signal == "sqrt" || signal == "sinh" || signal == "cosh" || signal == "tanh" || signal == "ln" || signal == "cot"
                || signal == "sec" || signal == "cosec" || signal == "eqn1" || signal == "eqn2" || signal == "sin-1" || signal == "cos-1"
                || signal == "tan-1" || signal == "sinh-1" || signal == "cosh-1" || signal == "tanh-1")
            {
                if (signal == "sqrt")
                    sqrt(number1);
                else if (signal == "sin")
                    sin(number1);
                else if (signal == "cos")
                    cos(number1);
                else if (signal == "tan")
                    tan(number1);
                else if (signal == "sinh")
                    sinh(number1);
                else if (signal == "cosh")
                    cosh(number1);
                else if (signal == "tanh")
                    tanh(number1);
                else if (signal == "sin-1")
                    Asin(number1);
                else if (signal == "cos-1")
                    Acos(number1);
                else if (signal == "tan-1")
                    Atan(number1);
                else if (signal == "sinh-1")
                    Asinh(number1);
                else if (signal == "sinh-1")
                    Asinh(number1);
                else if (signal == "cosh-1")
                    Acosh(number1);
                else if (signal == "tanh-1")
                    ATanh(number1);
                else if (signal == "ln")
                    ln(number1);
                else if (signal == "cot")
                    cot(number1, number2);
                else if (signal == "sec")
                    sec(number1);
                else if (signal == "cosec")
                    cosec(number1);
                else if (signal == "eqn2")
                    eqn2(a, b, c);
                else if (signal == "eqn1")
                    eqn1(a, b, c);
            }
            else if (signal == "1" || signal == "2" || signal == "3")
            {
                if (signal == "1")
                    convertDecimaltoOcatal();
                else if (signal == "2")
                    convertDecimaltoBinary();
                else if (signal == "3")
                    ConvertDecimaltoHaxdecimal();
            }
            else
                welcometouser("Error try agin please");
        }
        static void sum(double number1, double number2)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write(" please enter the number2 = ");
            number2 = double.Parse(Console.ReadLine());

            double dresult = number1 + number2;
            Console.WriteLine("the sumation operation = " + number1 + " + " + number2 + " = " + dresult);

        }
        static void subtraction(double number1, double number2)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write(" please enter the number2 = ");
            number2 = double.Parse(Console.ReadLine());

            double dresult = number1 - number2;
            Console.WriteLine("the subtraction operation = " + number1 + " - " + number2 + " = " + dresult);

        }
        static void multiplication(double number1, double number2)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write(" please enter the number2 = ");
            number2 = double.Parse(Console.ReadLine());

            double dresult = number1 * number2;
            Console.WriteLine("the subtraction operation = " + number1 + " * " + number2 + " = " + dresult);
        }
        static void Division(double number1, double number2)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write(" please enter the number2 = ");
            number2 = double.Parse(Console.ReadLine());

            double dresult = number1 / number2;
            Console.WriteLine("the subtraction operation = " + number1 + " / " + number2 + " = " + dresult);
        }
        static void percent(double number1, double number2)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write(" please enter the number2 = ");
            number2 = double.Parse(Console.ReadLine());

            double dresult = number1 % number2;
            Console.WriteLine("the subtraction operation = " + number1 + " % " + number2 + " = " + dresult);
        }
        static void power(double number1, double number2)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write(" please enter the number2 = ");
            number2 = double.Parse(Console.ReadLine());
            double dresult = Math.Pow(number1, number2);
            Console.WriteLine("the power operation = " + number1 + " ^ " + number2 + " = " + dresult);
        }
        static void sqrt(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Sqrt(number1);
            Console.WriteLine("the sqrt operation = " + " sqrt " + number1 + " = " + dresult);
        }
        static void sin(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Sin(number1);
            Console.WriteLine("the function sin operation = " + " sin( " + number1 + " ) = " + dresult );
        }
        static void cos(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Cos(number1);
            Console.WriteLine("the function sin operation = " + " cos( " + number1 + " ) = " + dresult);
        }
        static void tan(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Tan(number1);
            Console.WriteLine("the function sin operation = " + " sin( " + number1 + " ) = " + dresult);
        }
        static void sinh(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Sinh(number1);
            Console.WriteLine("the function sin operation = " + " sinh( " + number1 + " ) = " + dresult);
        }
        static void cosh(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Cosh(number1);
            Console.WriteLine("the function sin operation = " + " cosh( " + number1 + " ) = " + dresult);
        }
        static void tanh(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Tanh(number1);
            Console.WriteLine("the function sin operation = " + " tanh( " + number1 + " ) = " + dresult);
        }
        static void ln(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Log(number1);
            Console.WriteLine("the function ln operation = " + " ln( " + number1 + " ) = " + dresult);
        }
        static void cot(double number1, double number2)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write(" please enter the number2 = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = (Math.Cos(number1)) / (Math.Sin(number2));
            Console.WriteLine("the function cot operation = " + " cot( " + number1 + number2 + " ) = " + dresult);
        }
        static void sec(double number1)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult =  (1 / Math.Cos(number1));
            Console.WriteLine("the function sec operation = " + " sec( " + number1 +" ) = " + dresult);
        }
        static void cosec(double number1)
        {
            Console.Write(" please enter the number1 = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = (1 / Math.Cos(number1));
            Console.WriteLine("the function cosec operation = " + " cosec( " + number1 + " ) = " + dresult );
        }
        static void Acos( double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Acos(number1);
            Console.WriteLine("the function cos-1 operation = " + " cos-1( " + number1 + " ) = " + dresult * 180 / Math.PI);
        }
        static void Asin(double number1) 
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Asin(number1);
            Console.WriteLine("the function sin-1 operation = " + " Sin-1( " + number1 + " ) = " + dresult * 180 / Math.PI);
        }
        static void Atan(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Atan(number1);
            Console.WriteLine("the function Tan-1 operation = " + " Tan-1( " + number1 + " ) = " + dresult * 180 / Math.PI);
        }
        static void Asinh(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Asinh(number1);
            Console.WriteLine("the function Sinh-1 operation = " + " Sinh-1( " + number1 + " ) = " + dresult * 180 / Math.PI);
        }
        static void Acosh(double number1)
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Acosh(number1);
            Console.WriteLine("the function Cosh-1 operation = " + " Cosh-1( " + number1 + " ) = " + dresult * 180 / Math.PI);
        }
        static void ATanh(double number1) 
        {
            Console.Write(" please enter the number = ");
            number1 = double.Parse(Console.ReadLine());
            double dresult = Math.Atanh(number1);
            Console.WriteLine("the function Tanh-1 operation = " + " Tanh-1( " + number1 + " ) = " + dresult * 180 / Math.PI);
        }
        static void eqn2(double a, double b , double c )
        {
            double X1, X2;
            Console.Write("please enter the  value a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("please enter the  value b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("please enter the  value c = ");
            c = double.Parse(Console.ReadLine());
            X1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            X2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("the result one value X1 = " + X1);
            Console.WriteLine("the result one value X2 = " + X2);
        }
        static void eqn1(double a, double b, double c)
        {
            double X1;
            Console.Write("please enter the  value a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("please enter the  value b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("please enter the  value c = ");
            c = double.Parse(Console.ReadLine());
            if (c == 0)
            {
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("unlimited solution");
                }
                else if (a == 0 && b != 0)
                {
                    Console.WriteLine("unditermined solution");
                }
                else
                {
                    X1 = -b / a;
                    Console.WriteLine("the result one value X1 = " + X1);
                }
            }
            else if (c > 0)
            {
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("unlimited solution");
                }
                else if (a == 0 && b != 0)
                {
                    Console.WriteLine("unditermined solution");
                }
                else
                {
                    X1 = (c - b) / a;
                    Console.WriteLine("the result one value X1 = " + X1);
                }
            }
            else
            {
                Console.WriteLine("Math Error try again ??");
            }
        }
        static void convertDecimaltoOcatal()
        {
            string signal;
            signal = Console.ReadLine();

                Console.WriteLine(" this program is convert from Decimal number to Octal number ");
                Console.Write("Enter a Decimal integer number = ");
                int Decimalnumber, quotien, remainder;
                Decimalnumber = int.Parse(Console.ReadLine());
                quotien = Decimalnumber;
                string octalresult = "";
                while (quotien != 0)
                {
                    remainder = quotien % 8;
                    quotien = quotien / 8;
                    octalresult = remainder + octalresult;
                }
                Console.WriteLine("Octal equivalent : " + octalresult);
        }
        static void convertDecimaltoBinary()
        {
            Console.WriteLine(" this program is convert from Decimal number to Binary number");

            Console.Write("Enter a Decimal integer number = ");
            int Decimalnumber, quotien, remainder;
            Decimalnumber = int.Parse(Console.ReadLine());
            quotien = Decimalnumber;
            string Binaryresult = "";
            while (quotien != 0)
            {
                remainder = quotien % 2;
                quotien = quotien / 2;
                Binaryresult = remainder + Binaryresult;
            }
            Console.WriteLine("Binary equivalent : " + Binaryresult);
        }
        static void ConvertDecimaltoHaxdecimal()
        {
            Console.WriteLine(" this program is convert from Decimal number to hexdecimal number");
            Console.Write("Enter a Decimal integer number = ");
            int Decimalnumber, quotien, remainder;
            string s = "";
            Decimalnumber = int.Parse(Console.ReadLine());
            quotien = Decimalnumber;
            string hexdecimal = "";
            while (quotien != 0)
            {
                remainder = quotien % 16;
                quotien = quotien / 16;
                if (remainder == 10)
                {
                    s = "A";
                    hexdecimal = s + hexdecimal;
                }
                else if (remainder == 11)
                {
                    s = "B";
                    hexdecimal = s + hexdecimal;
                }
                else if (remainder == 12)
                {
                    s = "C";
                    hexdecimal = s + hexdecimal;
                }
                else if (remainder == 13)
                {
                    s = "D";
                    hexdecimal = s + hexdecimal;
                }
                else if (remainder == 14)
                {
                    s = "E";
                    hexdecimal = s + hexdecimal;
                }
                else if (remainder == 15)
                {
                    s = "F";
                    hexdecimal = s + hexdecimal;
                }
                else
                {
                    hexdecimal = remainder + hexdecimal;
                }
            }
            Console.WriteLine("the hexdecimal = " + hexdecimal);
        }
    }
    
}