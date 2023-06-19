using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exceptions
{
    public class SecondPasteException: Exception
    {
        public override string Message => "Kumbara ikinci kere yapıştırılamaz!";
    }
}
