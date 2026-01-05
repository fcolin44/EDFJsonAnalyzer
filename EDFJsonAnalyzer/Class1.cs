using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDFJsonAnalyzer
{
    public class Consumption
    {
        public Period Period { get; set; }
        public EnergyMeter EnergyMeter { get; set; }
        public Cost Cost { get; set; }
        public double Quality { get; set; }
        public List<string> ErrorFlags { get; set; }
        public List<string> IndexNatures { get; set; }
        public string Status { get; set; }
        public string Nature { get; set; }
        public bool Aggregated { get; set; }
        public bool UsingLoadCurve { get; set; }
    }

    public class Period
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class EnergyMeter
    {
        public double Total { get; set; }
        public Dictionary<string, double> ByTariffHeading { get; set; }
    }

    public class Cost
    {
        public double Total { get; set; }
        public double StandingCharge { get; set; }
        public Dictionary<string, double> StandingChargeByComponents { get; set; }
        public Dictionary<string, double> ByTariffHeading { get; set; }
    }

    public class GlobalConsumption
    {
        public Period Period { get; set; }
        public EnergyMeter EnergyMeter { get; set; }
        public Cost Cost { get; set; }
        public double Quality { get; set; }
        public List<string> ErrorFlags { get; set; }
        public List<string> IndexNatures { get; set; }
        public string Status { get; set; }
        public string Nature { get; set; }
        public bool Aggregated { get; set; }
        public bool UsingLoadCurve { get; set; }
    }

    public class ConsumptionData
    {
        public Period Period { get; set; }
        public string Step { get; set; }
        public Units Units { get; set; }
        public List<Consumption> Consumptions { get; set; }
        public GlobalConsumption GlobalConsumption { get; set; }
    }

    public class Units
    {
        public string Cost { get; set; }
        public string EnergyMeter { get; set; }
    }
}
