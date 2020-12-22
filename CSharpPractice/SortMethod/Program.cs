using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMethod
{
     class Program
     {
         static void Main(string[] args)
        {
                //**create-list**//
                Console.WriteLine("Please enter your numbers and end of that write -1: ");
                List<int> UnsortList = new List<int>();

                while (true)
                {
                    var input = Convert.ToInt32(Console.ReadLine());
                    //**fill-unsortedList**//
                    if (input != -1)
                    {
                        UnsortList.Add(input);
                    }
                    else
                    {
                        //**call-sortingMethod**//
                        var sortedList = Sort.Sorting(UnsortList);

                        //**print-sortedList**//
                        Console.WriteLine("Your List sorted: ");
                        for (int i = 0; i < sortedList.Count; i++)
                        {
                            Console.WriteLine(string.Format("" + sortedList[i]));
                        }
                    }
                };


                //call-nonstatic-method
                //Sort sortedList = new Sort();
                //sortedList.Sorting(UnsortList);

                /////*******fill array list
                //ArrayList UnsortList = new ArrayList();
                //while (true)
                //{
                //    var res = Convert.ToInt32(Console.ReadLine());
                //    if (res != -1)
                //    {
                //        UnsortList.Add(res);
                //    }
                //    else
                //    {
                //        Console.WriteLine(UnsortList.Count);
                //    }
                //}

                ///****with array--true
                ///Console.WriteLine("Please enter your number:");
                //var UnsortList = new int[5];
                //for (int i = 0; i < UnsortList.Length; i++)
                //{
                //    UnsortList[i] = Convert.ToInt32(Console.ReadLine());
                //}
                //for (int i = 0; i < UnsortList.Length + 1; i++)
                //{
                //    if ((i + 1) == UnsortList.Length)
                //        break;
                //    while (UnsortList[i] < UnsortList[i + 1]) { 

                //        for (int j = 0; j < UnsortList.Length + 1; j++)
                //        {
                //            if ((j + 1) == UnsortList.Length)
                //                break;
                //            if (UnsortList[j] < UnsortList[j + 1])
                //            {
                //                int temp;
                //                temp = UnsortList[j + 1];
                //                UnsortList[j + 1] = UnsortList[j];
                //                UnsortList[j] = temp; 
                //            }
                //        }
                //    }
                //}
                //for (int i = 0; i < UnsortList.Count; i++)
                //{
                //    Console.WriteLine(string.Format("result :{0}", UnsortList[i]));
                //}
                //Console.ReadLine();

                //**********print arraylist
                //for (int i = 0; i < UnsortList.Count; i++)
                //{
                //    Console.WriteLine(string.Format("result :{0}", UnsortList[i]));
                //}

                ///*********************swap--false
                //for (int i = 0; i < UnsortList.Length + 1; i++)
                //{
                //    if ((i + 1) == 5)
                //        break;
                //    if (UnsortList[i] < UnsortList[i + 1])
                //    {

                //        for (int j = 0; j < UnsortList.Length + 1; j++)
                //        {
                //            if ((j + 1) == 5)
                //                break;
                //            if (UnsortList[j] < UnsortList[j + 1])
                //            {
                //                int temp;
                //                temp = UnsortList[j];
                //                UnsortList[j] = UnsortList[j + 1];
                //                UnsortList[j + 1] = temp;
                //            }
                //        }
                //    }
                //}

                /////********myway--false
                //var SortedList = new int[10];
                //for (int i = 0; i < 10; i++)
                //{
                //    for (int j = 0; j < 10; j++)
                //    {
                //        if (UnsortList[j] > UnsortList[j++])
                //            SortedList[j] = UnsortList[j];
                //    }
                //    UnsortList = SortedList;
                //    if (UnsortList[i] > UnsortList[i++])
                //        SortedList[i] = UnsortList[i];
                //}


        }
        
     }
}
