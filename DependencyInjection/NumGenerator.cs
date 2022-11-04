using System;

namespace DependencyInjection
{
    public class NumGenerator :INumGenerator
    {
        public int GetRandomNumber()
        {
           

            return new Random().Next(10);
        }
       
    }
    public interface INumGenerator
    {
        public int GetRandomNumber();
    }
}
