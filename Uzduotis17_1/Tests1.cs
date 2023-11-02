using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis17_1
{
    public class Tests1
    {
        [Test]

        public void IsTodayWednesday()
        {
            
            DayOfWeek currentDayOfWeek = DateTime.Now.DayOfWeek;

            Assert.AreEqual(DayOfWeek.Wednesday, currentDayOfWeek, "Today is not Wednesday.");
        }
    }


    }

