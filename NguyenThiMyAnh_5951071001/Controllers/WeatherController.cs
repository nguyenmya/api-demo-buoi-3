using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NguyenThiMyAnh_5951071001.Models;

namespace NguyenThiMyAnh_5951071001.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherList = new List<WeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                var weatherInfo = new WeatherInfo
                {
                    Location = $"location {i}",
                    Degree = i * 23 / 27,
                    DateTime = DateTime.Now.ToUniversalTime()
                };
                weatherList.Add(weatherInfo);
            }
            return weatherList;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo
            {
                Location = $"location {id}",
                Degree = id * 23 / 27,
                DateTime = DateTime.Now.ToUniversalTime()
            };
        }


        // POST: api/Weather
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Weather/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Weather/5
        public void Delete(int id)
        {
        }
    }
}
