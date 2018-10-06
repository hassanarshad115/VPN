using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureVPN
{
    public class InformationClass
    {
        //For LogOut 
        public static void LogOutMessage()
        {
            MessageBox.Show("You will nno longer be able to Access PureVFN services.", "Are you sure you want to log out? ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        public static void LogOutMessageWithTitleIcon(string Title, MessageBoxIcon MIcon)
        {
            MessageBox.Show("You will nno longer be able to Access PureVFN services.", Title, MessageBoxButtons.YesNo, MIcon);
        }
        public static void LogOutMessageWithTitleBtnIcon(string Title, MessageBoxButtons MBBtn, MessageBoxIcon MIcon)
        {
            MessageBox.Show("You will nno longer be able to Access PureVFN services.", Title, MBBtn, MIcon);
        }
        public static void LogOutMessageWithMessageTitleBtnIcon(string Message, string Title, MessageBoxButtons MBBtn, MessageBoxIcon MIcon)
        {
            MessageBox.Show(Message, Title, MBBtn, MIcon);
        }

          


    }
}
