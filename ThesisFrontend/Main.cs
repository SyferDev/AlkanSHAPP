using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Swan;
using Unosquare.RaspberryIO;
using Unosquare.WiringPi;
using Unosquare.RaspberryIO.Peripherals;

namespace ThesisFrontend
{
    public partial class Main : Form
    {
        TableLayoutPanel login;
        TableLayoutPanel main;

        bool loggedIn = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Pi.Init<BootstrapWiringPi>();

            login = scr_login;
            main = scr_main;
            Show();

            if (!loggedIn) LoginScreen();
        }

        private void LoginScreen()
        {
            var dev = new RFIDControllerMfrc522(Pi.Spi.Channel0, Pi.Spi.Channel0Frequency, Pi.Gpio[18]);
            while(!loggedIn)
            {
                if (dev.DetectCard() != RFIDControllerMfrc522.Status.AllOk) continue;
                var uidResponse = dev.ReadCardUniqueId();

                if (uidResponse.Status != RFIDControllerMfrc522.Status.AllOk) continue;
                var cardUid = uidResponse.Data;
                txt_login.Text = $"Card UID: {cardUid[0]},{cardUid[1]},{cardUid[2]},{cardUid[3]}";
                loggedIn = true;
            }
        }

        private void btn_testsub_Click(object sender, EventArgs e)
        {
            if (!loggedIn) return;
            login.Visible = false;
            main.Visible = true;
        }
    }
}
