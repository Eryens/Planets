using Microsoft.AspNetCore.Mvc;
using Planets.DAL;
using Planets.Models.AbstractClasses;
using System.Numerics;

namespace Planets.Controllers.Api
{
    [Route("api/planet")]
    public class InterstarPlanetController : ControllerBase
    {
        // GET: /api/planet
        public List<InterstarPlanet> Get()
        {
            return MockData.GetSolarSystemPlanets() ;
        }

        // GET: /api/planet/earth
        public InterstarPlanet Get(string name)
        {
            return MockData.GetSolarSystemPlanets().First(c => c.Name == name);
        }

        // Note: All functions below will not work due to the limitation of using a simple list mock as a data layer
        // However, it provides the blueprint to implement with a real data provider such as SQL Server

        // POST: /api/planet
        [HttpPost]
        public InterstarPlanet Post(InterstarPlanet planet)
        {
            MockData.GetSolarSystemPlanets().Add(planet);
            return planet;
        }

        // PUT: /api/planet
        [HttpPut] 
        public List<InterstarPlanet> Put(List<InterstarPlanet> planets)
        {
            List<InterstarPlanet> updated = new List<InterstarPlanet>();
            foreach(var planet in planets)
            {
                InterstarPlanet? contextPlanet = Get(planet.Name);
                if (contextPlanet == null)
                {
                    continue;
                }
                contextPlanet = planet;
                updated.Add(contextPlanet);
            }

            return updated;
        }

        // PUT: /api/planet/earth
        [HttpPut]
        public bool Put(InterstarPlanet planet)
        {
            InterstarPlanet? contextPlanet = Get(planet.Name);
            if (contextPlanet == null)
            {
                return false;
            }
            contextPlanet = planet;
            return true;
        }

        // DELETE: /api/planet
        [HttpDelete]
        public void Delete()
        {
            List<InterstarPlanet> list = MockData.GetSolarSystemPlanets();
            list = new List<InterstarPlanet>();
        }

        // DELETE: /api/planet/earth
        [HttpDelete]
        public void Delete(string name)
        {
            List<InterstarPlanet> list = MockData.GetSolarSystemPlanets();
            InterstarPlanet? planet = Get(name);
            list.Remove(planet);
        }

    }
}
