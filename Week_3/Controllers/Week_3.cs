using System;
using Microsoft.AspNetCore.Mvc;

namespace Week_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Week_3 : ControllerBase
    {

        [HttpPost(Name = "GetWeatherForecast")]
        public ActionResult<List<string>> IntListWork(List<int> intList)
        {
            List<string> strList = new List<string>();

            double sum = 0;
            int counter = 0;
            double mean = 0;
            double SD = 0;

            intList.Sort();

            foreach(int i in intList)
            {
                counter ++;

                sum += i;
                mean = sum / counter;
                SD = standardDeviation(counter, sum, mean, i);

                strList.Add("Entered number " + counter + ": " + i + " | Standard Deviation is " + SD);
            }

            return strList;
        }

        static double standardDeviation(int count, double sum, double mean, int num)
        {
            double result = 0;

            result = Math.Pow(num - mean, 2);

            return Math.Sqrt(result / count);
        }
    }
}