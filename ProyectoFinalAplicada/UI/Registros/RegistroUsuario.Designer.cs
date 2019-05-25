namespace ProyectoFinalAplicada.UI.Registros
{
    partial class RegistroUsuario
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
            this.NivelUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.IdErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OtroErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CargocomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtroErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NivelUsuarioComboBox
            // 
            this.NivelUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelUsuarioComboBox.FormattingEnabled = true;
            this.NivelUsuarioComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.NivelUsuarioComboBox.Location = new System.Drawing.Point(88, 137);
            this.NivelUsuarioComboBox.Name = "NivelUsuarioComboBox";
            this.NivelUsuarioComboBox.Size = new System.Drawing.Size(139, 21);
            this.NivelUsuarioComboBox.TabIndex = 80;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::ProyectoFinalAplicada.Properties.Resources.Search_32;
            this.buttonBuscar.Location = new System.Drawing.Point(245, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 43);
            this.buttonBuscar.TabIndex = 79;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinalAplicada.Properties.Resources.Delete;
            this.Eliminarbutton.Location = new System.Drawing.Point(215, 327);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 49);
            this.Eliminarbutton.TabIndex = 78;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinalAplicada.Properties.Resources.Add_Button_32;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 327);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 49);
            this.Nuevobutton.TabIndex = 77;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinalAplicada.Properties.Resources.Save;
            this.Guardarbutton.Location = new System.Drawing.Point(114, 327);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 49);
            this.Guardarbutton.TabIndex = 76;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(88, 285);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.FechaIngresoDateTimePicker.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "FechaIngreso";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(88, 18);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.IdnumericUpDown.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Email";
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(88, 243);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.Size = new System.Drawing.Size(139, 20);
            this.ClavetextBox.TabIndex = 70;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(88, 97);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(139, 20);
            this.EmailtextBox.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "NivelUsuario";
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(12, 62);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(49, 13);
            this.Nombres.TabIndex = 66;
            this.Nombres.Text = "Nombres";
            this.Nombres.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "ID";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(88, 207);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(139, 20);
            this.UsuariotextBox.TabIndex = 64;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(88, 59);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(139, 20);
            this.NombrestextBox.TabIndex = 63;
            // 
            // IdErrorProvider
            // 
            this.IdErrorProvider.ContainerControl = this;
            // 
            // OtroErrorProvider
            // 
            this.OtroErrorProvider.ContainerControl = this;
            // 
            // CargocomboBox
            // 
            this.CargocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CargocomboBox.FormattingEnabled = true;
            this.CargocomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.CargocomboBox.Location = new System.Drawing.Point(88, 173);
            this.CargocomboBox.Name = "CargocomboBox";
            this.CargocomboBox.Size = new System.Drawing.Size(139, 21);
            this.CargocomboBox.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Cargo";
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CargocomboBox);
            this.Controls.Add(this.NivelUsuarioComboBox);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.NombrestextBox);
            this.Name = "RegistroUsuario";
            this.Text = "RegistroUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtroErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NivelUsuarioComboBox;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.ErrorProvider IdErrorProvider;
        private System.Windows.Forms.ErrorProvider OtroErrorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CargocomboBox;
    }
}