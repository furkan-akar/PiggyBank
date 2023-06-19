using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exceptions
{
    public class NotFoldedException : Exception
    {
        public override string Message => "Banknot katlanmadı. Lütfen parayı katlayanız!";
    }
}
