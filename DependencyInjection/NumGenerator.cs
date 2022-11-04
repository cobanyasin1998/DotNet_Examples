using System;

namespace DependencyInjection
{
    public class NumGenerator
    {
        public int GetRandomNumber()
        {
           

            return new Random().Next(10);
        }
    }
}
