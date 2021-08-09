using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LangPadData
{
    public interface ITimer
    {
        public double Interval { get; set; }     
        public void Start();
        public void Stop();

        public event EventHandler<EventArgs> Elapsed;
    }
}
