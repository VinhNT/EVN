using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVN.Lib
{
    class BPBase
    {
        [Serializable]
        public struct PreInput
        {
            public double Value;
            public double[] Weights;
        };
 
        [Serializable]
        public struct Output<T> where T : IComparable<T>
        {
            public double InputSum;
            public double output;
            public double Error;
            public double Target;
            public T Value;
        };

        public class NeuralEventArgs : EventArgs
        {
            public bool Stop = false;
            public double CurrentError = 0;
            public int CurrentIteration = 0;
        }
    }
}
