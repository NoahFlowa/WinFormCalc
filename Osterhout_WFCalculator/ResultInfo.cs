using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osterhout_WFCalculator
{
    public struct ResultInfo
    {
        public double theResult { get; set; }

        public ResultInfo(double theResult)
        {
            this.theResult = theResult;
        }

    }
}
