using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Concrete
{
    internal class MoneyObjects
    {        
        private BankNote _200TL;
        private BankNote _100TL;
        private BankNote _50TL;
        private BankNote _20TL;
        private BankNote _10TL;
        private BankNote _5TL;

        private Coin _1TL;
        private Coin _50Krs;
        private Coin _25Krs;
        private Coin _10Krs;
        private Coin _5Krs;
        private Coin _1Krs;

        internal BankNote Get200Lira()
        {
            if (_200TL == null)
            {
                _200TL = new BankNote("İki Yüz Lira", 200, "TL", 160, 72);
            }
            return _200TL;
        }

        internal BankNote Get100Lira()
        {
            if (_100TL == null)
            {
                _100TL = new BankNote("Yüz Lira", 100, "TL", 154, 72);
            }
            return _100TL;
        }
        
        internal BankNote Get50Lira()
        {
            if (_50TL == null)
            {
                _50TL = new BankNote("Elli Lira", 50, "TL", 148, 68);
            }
            return _50TL;
        } 
        
        internal BankNote Get20Lira()
        {
            if (_20TL == null)
            {
                _20TL = new BankNote("Yirmi Lira", 20, "TL", 142, 68);
            }
            return _20TL;
        } 

        internal BankNote Get10Lira()
        {
            if (_10TL == null)
            {
                _10TL = new BankNote("On Lira", 10, "TL", 136, 64);
            }
            return _10TL;
        } 

        internal BankNote Get5Lira()
        {
            if (_5TL == null)
            {
                _5TL = new BankNote("Beş Lira", 5, "TL", 130, 64);
            }
            return _5TL;
        }

        internal Coin Get1Lira()
        {
            if (_1TL == null)
            {
                _1TL = new Coin("Bir Lira", 1, "TL", 1.67f, 26.15f / 2);
            }
            return _1TL;
        }

        internal Coin Get50Kurus()
        {
            if (_50Krs == null)
            {
                _50Krs = new Coin("Elli Kuruş", 0.50f, "TL", 1.9f, 23.85f / 2);
            }
            return _50Krs;
        }
        
        internal Coin Get25Kurus()
        {
            if (_25Krs == null)
            {
                _25Krs = new Coin("Yirmi Beş Kuruş", 0.25f, "TL", 1.65f, 20.5f / 2);
            }
            return _25Krs;
        }

        internal Coin Get10Kurus()
        {
            if (_10Krs == null)
            {
                _10Krs = new Coin("On Kuruş", 0.10f, "TL", 1.65f, 18.5f / 2);
            }
            return _10Krs;
        }
        
        internal Coin Get5Kurus()
        {
            if (_5Krs == null)
            {
                _5Krs = new Coin("Beş Kuruş", 0.05f, "TL", 1.65f, 17.5f / 2);
            }
            return _5Krs;
        }

        internal Coin Get1Kurus()
        {
            if (_1Krs == null)
            {
                _1Krs = new Coin("Bir Kuruş", 0.01f, "TL", 16.5f, 1.35f / 2);
            }
            return _1Krs;
        }
    }
}
