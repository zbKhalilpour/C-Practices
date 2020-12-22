using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhayyamTriangle
{
    public class CreateKhayyamTriangle
    {
        public static List<Array> CreateTriangle(int numberOfLevel)
        {
            List<Array> Triangle = new List<Array>();
            for (int i = 0; i < numberOfLevel + 1; i++)
            {
                var levelOfTriangle = new int[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    if ((j == 0) || (j == i))
                    {
                        levelOfTriangle[j] = 1;
                    }
                    else
                    {
                        var tempArray = Triangle[i - 1];
                        levelOfTriangle[j] = Convert.ToInt32(tempArray.GetValue(j - 1)) + Convert.ToInt32(tempArray.GetValue(j));
                    }
                }

                Triangle.Add(levelOfTriangle);
            };
            return Triangle;
        }
    }
}
