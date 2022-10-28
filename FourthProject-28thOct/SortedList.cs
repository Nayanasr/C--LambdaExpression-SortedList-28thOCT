using System;
using System.Collections.Generic;
using System.Text;

namespace FourthProject_28thOct
{
    
    public class SortedList
    {
        public void sorted()
        {
            SortedList<int, int> numberNames = new SortedList<int, int>()
                                    {
                                        {3, 1},
                                        {1, 2},
                                        {2, 3}
                                    };
            for (int i = 0; i < numberNames.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
            }
        }
    }
}

//https://www.tutorialsteacher.com/csharp/csharp-collection
