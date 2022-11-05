using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class NumGenerator2 : INumGenerator2
    {
        public int RandomValue { get; }

        private readonly INumGenerator _numGenerator;

        public NumGenerator2(INumGenerator numGenerator)
        {
            _numGenerator = numGenerator;
            RandomValue = new Random().Next(10);
        }

        public int GetNumGeneratorRandomNumber()
        {
            return _numGenerator.RandomValue;
        }
    }
    public interface INumGenerator2
    {
        public int RandomValue { get; }
        public int GetNumGeneratorRandomNumber();
    }
}
