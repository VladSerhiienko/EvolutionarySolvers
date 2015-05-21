using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labworks.ExcelAddin
{
    public class TaskLW4Description
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double XMin { get; set; }
        public double XMax { get; set; }
        public double CrossoverProbability { get; set; }
        public double MutateProbability { get; set; }
        public double ElitismPercentage { get; set; }
        public string TargetType { get; set; }
        public string CrossoverType { get; set; }
        public string SelectionType { get; set; }

    }
}
