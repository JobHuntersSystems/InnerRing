using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PACS_Common;

namespace PACS_Center
{
    public partial class frmInnerEncryption : Form
    {
        public frmInnerEncryption()
        {
            _idPlanet = PACS_Common.Planet.idPlanet;
            InitializeComponent();            
        }

        private Dictionary<char, string> data;
        private string validationCode;
        private int _idPlanet;
        int pass;
        InnerEncryption cls = new InnerEncryption();
 
        //----------------Guardar en la base de datos los datos--------------------------------\\
        private void Code()
        {
            try
            {
                cls.SaveCode(_idPlanet, validationCode, data);
            }
            catch (Exception ex)
            {
                timerMsj.Stop();
                btnCode.Enabled = true;
                lstMsj.AddLog(LogLevel.Error, "Error uploading to database!");
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCode_Click(object sender, EventArgs e)
        {
            btnCode.Enabled = false;
            
            pass = 0;
            timerMsj.Interval = 600;
            timerMsj.Start();     
        }

        //------------------Mensajes en pantalla y flujo del codigo-----------------------------\\

        private void timerMsj_Tick(object sender, EventArgs e)
        {
            switch (pass)
            {
                case 0:
                    string msj = "Generating encoding...";
                    lstMsj.AddLog(LogLevel.Info, msj);
                    validationCode = cls.RandomCode();
                    data = cls.RandomValue();
                    break;
                case 1:
                    msj = "Validating encoding...";
                    lstMsj.AddLog(LogLevel.Info, msj);
                    timerMsj.Interval = 1000;
                    break;
                case 2:
                    msj = "Encoding validated.";
                    lstMsj.AddLog(LogLevel.Success, msj);                    
                    break;
                case 3:
                    msj = "Uploading encoding to the system...";
                    lstMsj.AddLog(LogLevel.Info, msj);
                    timerMsj.Interval = 1500;
                    break;
                case 4:
                    cls.SaveCode(_idPlanet, validationCode, data);
                    timerMsj.Interval = 2000;
                    break;
                case 5:
                    msj = "Upload completed.";
                    lstMsj.AddLog(LogLevel.Success, msj);

                    timerMsj.Stop();
                    btnCode.Enabled = true;
                    break;
            }
            pass++;
        }
    }
}
