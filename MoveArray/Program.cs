using System;
public static class GFG
{

   
    public static void Main()
    {
        int[] A ={2,10,0,5,3,0,4,1 };
        int n = A.Length;
        int j = 0;

        for (int i = 0; i < n; i++)
        {
            if (A[i] != 0)
            {
                int temp = A[j];
                A[j] = A[i];
                A[i] = temp;
                j++;
            }
        }
        for (int i = n - 1; i >= 0; i--)

        {
            Console.Write(A[i]);
            Console.Write(" ");
        }
       // for (int i = 0; i < n; i++)
       // {
       //     Console.Write(A[i]);
       //     Console.Write(" ");
       // }
    }
}