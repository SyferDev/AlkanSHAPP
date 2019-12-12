using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Peripherals;
using Swan;

namespace ThesisFrontend
{
    public partial class Login : Form
    {
        private bool loggedIn = false;

        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            var device = new RFIDControllerMfrc522(Pi.Spi.Channel0, 500000, Pi.Gpio[18]);
            while (!loggedIn)
            {
                if (device.DetectCard() != RFIDControllerMfrc522.Status.AllOk) continue;

                var uid = device.ReadCardUniqueId();
                if (uid.Status != RFIDControllerMfrc522.Status.AllOk) continue;

                var cardUID = uid.Data;
                txt_login.Text = $"Card UID: {cardUID[0]}, {cardUID[1]}, {cardUID[2]}, {cardUID[3]}";
            }
        }
    }
}
