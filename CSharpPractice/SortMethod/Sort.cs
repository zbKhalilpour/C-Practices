using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMethod
{
    public class Sort
    {
        public static List<int> Sorting(List<int> unsorteList)
        {
            /*for (int i = 0; i < unsorteList.Count + 1; i++)
            {
                if ((i + 1) == unsorteList.Count)
                    break;
                while ((unsorteList[i]) < unsorteList[i + 1])
                {

                    for (int j = 0; j < unsorteList.Count + 1; j++)
                    {
                        if ((j + 1) == unsorteList.Count)
                            break;
                        if (unsorteList[j] < unsorteList[j + 1])
                        {
                            int temp;
                            temp = unsorteList[j + 1];
                            unsorteList[j + 1] = unsorteList[j];
                            unsorteList[j] = temp;
                        }
                    }
                }
            }
            return unsorteList;*/


            var haveLoop = true;
            while (haveLoop)
            {
                haveLoop = false;
                for (int i = 0; i < unsorteList.Count - 1; i++)
                {
                    if (i + 1 >= unsorteList.Count)
                        break;
                    if (unsorteList[i] > unsorteList[i + 1])
                    {
                        var num1 = unsorteList[i];
                        unsorteList[i] = unsorteList[i + 1];
                        unsorteList[i + 1] = num1;
                        haveLoop = true;
                    }
                }
            }

            return unsorteList;
        }
    }
}
