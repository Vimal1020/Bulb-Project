using BulbModel.Bulb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulbService.Interface
{
    internal interface IBulbSimulator
    {
        public List<Bulb> Simulate(int numBulbs);
    }
}
