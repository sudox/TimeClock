using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Clock
{
    class TimeSheet
    {
        private String user;
        private List<String> clocks;
        private enum Punch { IN, OUT };
        private Punch nextpunch;

        public TimeSheet()
        {
            user = "";
            clocks = new List<String>();
            nextpunch = Punch.IN;
        }

        public void setUser(string uname)
        {
            user = uname;
        }

        public void punch(string time)
        {
            clocks.Add(time + " " + nextpunch);
            if (nextpunch == Punch.IN)
                nextpunch = Punch.OUT;
            else
                nextpunch = Punch.IN;
        }

        public string checkCard(string uname)
        {
            if (clocks.Count == 0)
                return "No clocks for " + uname;

            string output = uname + ":\n";
            foreach (string s in clocks)
            {
                output += s;
                output += "\n";
            }
            output += "Total hours: ";

            return output;
        }

        public string punchType()
        {
            if (nextpunch == Punch.IN)
                return "in";
            else
                return "out";
        }
    }
}
