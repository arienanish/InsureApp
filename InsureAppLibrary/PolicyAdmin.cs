using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsureAppLibrary
{
    public class PolicyAdmin
    {
        public string Product { get; set; }
        public string FirstBen { get; set; }
        public string SecondBen { get; set; }
        public string ThirdBen { get; set; }
        public int FirstSumAssured { get; set; }
        public int SecondSumAssured { get; set; }
        public int ThirdSumAssured { get; set; }
        public double FirstRate { get; set; }
        public double SecondRate { get; set; }
        public double ThirdRate { get; set; }

    }
}
