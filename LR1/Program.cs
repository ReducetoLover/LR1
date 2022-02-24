using System;
using System.Collections.Generic;

namespace LR1
{
  class Program
  {
    static void Main(string[] args)
    {
      LAb1();
      //LAb1(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
    }
    //N>1000
    //a  b границы интервала  сгенерировать N больше случ чисел от а до b
    static void LAb1()
    {
      double XI = 0;
      double p = 0;
      double LensInterval = 0;
      double k = 0;
      double Tall=0;
      double all = 0;
      Console.Write("A=");
      double a = Convert.ToDouble(Console.ReadLine());
      Console.Write("B=");
      double b = Convert.ToDouble(Console.ReadLine());
      Console.Write("N=");
      int N = Convert.ToInt32(Console.ReadLine());
      double[] ARR = new double[N];
      for (int i = 0; i < N; i++)
      {
        Random rnd = new Random();
        double r = rnd.NextDouble();
        double R = a + (b - a) * r;
        ARR[i] = R;
        Tall += R;
        Console.WriteLine(R);
      }
      double Tmath = (a + b) / 2;
      double Tdis = Math.Pow((b - a),2) / 12;
      double Pmath = Tall / N;
      for (int i = 0; i < N; i++)
      {
        all += Math.Pow((ARR[i] - Pmath), 2);
      }
      double Pdis =Math.Sqrt(all / N);

      k = Math.Round(1 + 3.219 * Math.Log10(N));
      p = 1 / k;
      // double[] intervals = new double[Convert.ToInt32(k)];
      var intervals = new KeyValuePair<double, double>();
      LensInterval = Math.Round((b - a) / k,3);
      int f = 10;
      //for (int i = 0; i < ARR.Length; i++)
      //{
      //  intervals[f % (i + 1)]= ARR[i];
      //}

      //Console.WriteLine(intervals.Count);
      Console.WriteLine("K= "+k);
      Console.WriteLine("длина интервала= " + LensInterval);


      Console.WriteLine("Тматожидание= " +Tmath);
      Console.WriteLine("Оценкаматожидание= " + Pmath);
      Console.WriteLine("Тдисперсия= " + Tdis);
      Console.WriteLine("Оценкадисперсии= " + Pdis);

    }
  }
}
