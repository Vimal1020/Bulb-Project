using BulbModel.Bulb;
using BulbService.Interface;

namespace BulbService.Service
{
    public class BulbSimulator : IBulbSimulator
    {
        public List<Bulb> Simulate(int numBulbs)
        {
            var bulbs = new List<Bulb>(numBulbs);

            for (int i = 0; i < numBulbs; i++)
            {
                bulbs.Add(new Bulb());
            }

            for (int person = 1; person <= numBulbs; person++)
            {
                for (int bulbIndex = person - 1; bulbIndex < numBulbs; bulbIndex += person)
                {
                    bulbs[bulbIndex].Toggle();
                }
            }

            return bulbs;
        }
    }
}