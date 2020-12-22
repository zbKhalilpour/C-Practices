using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhayyamTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of levels triangle :");
            int numberOfLevel = Convert.ToInt32(Console.ReadLine());

            var Triangle = CreateKhayyamTriangle.CreateTriangle(numberOfLevel);

            Console.WriteLine("You created a Khayyam Triangle in {0} levels: ", numberOfLevel);

            for (int i = 0; i < Triangle.Count; i++)
            {
                var triangle = Triangle[i];

                for (int j = 0; j < triangle.Length; j++)
                {
                    Console.Write("{0}  ", triangle.GetValue(j));
                }
                Console.Write("\n");
            }



            //****my mistake try******///
            //for (int i = 0; i < Triangle.Count; i++)
            //{
            //    var triangle = Triangle[i];
            //    Console.Write(triangle);
            //}

            //for (int i = 0; i < Triangle.Count; i++)
            //{
            //    var triangle = Triangle[i];
            //    foreach (var item in triangle)
            //    {  
            //        Console.WriteLine(item);
            //    }
            //}

            //for (int i = 0; i < Triangle.Count; i++)
            //{
            //    var triangle = Triangle[i];
            //    foreach (var item in triangle)
            //    {
            //        var stringTrianle = item.ToString();
            //        Console.WriteLine(string.Join(",", stringTrianle));
            //    }
            //}

            //for (int i = 0; i < Triangle.Count; i++)
            //{
            //    var triangle = Triangle[i];
            //    foreach (var item in triangle)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}




            Console.ReadLine();
        }
    }
}
