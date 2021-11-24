using System;
using System.Windows.Forms;

namespace MySQL_CT
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            Log.Initialize(txt_Log);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            string Hostname = txt_Hostname.Text;
            string Username = txt_Username.Text;
            string Password = txt_Password.Text;
            string Database = txt_Database.Text;
            string Port = txt_Port.Text;

            if(Hostname != string.Empty && Username != string.Empty && Database != string.Empty)
            {
                MySQL.Connect(Hostname, Username, Database, Port, Password);
            }
            else
            {
                Log.Write("Inform the correct data!");
            }
        }
    }
}
