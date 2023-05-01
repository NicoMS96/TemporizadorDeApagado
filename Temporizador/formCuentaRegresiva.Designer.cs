
namespace Temporizador
{
    partial class formCuentaRegresiva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCuentaRegresiva = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCuentaRegresiva
            // 
            this.lblCuentaRegresiva.AutoSize = true;
            this.lblCuentaRegresiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblCuentaRegresiva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(92)))));
            this.lblCuentaRegresiva.Location = new System.Drawing.Point(12, 9);
            this.lblCuentaRegresiva.Name = "lblCuentaRegresiva";
            this.lblCuentaRegresiva.Size = new System.Drawing.Size(120, 31);
            this.lblCuentaRegresiva.TabIndex = 0;
            this.lblCuentaRegresiva.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formCuentaRegresiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(144, 51);
            this.ControlBox = false;
            this.Controls.Add(this.lblCuentaRegresiva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formCuentaRegresiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.formCuentaRegresiva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuentaRegresiva;
        private System.Windows.Forms.Timer timer1;
    }
}