using Hassan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PureVPN
{
    
    public partial class preference : MaterialSkin.Controls.MaterialForm
    {
        public preference()
        {

            InitializeComponent();
            profilePnl.Visible = true;
            flowOption.Visible = false;
            pnlTunneling.Visible = false;
            appSetting.Visible = false;

        }
        public string emailp { get; set; }
        public string passwordP { get; set; }
        private void preference_Load(object sender, EventArgs e)
        {
            Country.Items.Add("English");
            Country.Items.Add("Italian");
            Country.Items.Add("Turkish");
            Country.Items.Add("Dutch");
            Country.Items.Add("German");
            Country.Items.Add("French");
            Country.Items.Add("Arabic");
            Country.Items.Add("Chinese");
            Country.Items.Add("Spanish");
            Country.SelectedIndex = 0;
            profilePnl.Visible = true;
            flowOption.Visible = false;
            pnlTunneling.Visible = false;
            appSetting.Visible = false;

            if (profilePnl.Visible == true)
            {
                btnProfile.BackColor = Color.Green;
                btnProfile.ForeColor = Color.White;
                txtName.Text = emailp;
                txtPass.Text = passwordP;
            }

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            flowOption.Visible = false;
            pnlTunneling.Visible = false;
            appSetting.Visible = false;
            profilePnl.Visible = true;
            if (profilePnl.Visible == true)
            {
                btnProfile.BackColor = Color.Green;
                btnProfile.ForeColor = Color.White;
                btnAppSetting.BackColor = Color.White;
                btnAppSetting.ForeColor = Color.Black;
                btnSplits.BackColor = Color.White;
                btnSplits.ForeColor = Color.Black;
                btnCheckUpdate.BackColor = Color.White;
                btnCheckUpdate.ForeColor = Color.Black;
                btnLogOut.BackColor = Color.White;
                btnLogOut.ForeColor = Color.Black;

            }
        }

        private void btnAppSetting_Click(object sender, EventArgs e)
        {
            flowOption.Visible = false;
            profilePnl.Visible = false;
            pnlTunneling.Visible = false;

            appSetting.Visible = true;
            if (appSetting.Visible == true)
            {
               
                btnAppSetting.BackColor = Color.Green;
                btnAppSetting.ForeColor = Color.White;
                btnProfile.BackColor = Color.White;
                btnProfile.ForeColor = Color.Black;
                btnSplits.BackColor = Color.White;
                btnSplits.ForeColor = Color.Black;
                btnCheckUpdate.BackColor = Color.White;
                btnCheckUpdate.ForeColor = Color.Black;
                btnLogOut.BackColor = Color.White;
                btnLogOut.ForeColor = Color.Black;
            }
        }

        private void btnSelectMode_Click(object sender, EventArgs e)
        {
            selectMode pr = new selectMode();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
            btnAppSetting.BackColor = Color.White;
            btnAppSetting.ForeColor = Color.Black;
            btnProfile.BackColor = Color.White;
            btnProfile.ForeColor = Color.Black;
            btnSelectMode.BackColor = Color.Green;
            btnSelectMode.ForeColor = Color.White;
            btnCheckUpdate.BackColor = Color.White;
            btnCheckUpdate.ForeColor = Color.Black;
            btnLogOut.BackColor = Color.White;
            btnLogOut.ForeColor = Color.Black;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Login pr = new Login();
            if (pr == null)
            {
                pr.Parent = this;
            }
            pr.Show();
            this.Hide();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

            flowOption.Visible = true;
            pnlTunneling.Visible = false;
            pnlport.Visible = false;
            pInternet.Visible = false;
            pSecurity.Visible = false;
            if (flowOption.Visible == true)
            {
                btnOptions.BackColor = Color.Green;
                btnOptions.ForeColor = Color.White;
                btnAppSetting.BackColor = Color.White;
                btnAppSetting.ForeColor = Color.Black;
                btnProfile.BackColor = Color.White;
                btnProfile.ForeColor = Color.Black;
                btnSelectMode.BackColor = Color.White;
                btnSelectMode.ForeColor = Color.Black;
                btnSplits.BackColor = Color.White;
                btnSplits.ForeColor = Color.Black;
                btnLogOut.BackColor = Color.White;
                btnLogOut.ForeColor = Color.Black;
                btnCheckUpdate.BackColor = Color.White;
                btnCheckUpdate.ForeColor = Color.Black;
            }
        }
        private void pnlSecurity_Click(object sender, EventArgs e)
        {
            pSecurity.Visible = true;
            pInternet.Visible = false;
        }

        private void pnlInterNet_Click(object sender, EventArgs e)
        {
            pSecurity.Visible = false;
            pInternet.Visible = true;
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            pSecurity.Visible = false;
            pInternet.Visible = true;
            pnlport.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pnlport.Visible = true;
            pSecurity.Visible = false;
            pInternet.Visible = false;

        }

        private void pic1_Click_1(object sender, EventArgs e)
        {
            pSecurity.Visible = true;
            pInternet.Visible = false;
            pnlport.Visible = false;
        }

        private void btnSplits_Click(object sender, EventArgs e)
        {
            pnlTunneling.Visible = true;
            flowOption.Visible = false;
            pnlport.Visible = false;
            pInternet.Visible = false;
            pSecurity.Visible = false;
            profilePnl.Visible = false;
            appSetting.Visible = false;


            if (pnlTunneling.Visible == true)
            {
                btnSplits.BackColor = Color.Green;
                btnSplits.ForeColor = Color.White;
                btnAppSetting.BackColor = Color.White;
                btnAppSetting.ForeColor = Color.Black;
                btnProfile.BackColor = Color.White;
                btnProfile.ForeColor = Color.Black;
                btnSelectMode.BackColor = Color.White;
                btnSelectMode.ForeColor = Color.Black;
                btnOptions.BackColor = Color.White;
                btnOptions.ForeColor = Color.Black;
                btnLogOut.BackColor = Color.White;
                btnLogOut.ForeColor = Color.Black;
                btnCheckUpdate.BackColor = Color.White;
                btnCheckUpdate.ForeColor = Color.Black;
            }
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {

            Update popup = new Update();
            popup.Show();
            if (popup.Visible == true)
            {
                btnSplits.BackColor = Color.White;
                btnSplits.ForeColor = Color.Black;
                btnAppSetting.BackColor = Color.White;
                btnAppSetting.ForeColor = Color.Black;
                btnProfile.BackColor = Color.White;
                btnProfile.ForeColor = Color.Black;
                btnSelectMode.BackColor = Color.White;
                btnSelectMode.ForeColor = Color.Black;
                btnOptions.BackColor = Color.White;
                btnOptions.ForeColor = Color.Black;
                btnLogOut.BackColor = Color.White;
                btnLogOut.ForeColor = Color.Black;
                btnCheckUpdate.BackColor = Color.Green;
                btnCheckUpdate.ForeColor = Color.White;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOutBox logout = new LogOutBox();
            logout.Show();
            if (logout.Visible == true)
            {
                btnSplits.BackColor = Color.White;
                btnSplits.ForeColor = Color.Black;
                btnAppSetting.BackColor = Color.White;
                btnAppSetting.ForeColor = Color.Black;
                btnProfile.BackColor = Color.White;
                btnProfile.ForeColor = Color.Black;
                btnSelectMode.BackColor = Color.White;
                btnSelectMode.ForeColor = Color.Black;
                btnOptions.BackColor = Color.White;
                btnOptions.ForeColor = Color.Black;
                btnCheckUpdate.BackColor = Color.White;
                btnCheckUpdate.ForeColor = Color.Black;
                btnLogOut.BackColor = Color.Green;
                btnLogOut.ForeColor = Color.White;
            }
        }

        private void showHide_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VPN"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Users set uPassword='" + txtPass.Text + "' where uEmail='" + txtName.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            Information.InformationMessage("Your password is update successfully");
        }
 
            
        
        private void Country_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (Country.SelectedItem.ToString() =="English")
            {

                for (int i = 0; i < this.Controls.Count; i++)
                {
                    //this.Controls[i].;
                }

                america.Visible = true;
                Italian.Visible=false;
                Dutch.Visible = false;
                German.Visible = false;
                Turkish.Visible = false;
                French.Visible = false;
                Arabic.Visible = false;
                Chinese.Visible = false;
                Spanish.Visible = false;

            }
            else if (Country.SelectedItem.ToString()== "Italian")
            {
                //app settings
                checkBox14.Text = "Ricomposizione automatica se la connessione diminuisce";
                checkBox13.Text = "Avvia all'avvio del sistema";
                checkBox12.Text = "Connessione automatica dopo il lancio";
                disconnect.Text = "Disconnetti la VPN all'uscita dall'app";
                checkBox9.Text = "Avvia il browser predefinito dopo la connessione";
                checkBox7.Text = "Ping server all'avvio";
                label30.Text = "Protocollo selezionato";
                label29.Text = "Seleziona la lingua";
                lblBack.Text = "indietro";
                label26.Text = "Preferenza";
                btnProfile.Text = "Il tuo profilo";
                btnAppSetting.Text = "Impostazioni dell'app";
                btnSelectMode.Text = "Seleziona la modalità";
                btnOptions.Text = "Opzioni avanzate";
                btnSplits.Text = "Tunneling diviso";
                btnCheckUpdate.Text = "Controlla gli aggiornamenti";
                btnTickets.Text = "Biglietto di supporto";
                btnLogOut.Text = "Disconnettersi";
                label31.Text = "impostazione dell'app";
                //app settings

                //your profile
                label28.Text = "Informazioni di accesso";
                checkBox11.Text = "Mostra password";
                btnUpdate.Text = "aggiornare";
                //your profile
                //Split Tunneling
                label35.Text = "Tunneling diviso";
                checkBox16.Text = "Attiva tunneling diviso";
                label34.Text = "Quando split tunneling è abilitato solo per le app selezionate";
                label33.Text = "ti userà VPN IP. Tutte le altre app utilizzeranno il tuo reale";
                label32.Text = "IP(la tua posizione attuale).";
                checkBox15.Text = "Rendilo permanente";
                label27.Text = "Gestisci il tunnel diviso";
                //Split Tunneling
                //Advanced Options
                label1.Text = "Sicurezza";
                checkBox1.Text = "Abilita crittografia a 256 bit";
                checkBox2.Text = "Passa al sicuro DNS";
                label4.Text= "assegna un DNS sicuro, deseleziona questa casella in un secondo momento";
                label5.Text = "è necessario ripristinare le impostazioni";
                checkBox3.Text= "Protezione dalle perdite IPv6";
                label6.Text= "Blocca il traffico su Internet tramite IPv6 per la sicurezza delle batterie";
                checkBox4.Text = "Promemoria VPN non connessi";
                comboBox1.Text = "1 minuto";
                label7.Text = "Checking this box will alert you if not connected to VPN";
                label2.Text = "Internet kill Switch";
                checkBox8.Text = "Attiva ricerca uccisioni Internet";
                label10.Text= "Seleziona questa casella per uccidere tutte le tue attività su Internet se per";
                label9.Text = "qualunque motivo la tua VPN si disconnette.Per riavviare";
                label11.Text="Internet semplicemente deseleziona questa casella.";
                checkBox6.Text = "Ricomposizione automatica se la coassuzione VPN diminuisce";
                label8.Text= "Internet kill switch utenti Windows firewall da bloccare";
                label12.Text = "traffico Internet durante la ricomposizione. Si prega di assicurarsi che il proprio";
                label13.Text= "Windows Firewall non è monitorato da nessun firewall";
                checkBox5.Text= "Interrompere internet anche se disconnetto la VPN manualmente";
                label3.Text = "Multi Port";
                checkBox10.Text = "Attiva Multi Port";
                label19.Text= "Multiporta ai una selezione automatica della porta per cui viene eseguita la scansione";
                label18.Text= "aprire le porte da connettere per verificare se sono chiuse o limitate";
                label16.Text= "porte e seleziona le porte aperte disponibili per";
                label20.Text= "connettività.";
                label17.Text = "Change Protocol";
                radioButton1.Text= "Porta automatica";
                label15.Text = "Seleziona porta automaticamente.Selezione automatica della porta";
                label14.Text= "scansiona le porte aperte per bypassare il blocco delle porte e dare";
                label21.Text= "la porta migliore ottimizzata.";
                label22.Text= "Port range (5500 - 55000)";
                checkBox2.Text = "Manuale";
                label23.Text= "La selezione manuale della porta consente di inserire il desiderato";
                label24.Text = "porta.";
                label25.Text= "Port range (5500 - 55000)";
                //Advanced Options
                Italian.Visible = true;
                Dutch.Visible = false;
                German.Visible = false;
                Turkish.Visible = false;
                america.Visible = false;
                French.Visible = false;
                Arabic.Visible = false;
                Chinese.Visible = false;
                Spanish.Visible = false;
            }
            else
               if (Country.SelectedItem.ToString()== "Turkish")
            {
                //App Settings
                checkBox14.Text = "Bağlantı azaldığında otomatik tekrar arama";
                checkBox13.Text = "Sistem başlangıcında başlat";
                checkBox12.Text = "Lansmandan sonra otomatik bağlantı";
                disconnect.Text = "Uygulamanın çıkışında VPN bağlantısını kes";
                checkBox9.Text = "Bağlandıktan sonra varsayılan tarayıcıyı başlat";
                checkBox7.Text = "Ping sunucusu başlangıçta";
                label30.Text = "Seçilen protokol";
                label29.Text = "Dili seçin";
                lblBack.Text = "geri";
                label26.Text = "tercih";
                btnProfile.Text = "Senin profilin";
                btnAppSetting.Text = "Uygulama ayarları";
                btnSelectMode.Text = "Modu seçin";
                btnOptions.Text = "Gelişmiş seçenekler";
                btnSplits.Text = "Bölünmüş tünel";
                btnCheckUpdate.Text = "Güncellemeleri kontrol et";
                btnTickets.Text = "Destek bileti";
                btnLogOut.Text = "Log off";
                label31.Text = "uygulamanın ayarlanması";
                //app setttings

                //your profile
                label28.Text = "giriş bilgisi";
                checkBox11.Text = "Şifreyi göster";
                btnUpdate.Text = "güncelleştirme";
                //your profile
                //Split Tunneling
                label35.Text = "Bölünmüş tünel";
                checkBox16.Text = "Split tüneli etkinleştir";
                label34.Text = "Bölünmüş tünelleme yalnızca seçili uygulamalar etkinleştirildiğinde";
                label33.Text = "VPN IP kullanacak. Diğer tüm uygulamalar gerçeklerinizi kullanacaktır";
                label32.Text = "IP(Gerçek konumunuz).";
                checkBox15.Text = "Kalıcı yap";
                label27.Text = "Split Tüneli Yönetme";
                //Split Tunneling 
                //Advanced Options
                label1.Text = "";
                checkBox1.Text = "";
                checkBox2.Text = "";
                label4.Text = "";
                label5.Text = "";
                checkBox3.Text = "";
                label6.Text = "";
                checkBox4.Text = "";
                comboBox1.Text = "";
                label7.Text = "";
                label2.Text = "";
                checkBox8.Text = "";
                label10.Text = "";
                label9.Text = "";
                label11.Text = "";
                checkBox6.Text = "";
                label8.Text = "";
                label12.Text = "";
                label13.Text = "";
                checkBox5.Text = "";
                label3.Text = "";
                checkBox10.Text = "";
                label19.Text = "";
                label18.Text = "";
                label16.Text = "";
                label20.Text = "";
                label17.Text = "";
                radioButton1.Text = "";
                label15.Text = "";
                label14.Text = "";
                label21.Text = "";
                label22.Text = "";
                checkBox2.Text = "";
                label23.Text = "";
                label24.Text = "";
                label25.Text = "";
                //Advanced Options
                Turkish.Visible = true;
                German.Visible = false;
                Italian.Visible = false;
                Dutch.Visible = false;
                america.Visible = false;
                French.Visible = false;
                Arabic.Visible = false;
                Chinese.Visible = false;
                Spanish.Visible = false;

            }
            else
               if (Country.SelectedItem.ToString()== "Dutch")
            {
                //app settings
                checkBox14.Text = "Automatisch opnieuw kiezen bij een lage verbinding";
                checkBox13.Text = "Begin bij het opstarten van het systeem";
                checkBox12.Text = "Automatische verbinding na de lancering";
                disconnect.Text = "Ontkoppel VPN van de applicatie";
                checkBox9.Text = "Start standaardbrowser na het verbinden";
                checkBox7.Text = "Ping-server bij opstarten";
                label30.Text = "Geselecteerd protocol";
                label29.Text = "Selecteer taal";
                lblBack.Text = "terug";
                label26.Text = "voorkeur";
                btnProfile.Text = "Jouw profiel";
                btnAppSetting.Text = "Applicatie-instellingen";
                btnSelectMode.Text = "Selecteer modus";
                btnOptions.Text = "Geavanceerde opties";
                btnSplits.Text = "Tunnel splitsen";
                btnCheckUpdate.Text = "Controleer op updates";
                btnTickets.Text = "Ondersteuning ticket";
                btnLogOut.Text = "Uitloggen";
                label31.Text = "instellen van de applicatie";
                //app settings

                //your profile
                label28.Text = "login info";
                checkBox11.Text = "laat wachtwoord zien";
                btnUpdate.Text = "bijwerken";
                //your profile
                //Split Tunneling
                label35.Text = "Splitsen van tunnels";
                checkBox16.Text = "Activeer Split tunneling";
                label34.Text = "Wanneer split tunneling alleen is ingeschakeld voor de geselecteerde apps";
                label33.Text = "zal je VPN IP gebruiken.Alle andere apps gebruiken uw werkelijke";
                label32.Text = "IP (uw werkelijke locatie).";
                checkBox15.Text = "Maak het permanent";
                label27.Text = "Beheer Split Tunnelling";
                //Split Tunneling 
                Dutch.Visible = true;
                German.Visible = false;
                Italian.Visible = false;
                america.Visible = false;
                Turkish.Visible = false;
                French.Visible = false;
                Arabic.Visible = false;
                Chinese.Visible = false;
                Spanish.Visible = false;
            }
            else
               if (Country.SelectedItem.ToString()== "German")
            {
                //app settings
                checkBox14.Text = "Automatische Wahlwiederholung bei niedriger Verbindung";
                checkBox13.Text = "Starten Sie beim Systemstart";
                checkBox12.Text = "Automatische Verbindung nach dem Start";
                disconnect.Text = "Trennen Sie VPN von der Anwendung";
                checkBox9.Text = "Starten Sie den Standardbrowser nach dem Verbinden";
                checkBox7.Text = "Ping-Server beim Start";
                label30.Text = "Ausgewähltes Protokoll";
                label29.Text = "Wählen Sie eine Sprache";
                lblBack.Text = "zurück";
                label26.Text = "Präferenz";
                btnProfile.Text = "Dein Profil";
                btnAppSetting.Text = "Anwendungseinstellungen";
                btnSelectMode.Text = "Wählen Sie den Modus";
                btnOptions.Text = "Erweiterte Optionen";
                btnSplits.Text = "Einen Tunnel teilen";
                btnCheckUpdate.Text = "Nach Updates suchen";
                btnTickets.Text = "Supportticket";
                btnLogOut.Text = "Abmelden";
                label31.Text = "Einrichten der Anwendung";
                //app settings
                //your profile
                label28.Text = "Anmeldeinformationen";
                checkBox11.Text = "Passwort anzeigen";
                btnUpdate.Text = "aktualisieren";
                //your profile
                //Split Tunneling
                label35.Text = "Split - Tunneling";
                checkBox16.Text = "Activate Split tunneling";
                label34.Text = "Beim Split-Tunneling werden nur die ausgewählten Apps aktiviert";
                label33.Text = "werde dich VPN IP benutzen. Alle anderen Apps verwenden Ihre tatsächlichen";
                label32.Text = "IP(Ihr tatsächlicher Standort).";
                checkBox15.Text = "Mach es dauerhaft";
                label27.Text = "Split - Tunneling verwalten";
                //Split Tunneling 
                German.Visible = true;
                Italian.Visible = false;
                Dutch.Visible = false;
                america.Visible = false;
                Turkish.Visible = false;
                French.Visible = false;
                Arabic.Visible = false;
                Chinese.Visible = false;
                Spanish.Visible = false;
            }
            else
                if (Country.SelectedItem.ToString()== "French")
            {
                //app settings
                checkBox14.Text = "Rappel automatique sur connexion basse";
                checkBox13.Text = "Commencer au démarrage du système";
                checkBox12.Text = "Connexion automatique après le démarrage";
                disconnect.Text = "Déconnectez le VPN de l'application";
                checkBox9.Text = "Démarrer le navigateur par défaut après la connexion";
                checkBox7.Text = "Serveur Ping au démarrage";
                label30.Text = "Protocole sélectionné";
                label29.Text = "Choisissez une langue";
                lblBack.Text = "dos";
                label26.Text = "préférence";
                btnProfile.Text = "Votre profil";
                btnAppSetting.Text = "paramètres d'application";
                btnSelectMode.Text = "Sélectionnez le mode";
                btnOptions.Text = "Options avancées";
                btnSplits.Text = "Partager un tunnel";
                btnCheckUpdate.Text = "Rechercher des mises à jour";
                btnTickets.Text = "ticket de support";
                btnLogOut.Text = "déconnecter";
                label31.Text = "Configuration de l'application";
                //app settings

                //your profile
                label28.Text = "info de connexion";
                checkBox11.Text = "montrer le mot de passe";
                btnUpdate.Text = "mettre à jour";
                //your profile
                //Split Tunneling
                label35.Text = "Split - Tunneling";
                checkBox16.Text = "Activate Split tunneling";
                label34.Text = "Beim Split-Tunneling werden nur die ausgewählten Apps aktiviert";
                label33.Text = "werde dich VPN IP benutzen. Alle anderen Apps verwenden Ihre tatsächlichen";
                label32.Text = "IP(Ihr tatsächlicher Standort).";
                checkBox15.Text = "Mach es dauerhaft";
                label27.Text = "Split - Tunneling verwalten";
                //Split Tunneling 
                French.Visible = true;
                German.Visible = false;
                Italian.Visible = false;
                Dutch.Visible = false;
                america.Visible = false;
                Turkish.Visible = false;
                Arabic.Visible = false;
                Chinese.Visible = false;
                Spanish.Visible = false;
            }
            else
                if (Country.SelectedItem.ToString()== "Arabic")
            {
                //app settings
                checkBox14.Text = "إعادة الطلب تلقائيًا إذا انخفض الاتصال";
                checkBox13.Text = "التشغيل عند بدء النظام";
                checkBox12.Text = "الاتصال التلقائي بعد الإطلاق";
                disconnect.Text = "اقطع اتصال VPN عند خروج التطبيق";
                checkBox9.Text = "قم بتشغيل المتصفح الافتراضي بعد الاتصال";
                checkBox7.Text = "خوادم بينغ عند بدء التشغيل";
                label30.Text = "البروتوكول المختار";
                label29.Text = "لغة مختارة";
                lblBack.Text = "الى الخلف";
                label26.Text = "تفضيل";
                btnProfile.Text = "ملفك الشخصي";
                btnAppSetting.Text = "إعدادات التطبيق";
                btnSelectMode.Text = "اختر الوضع";
                btnOptions.Text = "خيارات متقدمة";
                btnSplits.Text = "نفق الانقسام";
                btnCheckUpdate.Text = "التحقق من التحديثات";
                btnTickets.Text = "بطاقة الدعم";
                btnLogOut.Text = "الخروج";
                label31.Text = "إعدادات التطبيقات";
                //app settings

                //your profile
                label28.Text = "معلومات الدخول";
                checkBox11.Text = "عرض كلمة المرور";
                btnUpdate.Text = "تحديث";
                //your profile
                //Split Tunneling
                label35.Text = "نفق الانقسام";
                checkBox16.Text = "تنشيط انفاق الانقسام";
                label34.Text = "عندما يتم تمكين النفق المقسم فقط التطبيقات المحددة";
                label33.Text = "سوف تستخدم لك VPN IP. جميع التطبيقات الأخرى سوف تستخدم حسابك الفعلي";
                label32.Text = "IP (موقعك الفعلي).";
                checkBox15.Text = "اجعلها دائمة";
                label27.Text = "إدارة تقسيم النفث";
                //Split Tunneling 
                Arabic.Visible = true;
                French.Visible = false;
                German.Visible = false;
                Italian.Visible = false;
                Dutch.Visible = false;
                america.Visible = false;
                Turkish.Visible = false;
                Chinese.Visible = false;
                Spanish.Visible = false;
            }
            else
                if (Country.SelectedItem.ToString()== "Chinese")
            {
                //app settings
                checkBox14.Text = "如果连接断开，则自动重拨";
                checkBox13.Text = "启动系统启动";
                checkBox12.Text = "启动后自动连接";
                disconnect.Text = "在应用程序退出时断开VPN连接";
                checkBox9.Text =  "连接后启动默认浏览器";
                checkBox7.Text = "启动时Ping服务器";
                label30.Text = "选择协议";
                label29.Text = "选定的语言";
                lblBack.Text = "背部";
                label26.Text = "偏爱";
                btnProfile.Text = "你的个人资料";
                btnAppSetting.Text = "应用设置";
                btnSelectMode.Text = "选择模式";
                btnOptions.Text = "高级选项";
                btnSplits.Text = "分裂隧道";
                btnCheckUpdate.Text = "检查更新";
                btnTickets.Text = "支持票";
                btnLogOut.Text = "登出";
                label31.Text = "应用设置";
                //app settings
                //your profile
                label28.Text = "登录信息";
                checkBox11.Text = "显示密码";
                btnUpdate.Text = "更新";
                //your profile
                //Split Tunneling
                label35.Text = "分裂隧道";
                checkBox16.Text = "激活拆分隧道";
                label34.Text = "仅在启用拆分隧道时选定的应用程序";
                label33.Text = "将使用您的VPN IP。所有其他应用程序将使用您的实际";
                label32.Text = "IP（您的实际位置）。";
                checkBox15.Text = "永久化";
                label27.Text = "管理拆分隧道";
                //Split Tunneling 
                Chinese.Visible = true;
                Arabic.Visible = false;
                French.Visible = false;
                German.Visible = false;
                Italian.Visible = false;
                Dutch.Visible = false;
                america.Visible = false;
                Turkish.Visible = false;
                Spanish.Visible = false;
                
            }
            else
                if (Country.SelectedItem.ToString()== "Spanish")
            {
                //app settings
                checkBox14.Text = "Redial automáticamente si la conexión cae";
                checkBox13.Text = "Lanzamiento en el arranque del sistema";
                checkBox12.Text = "Conexión automática después del lanzamiento";
                disconnect.Text = "Desconectar la VPN en la salida de la aplicación";
                checkBox9.Text = "Inicie el navegador predeterminado después de conectarse";
                checkBox7.Text = "Ping servidores al inicio";
                label30.Text = "Protocolo seleccionado";
                label29.Text = "Seleccione el idioma";
                lblBack.Text = "espalda";
                label26.Text = "preferencia";
                btnProfile.Text = "Tu perfil";
                btnAppSetting.Text = "Ajustes de Aplicacion";
                btnSelectMode.Text = "Seleccionar modo";
                btnOptions.Text = "opciones avanzadas";
                btnSplits.Text = "Túneles divididos";
                btnCheckUpdate.Text = "Buscar actualizaciones";
                btnTickets.Text = "Boleto de soporte";
                btnLogOut.Text = "cerrar sesión";
                label31.Text = "Ajustes de Aplicacion";
                //app settings
                //your profile
                label28.Text = "información de acceso";
                checkBox11.Text = "mostrar contraseña";
                btnUpdate.Text = "actualizar";
                //your profile
                //Split Tunneling
                label35.Text = "Túnel dividido";
                checkBox16.Text = "Activar tunelización dividida";
                label34.Text = "Cuando el túnel dividido está habilitado solo las aplicaciones seleccionadas";
                label33.Text = "utilizará tu VPN IP. Todas las demás aplicaciones utilizarán su actual";
                label32.Text = "IP(Su ubicación actual).";
                checkBox15.Text = "Hazlo permanente";
                label27.Text = "Administrar Tunneling Dividido";
                //Split Tunneling
                Spanish.Visible = true;
                Chinese.Visible = false;
                Arabic.Visible = false;
                French.Visible = false;
                German.Visible = false;
                Italian.Visible = false;
                Dutch.Visible = false;
                america.Visible = false;
                Turkish.Visible = false;

            }
        }
        private System.Timers.Timer MonitorTimer;
        private void disconnect_CheckedChanged(object sender, EventArgs e)
        {
            MonitorTimer = new System.Timers.Timer(15000);
            MonitorTimer.Enabled = true;
            Information.InformationMessage("your time"+MonitorTimer+"");
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
