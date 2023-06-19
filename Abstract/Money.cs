using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Abstract
{
    public abstract class Money
    {
        public Money(string name, float value, string unit, float height)
        {
            _name = name;
            _value = value;
            _unit = unit;
            _height = height;
        }

        private string _name;
        private float _value;
        private string _unit;
        private float _additionalVolume;
        protected float _height;
        private readonly Random _random = new Random();

        public string Name { get => _name; }
        public float Value { get => _value; }
        public string Unit { get => _unit; }
        public float Height { get => _height; }
        public abstract float Volume { get; }
        public bool IsShaked { get; set; } = false;
        public float AdditionalVolume { get => _additionalVolume; }
        public float MinAdditionalVolume { get => Volume * 0.25f; }
        public float TotalVolume
        {
            get
            {
                if (IsShaked)
                {
                    return Volume + MinAdditionalVolume;
                }
                else
                {
                    return Volume + AdditionalVolume;
                }
            }
        }
        
        public void CreateAdditionalVolume()
        {
            _additionalVolume = Volume * _random.Next(25, 76) / 100;
        }
    }
}
