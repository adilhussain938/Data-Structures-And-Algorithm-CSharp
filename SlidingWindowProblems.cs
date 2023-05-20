using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class SlidingWindowProblems
    {

        public bool Anagrams(string a ,string b)
        {

            //var a = "adil";
            //var b = "lia";



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
                    return false;
                }


            }
                
            return true;
            

        }
        public void printanagraminsubsequence()
        {
            string a = "kbcaaalabcaaocbaaakjkjkjjjjkkabaac";
            string b= "abcaa";
            int  e = 0;
            for (int p=0;p<b.Length;p++)
            {
                e++;
            }
            for (var i=0;i<a.Length;i++)
            {
                if(a.Length-i+1>b.Length)
                { 
                    if(Anagrams(a.Substring(i, e), b))
                    {
                        Console.WriteLine(a.Substring(i,e)+ " is Anagram of "+b);
                    }
                }

            }

            

        }


        public void PrintMaxNumberSubarray()
        {
            var arry = new int[] { 2, 3, 1000, 14, 105, 600,04, 23, 32, 300 };
            List<int> maxValues = new List<int>();
            int i = 0, j = 0;
            int k = 3;
            bool flag = false;

            for (int z = 0; z < arry.Length; z++)
            {
                if (maxValues.Count == 0)
                {
                    maxValues.Add(arry[0]);
                }

                    while (arry[j] > maxValues.Last())
                    {
                        maxValues.RemoveAt(maxValues.IndexOf(maxValues.LastOrDefault()));
                        flag = true;
                    if (maxValues.Count == 0)
                    {
                        break;
                    }
                }


                if (maxValues.Count > 0)
                {
                    if (arry[j] < maxValues[0] && !flag)
                    {
                        maxValues.Add(arry[j]);
                    }
                    else
                    {
                        maxValues.Add(arry[j]);
                    }

                }
                else
                {
                    maxValues.Add(arry[j]);
                }

                if (j - i + 1 < k)
                {
                    j++;
                }
                else
                {
                    Console.WriteLine(maxValues.First());
                    if (arry[i] == maxValues.First())
                    {
                        maxValues.RemoveAt(0);
                    }
                    i++;
                    j++;
                }

                flag = false;
            }
        }


        public void PrintMaxSubarrayofSizeK()
        {

            var a = new int[]{1,2,3,4,5,6,43,12,3,5,6,7};
            int i=0, j=0,k=3;
            int sum = 0,max=0;
            while(j< a.Length)
            {
                sum = sum + a[j];
                if(j-i< k)
                {
                    j++;
                    max = sum;
                }
                else 
                { 

                    sum = sum - a[i];

                    if (sum> max)
                    {
                        max = sum;
                    }
                   
                    j++;
                    i++;
                }
            }


        }
        public void PrintFirstNegativeNumber()
        {

            var a = new int[] { 1, -2, 3, -4, 5, 6, -43, 12, -3, 5, -6, 7 };
            int i = 0, j = 0, k = 3;
            
            while (j < a.Length)
            {
                
                if (j - i+1 < k)
                {
                    j++;
                    
                }
                else
                {
                    for (int z=i;z<j;z++)
                    {
                        if (a[z]<0)
                        {
                            Console.WriteLine(a[z]);
                            break;
                        }
                    }
                    i++;
                    j++;
                }

            }
        }
        public void PrintFirstNegativeNumberQueue()
        {

            var a = new int[] { 1, -2, 3, -4, 5, 6, -43, 12, -3, 5, -6, 7 };
            int i = 0, j = 0, k = 3;
            Queue<int> que = new Queue<int>();
            while (j < a.Length)
            {
                
                if (j - i+1 < k)
                {
                    if (a[j]<0)
                    {
                        que.Enqueue(a[j]);
                    }

                        j++;
                }
                else
                {

                    if (a[j] < 0)
                    {
                        que.Enqueue(a[j]);
                    }

                    Console.WriteLine(que.Peek());
                    if (a[i] == que.Peek())
                    {
                        que.Dequeue();
                    }
                    i++;
                    j++;
                }

            }
        }


        public void longestsubstringwithkuniqueCharacter()
        {


            var a = "aaaaabzaaaacbebebe";
            int i=0, j = 0;
            int l = 2;
            var diction = new Dictionary<char, int>();
            int max =int.MinValue ;
            int max1 = 0;
            for ( var k=0;k< a.Length;k++)
            {
                if (diction.ContainsKey(a[k]))
                {
                    diction[a[k]]++;
                    i++;
                }
                else
                {
                    diction.Add(a[k], 1);
                    i++;
                }

                if (diction.Count == l)
                {
                     max1 = i - j;

                }
                else if(diction.Count >l)
                {
                    while(diction.Count>l)
                    {
                        //var a = "aabacbebebe";
                        diction[a[j]]--;

                        if (diction[a[j]]==0)
                        {
                            diction.Remove(a[j]);
                        }
                        
                            j++;
                        
                }
                }
                if (max1 > max)
                {
                    max = max1;
                }
                    
                
            }
            Console.WriteLine(max);



        }

            }
        }
