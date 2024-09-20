using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage();
        }
        static void DisplayMessage()
        {
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
