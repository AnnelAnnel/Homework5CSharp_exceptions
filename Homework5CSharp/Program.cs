using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homework5CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            testArrayLength();
            //testLink();
            //testFraction();

        }

        //1.Перехватить исключение запроса
        //  к несуществующему веб ресурсу
        //  и вывести сообщение о том, что 
        //  произошла ошибка.
        //  Программа должна завершиться без ошибок.

        static void testLink()
        {
            try
            {
                WebRequest request = WebRequest.Create("https://www.rtrtrtr.ru");
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            Console.WriteLine(reader.ReadToEnd());
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Обработка запроса завершена");
            }
        }

        //2.Написать программу, которая обращается к элементам массива
        //  по индексу и выходит за его пределы. 
        //  После обработки исключения вывести 
        //  в финальном блоке сообщение о завершении обработки массива.

        static void testArrayLength()
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }
            try
            {

                arr[12] = 3;//на этом этапе выйдет ошибка и передастся в catch
                //код ниже не отработает
                for (int j = 0; j < arr.Length + 1; j++)
                {
                    arr[j] += 2;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена");
            }

        }

        //3.Реализовать несколько методов или классов с методами и
        //  вызвать один метод из другого.В вызываемом методе сгенерировать
        //  исключение и «поднять» его в вызывающий метод.
        static void testFraction()
        {
            Fraction f = new Fraction(1, 0);
            try
            {
                int res = f.division();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }        
    }
}
