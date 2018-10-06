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
    public partial class MainForm : Form
    {
        public static Form MainFormInstance { get; set; }

        public MainForm()
        {
            InitializeComponent();

            Visible = false;

            OpenForm(new LoginForm());
        }

        public static void OpenForm(Form form)
        {
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Environment.Exit(0);
            }
        }
    }
}
