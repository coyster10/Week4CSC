using System;
using Microsoft.AspNetCore.Mvc;

namespace Week_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Week_3 : ControllerBase
    {

        [HttpPost(Name = "Testing API")]
        public ActionResult<List<hi>> Post([FromBody] List<hi> input)
        {
            foreach(hi i in input)
            {
                LogObject(i);
            }
            

            return input;
        }

        void LogObject(hi num)
        {
            System.Diagnostics.Debug.WriteLine(num.name);
            System.Diagnostics.Debug.WriteLine(num.favoriteLetter);
            System.Diagnostics.Debug.WriteLine(num.color);
        }

        static double standardDeviation(int count, double sum, double mean, int num)
        {
            double result = 0;

            result = Math.Pow(num - mean, 2);

            return Math.Sqrt(result / count);
        }
    }

    public class hi
    {
        public string name { get; set; }
        public string favoriteLetter { get; set; }
        public string color { get; set; }
    }
}