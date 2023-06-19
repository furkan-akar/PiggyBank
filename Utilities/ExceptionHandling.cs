using PiggyBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank.Utilities
{
    public class ExceptionHandling
    {
        public static bool HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (NotFoldedException exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            catch (MoneyBoxOverFlowException exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            catch (SecondPasteException exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
