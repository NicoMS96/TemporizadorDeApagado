
namespace Temporizador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1h = new System.Windows.Forms.Button();
            this.btn2h = new System.Windows.Forms.Button();
            this.btn1_30h = new System.Windows.Forms.Button();
            this.btn2_30h = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.numSegundos = new System.Windows.Forms.NumericUpDown();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.grpPersonalizado = new System.Windows.Forms.GroupBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            this.grpPersonalizado.SuspendLayout();
            this.grpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1h
            // 
            this.btn1h.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn1h.Location = new System.Drawing.Point(0, 8);
            this.btn1h.Name = "btn1h";
            this.btn1h.Size = new System.Drawing.Size(106, 53);
            this.btn1h.TabIndex = 3;
            this.btn1h.Text = "1h";
            this.btn1h.UseVisualStyleBackColor = true;
            this.btn1h.Click += new System.EventHandler(this.btn1h_Click);
            // 
            // btn2h
            // 
            this.btn2h.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn2h.Location = new System.Drawing.Point(0, 67);
            this.btn2h.Name = "btn2h";
            this.btn2h.Size = new System.Drawing.Size(106, 53);
            this.btn2h.TabIndex = 4;
            this.btn2h.Text = "2h";
            this.btn2h.UseVisualStyleBackColor = true;
            this.btn2h.Click += new System.EventHandler(this.btn2h_Click);
            // 
            // btn1_30h
            // 
            this.btn1_30h.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn1_30h.Location = new System.Drawing.Point(112, 8);
            this.btn1_30h.Name = "btn1_30h";
            this.btn1_30h.Size = new System.Drawing.Size(106, 53);
            this.btn1_30h.TabIndex = 6;
            this.btn1_30h.Text = "1:30h";
            this.btn1_30h.UseVisualStyleBackColor = true;
            this.btn1_30h.Click += new System.EventHandler(this.btn1_30h_Click);
            // 
            // btn2_30h
            // 
            this.btn2_30h.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btn2_30h.Location = new System.Drawing.Point(112, 67);
            this.btn2_30h.Name = "btn2_30h";
            this.btn2_30h.Size = new System.Drawing.Size(106, 53);
            this.btn2_30h.TabIndex = 7;
            this.btn2_30h.Text = "2:30h";
            this.btn2_30h.UseVisualStyleBackColor = true;
            this.btn2_30h.Click += new System.EventHandler(this.btn2_30h_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(10, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(218, 59);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Green;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(0, 61);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(218, 59);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Guardar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // numHora
            // 
            this.numHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.numHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.numHora.ForeColor = System.Drawing.Color.White;
            this.numHora.Location = new System.Drawing.Point(1, 9);
            this.numHora.Name = "numHora";
            this.numHora.Size = new System.Drawing.Size(67, 46);
            this.numHora.TabIndex = 10;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.cmbTipo.ForeColor = System.Drawing.Color.White;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Botones",
            "Personalizado"});
            this.cmbTipo.Location = new System.Drawing.Point(10, 9);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(218, 37);
            this.cmbTipo.TabIndex = 11;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // numSegundos
            // 
            this.numSegundos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.numSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.numSegundos.ForeColor = System.Drawing.Color.White;
            this.numSegundos.Location = new System.Drawing.Point(152, 9);
            this.numSegundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSegundos.Name = "numSegundos";
            this.numSegundos.Size = new System.Drawing.Size(67, 46);
            this.numSegundos.TabIndex = 12;
            // 
            // numMinutos
            // 
            this.numMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.numMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.numMinutos.ForeColor = System.Drawing.Color.White;
            this.numMinutos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinutos.Location = new System.Drawing.Point(74, 9);
            this.numMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(72, 46);
            this.numMinutos.TabIndex = 13;
            // 
            // grpPersonalizado
            // 
            this.grpPersonalizado.Controls.Add(this.btnProcesar);
            this.grpPersonalizado.Controls.Add(this.numHora);
            this.grpPersonalizado.Controls.Add(this.numSegundos);
            this.grpPersonalizado.Controls.Add(this.numMinutos);
            this.grpPersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPersonalizado.Location = new System.Drawing.Point(10, 44);
            this.grpPersonalizado.Name = "grpPersonalizado";
            this.grpPersonalizado.Size = new System.Drawing.Size(218, 120);
            this.grpPersonalizado.TabIndex = 16;
            this.grpPersonalizado.TabStop = false;
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.btn2h);
            this.grpBotones.Controls.Add(this.btn2_30h);
            this.grpBotones.Controls.Add(this.btn1h);
            this.grpBotones.Controls.Add(this.btn1_30h);
            this.grpBotones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBotones.Location = new System.Drawing.Point(10, 44);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(218, 120);
            this.grpBotones.TabIndex = 17;
            this.grpBotones.TabStop = false;
            this.grpBotones.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(241, 241);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpPersonalizado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(257, 280);
            this.MinimumSize = new System.Drawing.Size(257, 280);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            this.grpPersonalizado.ResumeLayout(false);
            this.grpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn1h;
        private System.Windows.Forms.Button btn2h;
        private System.Windows.Forms.Button btn1_30h;
        private System.Windows.Forms.Button btn2_30h;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.NumericUpDown numHora;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown numSegundos;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.GroupBox grpPersonalizado;
        private System.Windows.Forms.GroupBox grpBotones;
    }
}

