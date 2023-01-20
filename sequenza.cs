using System;
using System.Collections.Generic;
using System.Linq;

public static class Sequenza
{
    public static int[] Verifica( int N ) 
    {
        int[] valori = new int [N*(N+1)/2];
        int index = 0;
        if (N >= 0){
            for (int i = 0; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    valori[index] = i;
                    index++;
                }  
            }
            return valori;
        }
        else
        {
            return new int[0];
        }
    }
}
