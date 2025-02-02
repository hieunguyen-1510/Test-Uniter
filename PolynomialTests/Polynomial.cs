﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Polynomial
{
    private int n;
    private List<int> a;

    public Polynomial(int n, List<int> a)
    {
        if (n < 0 || a.Count() != n + 1)
        {
            throw new ArgumentException("Invalid Data");
        }
        this.n = n;
        this.a = a;
    }

    public int Cal(double x)
    {
        int result = 0;
        for (int i = 0; i <= this.n; i++)
        {
            result += (int)(a[i] * Math.Pow(x, i));
        }
        return result;
    }
}
