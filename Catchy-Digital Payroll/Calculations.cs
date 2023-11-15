using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catchy_Digital_Payroll
{
    internal class Calculations
    {
        private double rate;
        private double hours;
        private double overtime;

        public double propRate
        {
            get { return rate; }
            set { rate = value; }
        }
        public double propHours
        {
            get { return hours; }
            set { hours = value; }
        }
        public double propOvertime
        {
            get { return overtime; }
            set { overtime = value; }
        }
        public Calculations()
        {
            propRate = 0;
            propHours = 0;
            propOvertime = 0;
        }
        public Calculations(double rate, double hours, double overtime)
        {
            propRate = rate;
            propHours = hours;
            propOvertime = overtime;
        }
        public double GrossPay()
        {
            return (propHours * propRate) + (propRate * 1.5) * propOvertime;
        }
        public double IncomeTax()
        {
            return GrossPay() * 0.15;
        }
        public double UIF()
        {
            return 0.05 * GrossPay();
        }
        public double Pension()
        {
            if (GrossPay() > 5000)
            {
                return 560;
            }
            else
            {
                return 350;
            }
        }
        public double MedicalAid()
        {
            if (GrossPay() > 5000)
            {
                return 150;
            }
            else
            {
                return 65;
            }
        }
        public double TotalDeducions()
        {
            return IncomeTax() + Pension() + MedicalAid() + UIF();
        }
        public double NetPay()
        {
            return GrossPay() - TotalDeducions();
        }
    }
}
