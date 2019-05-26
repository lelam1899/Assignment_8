using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
        public class Program
        {

            public Program()
            {

            }
            public static void Main(string[] args)
            {
                Number<int> number = new Number<int>();
                number.number_one = 20;
                number.number_two = 122;
                number.total();

                number.genericMethod("param for generic method");

                Number<float> number2 = new Number<float>();
                number2.number_one = 12;
                number2.number_two = (float)3.14;
                MyGeneric<int, string> xyz = new MyGeneric<int, string>();
            }


        }
        public class MyGeneric<K, V>
        {

        }
        public class Number<T>
        {
            public T number_one;
            public T number_two;

            public void total()
            {
                if (number_one is int)
                {
                    int x = Convert.ToInt32(number_one);
                    int y = Convert.ToInt32(number_two);
                    Console.WriteLine(x + y);
                }
                else if (number_one is double || number_two is float)
                {
                    double x = Convert.ToDouble(number_one);
                    double y = Convert.ToDouble(number_two);
                    Console.WriteLine(x + y);
                }
            }

            internal void genericMethod<E>(E val)
            {
                Console.WriteLine(val);
            Console.ReadKey();
                
            }
        }
    }



