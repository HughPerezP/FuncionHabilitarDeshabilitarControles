namespace FuncionHabilitarDeshabilitarControles
{
    partial class Form1
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
            this.Label13 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.rb_femenino = new System.Windows.Forms.RadioButton();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(33, 42);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(92, 18);
            this.Label13.TabIndex = 259;
            this.Label13.Text = "Id empleado:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rb_masculino);
            this.GroupBox1.Controls.Add(this.rb_femenino);
            this.GroupBox1.Enabled = false;
            this.GroupBox1.Location = new System.Drawing.Point(129, 140);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(227, 53);
            this.GroupBox1.TabIndex = 247;
            this.GroupBox1.TabStop = false;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Checked = true;
            this.rb_masculino.Location = new System.Drawing.Point(18, 19);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(62, 17);
            this.rb_masculino.TabIndex = 0;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Hombre";
            this.rb_masculino.UseVisualStyleBackColor = true;
            // 
            // rb_femenino
            // 
            this.rb_femenino.AutoSize = true;
            this.rb_femenino.Location = new System.Drawing.Point(139, 19);
            this.rb_femenino.Name = "rb_femenino";
            this.rb_femenino.Size = new System.Drawing.Size(51, 17);
            this.rb_femenino.TabIndex = 1;
            this.rb_femenino.Text = "Mujer";
            this.rb_femenino.UseVisualStyleBackColor = true;
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Enabled = false;
            this.dtpnacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnacimiento.Location = new System.Drawing.Point(129, 110);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(227, 24);
            this.dtpnacimiento.TabIndex = 248;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(17, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(108, 18);
            this.Label4.TabIndex = 253;
            this.Label4.Text = "Fecha de Nac.:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(59, 78);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 18);
            this.Label5.TabIndex = 250;
            this.Label5.Text = "Nombre:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(129, 40);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(227, 20);
            this.txtEmpleado.TabIndex = 260;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 20);
            this.txtNombre.TabIndex = 261;
            // 
            // btnBloquear
            // 
            this.btnBloquear.Location = new System.Drawing.Point(400, 38);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(103, 40);
            this.btnBloquear.TabIndex = 262;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.Bloquear_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Location = new System.Drawing.Point(401, 96);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(102, 32);
            this.btnDesbloquear.TabIndex = 263;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 281);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.btnBloquear);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dtpnacimiento);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rb_masculino;
        internal System.Windows.Forms.RadioButton rb_femenino;
        internal System.Windows.Forms.DateTimePicker dtpnacimiento;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.Button btnDesbloquear;

    }
}

