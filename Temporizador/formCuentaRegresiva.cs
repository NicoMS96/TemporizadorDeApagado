using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizador
{
    public partial class formCuentaRegresiva : Form
    {
        
        public formCuentaRegresiva(int horas, int minutos, int segundos)
        {
            InitializeComponent();
            this.horas = horas;
            this.minutos = minutos;
            this.segundos = segundos; 
        } 
        public int horas { get; set; }
        public int minutos { get; set; }
        public int segundos { get; set; }
        string hor, min, seg;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (horas == 0 && minutos == 30)
                lblCuentaRegresiva.ForeColor = Color.Orange;
            if (horas == 0 && minutos == 10)
                lblCuentaRegresiva.ForeColor = Color.Red;


            if (horas == 0 && minutos == 0 && segundos == 1)
                Application.Exit();

            if (segundos == 0)
            {
                segundos = 60;
                minutos--;
            }
            if (minutos < 0)
            {
                minutos = 59;
                horas--;
            }
             
            segundos--;
            if (horas < 10)
                hor = "0" + horas.ToString();
            else
                hor = horas.ToString();

            if (minutos < 10)
                min = "0" + minutos.ToString();
            else
                min = minutos.ToString();

            if (segundos < 10)
                seg = "0" + segundos.ToString();
            else
                seg = segundos.ToString();


          

            lblCuentaRegresiva.Text = $"{hor}:{min}:{seg}";

        }

        private void formCuentaRegresiva_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;  
            timer1.Enabled = true; 
            
        }
    }
}
