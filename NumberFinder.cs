using System;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            string s = number.ToString();
            char[] arr = new char[s.Length];
            arr = s.ToCharArray();
            
            for (int i = 0; i < arr.Length - 1; i++)
            {              
                if (arr[arr.Length - 1] > arr[arr.Length - i - 2]) {
                    char tmp = arr[arr.Length - 1];
                    arr[arr.Length - 1] = arr[arr.Length - i - 2];
                    arr[arr.Length - i - 2] = tmp;
                    
                    string b = new string(arr);
                    int a = Convert.ToInt32(b);
                    return a;
                }         
            }

            return 0;
        }
    }
}
