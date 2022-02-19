using System;

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
      double all=0;
      Console.Write("A=");
      double a = Convert.ToDouble(Console.ReadLine());
      Console.Write("B=");
      double b = Convert.ToDouble(Console.ReadLine());
      Console.Write("N=");
      int N = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < N; i++)
      {
        Random rnd = new Random();
        double r = rnd.NextDouble();
        double R = a + (b - a) * r;
        all += R;
        Console.WriteLine(R);
      }
      double Tmath = (a + b) / 2;
      double Tdis = Math.Pow((b - a),2) / 12;
      double Pmath = all / N;
      Console.WriteLine("Тмат= " +Tmath);
      Console.WriteLine("мат= " + Pmath);
    }
  }
}
