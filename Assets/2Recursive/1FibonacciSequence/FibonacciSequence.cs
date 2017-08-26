using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// F(0)=0, F(1)=1, F(n)=F(n-1)+F(n-2)
/// </summary>
public static class FibonacciSequence 
{
    public static int AccumulationFibonacci(int index)
    {
        if (index == 0) return 0;
        if (index == 1) return 1;
        return AccumulationFibonacci(index - 1) + AccumulationFibonacci(index - 2);
    }
}
