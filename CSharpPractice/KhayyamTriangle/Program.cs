using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhayyamTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of levels triangle :");
            int NumberOfLevel=Convert.ToInt32( Console.ReadLine());
            List<Array> Triangle = new List<Array>();
            for (int i = 0; i < NumberOfLevel; i++)
            {  
                var levelOfTriangle = new int[i+1];

                for (int j = 0; j < i+1; j++)
                {
                    if ((j == 0) && (j == i ))
                    {
                        levelOfTriangle[j] = 1;
                    }
                    else
                    {
                        var tempArray = Triangle[i-1];
                        levelOfTriangle[j] = Convert.ToInt32( tempArray.GetValue(j-1))+ Convert.ToInt32(tempArray.GetValue(j));
                    }
                    Triangle.Add(levelOfTriangle);
                }
                
            };

            Console.WriteLine("Your List sorted: ");
            for (int i = 0; i < Triangle.Count; i++)
            {
                Console.WriteLine(string.Format("" + Triangle[i]));
            }

        }
    }
}
