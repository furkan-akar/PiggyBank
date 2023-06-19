using PiggyBank.Abstract;
using PiggyBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Concrete
{
    public class MoneyBox
    {
        public MoneyBox(float maxVolume)
        {
            _maxVolume = maxVolume;
        }

        #region Fields
        private List<Money> _moneys = new List<Money>();
        private byte _pastingCount = 0;
        private float _maxVolume;       
        #endregion Fields


        #region Properties
        public float MaxVolume { get => _maxVolume; }
        public float AdditionalVolume
        {
            get
            {
                float totalAdditionalVolume = 0;
                foreach (Money money in _moneys)
                {
                    if (money.IsShaked)
                    {
                        totalAdditionalVolume += money.MinAdditionalVolume;
                    }
                    else
                    {
                        totalAdditionalVolume += money.AdditionalVolume;
                    }
                    
                }
                return totalAdditionalVolume;
            }
        }
        public float MoneysVolume { get
            {
                float totalVolume = 0;
                foreach (Money money in _moneys)
                {
                    if (money.IsShaked)
                    {
                        totalVolume = totalVolume + money.Volume + money.MinAdditionalVolume;
                    }
                    else
                    {
                        totalVolume = totalVolume + money.Volume + money.AdditionalVolume;
                    }                    
                }
                return totalVolume;
            } }
        public double Balance
        {
            get
            {
                double totalValue = 0;
                foreach (Money money in _moneys)
                {
                    totalValue += money.Value;
                }
                return totalValue;
            }
        }
        #endregion Properties


        #region Methods
        public void Add(Money money)
        {
            if(money is BankNote && !((money as BankNote).IsFolded))
            {
                throw new NotFoldedException();
            }
            if (MoneysVolume + money.Volume <= MaxVolume)
            {               
                _moneys.Add(money);
                if (money is BankNote) (money as BankNote).IsFolded = false;
            }
            else
            {
                throw new MoneyBoxOverFlowException();
            }
        }

        public List<Money> Break()
        {
            return _moneys;
        }

        public void Paste()
        {
            if (_pastingCount < 1)
            {
                _moneys.Clear();
                _pastingCount++;
            }
            else
            {
                throw new SecondPasteException();
            }
        }

        public void Shake()
        {
            foreach (Money money in _moneys)
            {
                money.IsShaked = true;
            }
        }
        #endregion Methods
    }
}
