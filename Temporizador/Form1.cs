using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms; 
namespace Temporizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        formCuentaRegresiva formCuenta;
        ApiWindows api;
        string commandR;
        private void btnProcesar_Click(object sender, EventArgs e)
        { 
            if (numHora.Value > 0 || numMinutos.Value > 0 || numSegundos.Value>0)
            {
                if (formCuenta == null || formCuenta.IsDisposed)
                {
                    decimal totalSegundos = numHora.Value * 60 * 60;
                    totalSegundos += numMinutos.Value * 60;
                    totalSegundos += numSegundos.Value;
                    
                    commandR = "shutdown -s -t "+totalSegundos;
                    executeCommand(commandR);
                    ejecutarTemporizador(Convert.ToInt32(numHora.Value), Convert.ToInt32(numMinutos.Value), Convert.ToInt32(numSegundos.Value));
                }
            }
        }
        public void ejecutarTemporizador(int hora, int minuto, int segundo)
        {
            double width = SystemParameters.FullPrimaryScreenWidth;
            formCuenta = new formCuentaRegresiva(hora,minuto,segundo);
            formCuenta.Show();
            formCuenta.Location = new Point(Convert.ToInt32(width - formCuenta.Size.Width), 0);
            api.SiempreEncima(formCuenta.Handle.ToInt32()); 
            btnCancelar.Enabled = true;
        }

        private void executeCommand(string commandR)
        {
            try
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = "/c " + commandR,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                proc.Start();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: "+e.Message);
            }
        }


        private void btn1h_Click(object sender, EventArgs e)
        {
            commandR = "shutdown -s -t 3600";
            executeCommand(commandR);
            ejecutarTemporizador(1,0,0);
        }

        private void btn1_30h_Click(object sender, EventArgs e)
        {
            commandR = "shutdown -s -t 5400";
            executeCommand(commandR);
            ejecutarTemporizador(1, 30, 0); 
        }

        private void btn2h_Click(object sender, EventArgs e)
        {
            commandR = "shutdown -s -t 7200";
            executeCommand(commandR);
            ejecutarTemporizador(2, 0, 0);
        }

        private void btn2_30h_Click(object sender, EventArgs e)
        {
            commandR = "shutdown -s -t 9000";
            executeCommand(commandR);
            ejecutarTemporizador(2, 30, 0); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }
        private void cancelar()
        {
            try
            {
                commandR = "shutdown -a";
                executeCommand(commandR);
                formCuenta.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Ha surgido un error: " + e.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            api = new ApiWindows();
            cmbTipo.Text = "Botones";
            formCuenta = new formCuentaRegresiva(0,0,0);
            formCuenta.Visible = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Botones") {
                grpBotones.Visible = true;
                grpPersonalizado.Visible = false;
            }
            else
            {
                grpBotones.Visible = false;
                grpPersonalizado.Visible = true; 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("El programa se está por cerrar, en caso de temporizador este activo este se cancelará.", "Confirmación", MessageBoxButtons.OK);
            cancelar();
        }
    }
}
