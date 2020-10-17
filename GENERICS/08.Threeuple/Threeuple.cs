using System;
namespace _08.Threeuple
{
    public class Threeuple<TFirst,TSecond,TThird>
    {
        public Threeuple(TFirst first, TSecond second, TThird third)
        {
            this.First = first;
            this.Second = second;
            this.Third = third;
        }

        public TFirst First { get; set; }

        public TSecond Second { get; set; }

        public TThird Third { get; set; }

        public override string ToString()
        {
            return $"{First} -> {Second} -> {Third}";
        }
    }
}
