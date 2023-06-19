using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank.Utilities
{
    internal static class UIMethods
    {
        internal static void DisableMoneys(GroupBox grp, Button selectedMoney)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is Button)
                {
                    if (item != selectedMoney)
                    {
                        item.Enabled = false;
                    }
                }
            }
        }

        internal static void EnableMoneys(GroupBox grp)
        {
            foreach (Control item in grp.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
        }        
    }
}
