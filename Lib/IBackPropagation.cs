﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVN.Lib
{
    interface IBackPropagation<T>
    {
        void BackPropagate();
        double F(double x);
        void ForwardPropagate(double[] pattern, T output);
        double GetError();
        void InitializeNetwork(Dictionary<T, double[]> TrainingSet);
        void Recognize(double[] Input, ref T MatchedHigh, ref double OutputValueHight,
                                        ref T MatchedLow, ref double OutputValueLow);
    }
}
