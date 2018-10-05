using Atom.SDK.Net;
using Atom.SDK.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureVPN
{
    public class MainSettings
    {
        public static AtomManager AtomManagerInstance { get; private set; }

        public static void ConfitureSystem(string userName, string password)
        {
            AtomManagerInstance = AtomManager.Initialize("b12e0405d803ba771c46bb94be29a0a59f976b06");

            AtomManagerInstance.Connected += AtomManagerInstance_Connected;
            AtomManagerInstance.DialError += AtomManagerInstance_DialError;
            AtomManagerInstance.Disconnected += AtomManagerInstance_Disconnected;
            AtomManagerInstance.StateChanged += AtomManagerInstance_StateChanged;
            AtomManagerInstance.Redialing += AtomManagerInstance_Redialing;

            VPNProperties vpnProperties = new VPNProperties(AtomManagerInstance.GetCountries()[0], AtomManagerInstance.GetProtocols()[0]);
            MainSettings.AtomManagerInstance.Credentials = new Credentials(userName, password);
            MainSettings.AtomManagerInstance.Connect(vpnProperties);
        }

        private static void AtomManagerInstance_Connected(object sender, EventArgs e)
        {
            MessageBox.Show("Connected");
        }

        private static void AtomManagerInstance_DialError(object sender, DialErrorEventArgs e)
        {

        }

        private static void AtomManagerInstance_Disconnected(object sender, DisconnectedEventArgs e)
        {

        }

        private static void AtomManagerInstance_StateChanged(object sender, StateChangedEventArgs e)
        {
            MessageBox.Show("Disconnected");
        }

        private static void AtomManagerInstance_Redialing(object sender, ErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        public static void OpenForm(Form currentForm, Form newForm)
        {
            newForm.FormClosed += (sender, e) => { currentForm.Show(); };
            currentForm.Hide();
            newForm.Show();
        }
        
    }
}
