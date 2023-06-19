using PiggyBank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Concrete
{
    public class Coin : Money
    {        
        public Coin(string name, float value, string unit, float height, float radius): base(name, value, unit, height)
        {
            Radius = radius;            
        }

        private const float PI = 3.14f;

        public float Radius { get; }

        public override float Volume { get => PI * Radius * Radius * Height; }        
    }
}
