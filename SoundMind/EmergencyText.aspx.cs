using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Twilio;

namespace SoundMind
{
    public partial class EmergencyText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SendMessage_OnClick(object sender, EventArgs e)
        {
            string ACCOUNT_SID = ConfigurationManager.AppSettings["sid"];
            string AUTH_TOKEN = ConfigurationManager.AppSettings["token"];

            TwilioRestClient client = new TwilioRestClient(ACCOUNT_SID, AUTH_TOKEN);
            client.SendMessage("(414) 448-6420", EmergencyTextNumber.Text, Message.Text);
        }
    }
}