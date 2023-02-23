using System;
namespace facade
{
	public class Trm
	{

        private Random random = new Random();
        private double minValue = 3.000;
        private double maxValue = 5.000;

        public decimal GetTrm()
		{
            decimal apiResp = (decimal)ApiCallTrm();
            return apiResp;
        }

        private double ApiCallTrm()
        {
            var next = random.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }
    }
}

