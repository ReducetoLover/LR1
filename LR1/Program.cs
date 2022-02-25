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
      double p;
      double LensInterval;
      double k;
      double Tall = 0;
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
      double Tdis = Math.Pow((b - a), 2) / 12;
      double Pmath = Tall / N;
      for (int i = 0; i < N; i++)
      {
        all += Math.Pow((ARR[i] - Pmath), 2);
      }
      double Pdis = Math.Sqrt(all / N);

      k = Math.Round(1 + 3.219 * Math.Log10(N));
      p = 1 / k;

      var intervals = new Dictionary<double, List<double>>();
      LensInterval = (b - a) / k;

      double ind = a;
      bool finish = false;

      while (!finish)
      {
        if (ind < b)
        {
          ind += LensInterval;
        }
        if(ind >= b)
        {
          ind = b;
          finish = true;
        }
        for (int i = 0; i < ARR.Length; i++)
        {

          if (ARR[i] >= ind - LensInterval && ARR[i] < ind)
          {
            if (!intervals.ContainsKey(ind)) intervals[ind] = new List<double>();

            intervals[ind].Add(ARR[i]);
          }
        }
        Console.WriteLine($"'''{ind}'''");
      }

      double func = 0;
      foreach (KeyValuePair<double, List<double>> item in intervals)
      {
        Console.WriteLine($"{item.Key}: {intervals[item.Key].Count}");

        func += Math.Pow(intervals[item.Key].Count - (N * p), 2) / (N * p);
        Console.WriteLine($"func = {func} ;{intervals[item.Key].Count - (N * p)};{Math.Pow(intervals[item.Key].Count - (N * p), 2)}; {N*p}");

      }


      Console.WriteLine($"K= {k} ({LensInterval}) ||| func={Math.Sqrt(func)} ||| func2= ||| p={p}");
      Console.WriteLine("длина интервала= " + LensInterval);


      Console.WriteLine("Тматожидание= " + Tmath);
      Console.WriteLine("Оценкаматожидание= " + Pmath);
      Console.WriteLine("Тдисперсия= " + Tdis);
      Console.WriteLine("Оценкадисперсии= " + Pdis);

    }
  }
}
