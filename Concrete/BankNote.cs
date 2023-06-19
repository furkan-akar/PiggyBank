using PiggyBank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Concrete
{
    public class BankNote : Money, IFoldable
    {
        public BankNote(string name, float value, string unit, float height, float length, float width) : base(name, value, unit, height)
        {
            _length = length;
            _width = width;
        }

        public BankNote(string name, float value, string unit, float length, float width) : base(name, value, unit, 0.25f)// default value of banknote height 0.25 mm
        {
            _length = length;
            _width = width;
        }
        
        private float _length;
        private float _width;

        public float Length { get => _length; }
        public float Width { get => _width; }
        public bool IsFolded { get; set; } = false;
        public override float Volume { get => Width * Length * Height; }                      

        public void Fold()
        {
            _width *= 0.25f;
            _height *= 4;
            IsFolded = true;
        }               
    }
}
