using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exceptions
{
    public class MoneyBoxOverFlowException : Exception
    {
        public override string Message => "Kumbara doldu daha fazla para atamazsınız. Lütfen Kumbarayı sallayınız.";
    }
}
