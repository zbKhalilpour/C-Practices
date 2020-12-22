using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhayyamTriangle
{
    public class CreateKhayyamTriangle
    {
       public static List<Array> KhayyamTriangle(int NumberOfLevel)
       {
            for (int i = 0; i < NumberOfLevel; i++)
            {
                List<Array> Triangle = new List<Array>();
                var levelOfTriangle = new int[i];

                for (int j = 0; j < i; j++)
                {
                    if ((j == 0) && (j == NumberOfLevel - 1))
                    {
                        levelOfTriangle[j] = 1;
                    }
                    else
                    {
                        var tempArray = Triangle[i];
                        levelOfTriangle[j] = tempArray[j - 1] + tempArray[j];
                    }
                }

                Triangle.Add(levelOfTriangle);
            };
            return Triangle;
        }
    }
}
