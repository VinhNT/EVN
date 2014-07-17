using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVN.Lib
{
    class RecognizeSet
    {
        string matchedHight, matchedLow;
        Double hightRate, lowRate;
        public string MatchedHight
        {
            get { return matchedHight; }
            set { matchedHight = value; }
        }
        public string MatchedLow
        {
            get { return matchedLow; }
            set { matchedLow = value; }
        }
        public Double HightRate
        {
            get { return hightRate; }
            set { hightRate = value; }
        }
        public Double LowRate
        {
            get { return lowRate; }
            set { lowRate = value; }
        }

        public RecognizeSet(String MatchedHight, String MatchedLow, Double HigthRate, Double LowRate)
        {
            this.MatchedHight = MatchedHight;
            this.MatchedLow = MatchedLow;
            this.HightRate = HightRate;
            this.LowRate = LowRate;
        }
    }
}
