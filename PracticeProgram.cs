using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Programs
{
    public class PracticeProgram
    {
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> aa = new List<int>();
            int count = 0;
            int countAlice = 0;
            int countBob = 0;
            foreach (var i in a)
            {
                if (a[count] > b[count])
                {
                    countAlice++;
                    aa[0] = countAlice;
                }
                else if (a[count] < b[count])
                {
                    countBob++;
                    aa[1] = countBob;

                }
                count++;
            }
            return aa;
        }


        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach (var i in ar)
            {
                sum = sum + i;
            }
            return sum;



        }

        public void print3rdhighest()
        {
            int[] arry = new int[] { 1, 3, 2, 5, 6, 111, 34, 12, 11111, 232 };

            int first = 0;
            int second = 0;
            int third = 0;

            for (int i = 1; i < arry.Length; i++)
            {
                if (i == 1)
                {
                    if (arry[0] > arry[1])
                    {
                        first = arry[0];
                        second = arry[1];
                        continue;
                    }
                    else
                    {
                        second = arry[0];
                        first = arry[1];
                        continue;
                    }
                }
                if (arry[i] > first)
                {
                    third = second;
                    second = first;
                    first = arry[i];
                }
                else if (arry[i] > second)
                {
                    third = second;
                    second = arry[i];

                }
            }
            Console.WriteLine(first + " " + second + " " + third);



        }
        public void closesttogiven()
        {
            var ar1 = new int[] { 1, 4, 5, 6 };
            var ar2 = new int[] { 10, 20, 30, 40 };
            int k = 47;
            int prev = int.MinValue;
            int closet = 0;

            for (int i = 0; i < ar1.Length; i++)
            {
                for (int j = 0; j < ar2.Length; j++)
                {
                    closet = ar1[i] + ar2[j];
                    if (closet < k && closet > prev)
                    {

                        prev = closet;
                    }
                }
            }
            Console.WriteLine("Closest Element is " + prev);

        }

        public void Anagrams()
        {

            var a = "adil";
            var b = "lia";



            Dictionary<char, int> z = new Dictionary<char, int>();
            Dictionary<char, int> x = new Dictionary<char, int>();

            for (var i = 0; i < a.Length; i++)
            {

                if (z.ContainsKey(a[i]))
                {

                    z[a[i]]++;
                }
                else
                {
                    z.Add(a[i], 1);
                }


            }
            for (var i = 0; i < b.Length; i++)
            {

                if (x.ContainsKey(b[i]))
                {

                    x[b[i]]++;
                }
                else
                {
                    x.Add(b[i], 1);
                }


            }
            bool flag = false;
            foreach (var q in z)
            {
                if (x.ContainsKey(q.Key))
                {
                    if (z[q.Key] == x[q.Key])
                        flag = true;
                    continue;

                }
                else
                {
                    return;
                }


            }


        }

        public void EquvilentcharAryCheck()
        {


            char[] a = new char[] { 'a', 'f', 'w', 'e' };
            char[] b = new char[] { 'a', 'f', 'z', 'e' };
            var z = b.OrderBy(x => x).ToArray();
            var d = a.OrderBy(y => y).ToArray();
            for (var i = 0; i < a.Length; i++)
            {
                if (d[i] != z[i])
                {
                    return;
                }
            }
        }

        public void MergeTwoSorted()
        {
            var ar1 = new int[] { 1, 3, 4, 5, 16 };
            var ar2 = new int[] { 10, 12, 15, 17, 122, 223, 21113 };
            var len = ar1.Length + ar2.Length;
            var arr3 = new int[len];
            int point1 = 0;
            int point2 = 0;
            int arr3index = 0;
            for (int i = 0; i < len; i++)
            {
                if (point1 >= ar1.Length && point2 < ar2.Length)
                {

                    arr3[arr3index] = ar2[point2];
                    point2++;
                    arr3index++;

                }
                else if (point2 >= ar2.Length && point1 < ar1.Length)
                {
                    arr3[arr3index] = ar1[point1];
                    point1++;
                    arr3index++;

                }
                else if (ar1[point1] < ar2[point2])
                {
                    arr3[arr3index] = ar1[point1];
                    point1++;
                    arr3index++;

                }
                else
                {
                    arr3[arr3index] = ar2[point2];
                    point2++;
                    arr3index++;
                }

            }
            for (var k = 0; k < arr3.Count(); k++)
            {

                Console.WriteLine(arr3[k]);
            }


        }
    }
}
