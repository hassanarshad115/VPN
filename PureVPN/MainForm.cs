using PureVPN.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureVPN
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static void OpenControl(MainForm mainForm, Control newControl)
        {
            mainForm.pnlContainer.Controls.Clear();
            newControl.Size = mainForm.pnlContainer.Size;
            mainForm.pnlContainer.Controls.Add(newControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenControl(this, new LoginControl(this));
        }
    }
}
