using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApisDotNet8
{
    public class TimeOfDayService
    {
        private readonly TimeProvider _provider;
        public TimeOfDayService(TimeProvider provider)
        {
            _provider = provider;   
        }
        public string GetTimeOfDay()
        {
           // var currentTime = DateTime.Now;
           var currentTime = _provider.GetLocalNow();

            return currentTime.Hour switch
            {
                <= 6 => "Night",
                > 6 and <= 12 => "Morning",
                > 12 and <= 18 => "Afternoon",
                > 18 and <= 24 => "Evening",
                _ => "Invalid hour"
            };
        }
    }
}
