using EllipticCurve.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Programs
{
    public class PracticeProgram
    {

        //[0,0,1,0,0,1,1,0,1,1,0]

        public int flipo1()
        {

            int[] a = new int[] { 1, 0, 0, 1, 1, 0, 0, 0, 1, 0 };

            int k = 2;
            int z = k;
            int j = 0;
            int count = 0;
            int max=int.MinValue;
            bool flag=false;
            for (int i =0; i< a.Length;i++)
            {

                if (a[i] == 1)
                {

                    count++;
                    flag = false;
                }
                else  if (a[i] == 0 && k > 0)
                {
                     
                     k--;
                     count++;
                     flag = false;
                }
                else if (k == 0)
                {
                    while (k < z-1)
                    {
                        if (a[j] == 0)
                        {
                            k++;
                        }
                        count--;
                        j++;
                        flag = true;

                    }
                }
                if (max < count)
                {
                    max = count;
                }
                
                if (a[i]==0 &&k>0 && flag==true)
                {
                    count++;
                    k--;
                }
                else if (a[i] == 1 && flag == true)
                {
                    count++;

                }

            }
            return max;
        
        }

            public void flipoa1()
        {
            int[] a = new int[]{ 0, 0, 1, 1, 0, 1, 1, 0, 1, 1, 0};

            int k = 2;
            int count = 0;
            int prevcount = 0;
            for (var i=0;i< a.Length; i++)
            {
                //if (k==0 && count+prevcount > a.Length -i)
                //{
                //    Console.WriteLine(count+prevcount);
                //    break;
                //}
                if (a[i] == 1)
                {
                    count++;
                }
               else if (k == 0 )
                {
                    i--;
                    for (var j = count; j > 0; j--)
                    {
                        
                        if (a[count-1] == 1)
                        {
                            prevcount++;
                            count--;
                        }
                        else
                        {

                            count = 0;
                            k = 2;
                            break;
                        }
                        
                    }

                }
              else  if (k>0)
                { 
                    if (a[i]==0)
                    {
                        k--;
                        count++;
                    }
                }
                
            }
        }



        public int minCoins(int n, int[] a)
        {
            if (n==6)
            {
                Console.WriteLine(n);
            }

            if (n == 0) return 0;

            int ans = Int32.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {
                if (n - a[i] >= 0)
                {
                   
                       int subAns = minCoins(n - a[i], a);
                    
                    if (subAns != int.MaxValue &&
                            subAns + 1 < ans)
                    {
                        ans = subAns + 1;
                       
                    }
                }
            }
            return ans; 
           // return dp[n] = ans;
        }
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
