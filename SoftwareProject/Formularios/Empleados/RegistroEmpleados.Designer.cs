namespace SoftwareProject.Formularios
{
    partial class RegistroEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PRegistro = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.labelJefe = new System.Windows.Forms.Label();
            this.chkJefe = new System.Windows.Forms.CheckBox();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 491);
            this.panel1.TabIndex = 2;
            // 
            // PRegistro
            // 
            this.PRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PRegistro.Controls.Add(this.txtUsername);
            this.PRegistro.Controls.Add(this.txtSueldo);
            this.PRegistro.Controls.Add(this.labelJefe);
            this.PRegistro.Controls.Add(this.chkJefe);
            this.PRegistro.Controls.Add(this.cmbAreas);
            this.PRegistro.Controls.Add(this.btnRegresar);
            this.PRegistro.Controls.Add(this.txtPass);
            this.PRegistro.Controls.Add(this.btnCerrar);
            this.PRegistro.Controls.Add(this.btnIngresar);
            this.PRegistro.Controls.Add(this.txtDireccion);
            this.PRegistro.Controls.Add(this.txtTelefono);
            this.PRegistro.Controls.Add(this.txtMail);
            this.PRegistro.Controls.Add(this.txtDNI);
            this.PRegistro.Controls.Add(this.txtNombre);
            this.PRegistro.Controls.Add(this.Registro);
            this.PRegistro.Dock = System.Windows.Forms.DockStyle.Right;
            this.PRegistro.Location = new System.Drawing.Point(614, 0);
            this.PRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PRegistro.Name = "PRegistro";
            this.PRegistro.Size = new System.Drawing.Size(318, 491);
            this.PRegistro.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.Location = new System.Drawing.Point(68, 126);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 17);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSueldo.Location = new System.Drawing.Point(68, 305);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(180, 16);
            this.txtSueldo.TabIndex = 14;
            this.txtSueldo.Text = "Sueldo LPS.";
            this.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSueldo.Enter += new System.EventHandler(this.txtSueldo_Enter);
            this.txtSueldo.Leave += new System.EventHandler(this.txtSueldo_Leave);
            // 
            // labelJefe
            // 
            this.labelJefe.AutoSize = true;
            this.labelJefe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJefe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelJefe.Location = new System.Drawing.Point(65, 372);
            this.labelJefe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJefe.Name = "labelJefe";
            this.labelJefe.Size = new System.Drawing.Size(83, 17);
            this.labelJefe.TabIndex = 13;
            this.labelJefe.Text = "Nuevo Jefe :";
            // 
            // chkJefe
            // 
            this.chkJefe.AutoSize = true;
            this.chkJefe.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJefe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkJefe.Location = new System.Drawing.Point(158, 374);
            this.chkJefe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkJefe.Name = "chkJefe";
            this.chkJefe.Size = new System.Drawing.Size(60, 20);
            this.chkJefe.TabIndex = 12;
            this.chkJefe.Text = "Si / No";
            this.chkJefe.UseVisualStyleBackColor = true;
            // 
            // cmbAreas
            // 
            this.cmbAreas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbAreas.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(98, 335);
            this.cmbAreas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(151, 21);
            this.cmbAreas.TabIndex = 10;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegresar.Location = new System.Drawing.Point(68, 443);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(173, 32);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPass.Location = new System.Drawing.Point(68, 195);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 17);
            this.txtPass.TabIndex = 8;
            this.txtPass.Text = "Contraseña";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIngresar.Location = new System.Drawing.Point(68, 400);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(173, 32);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "REGISTRAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDireccion.Location = new System.Drawing.Point(68, 277);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(180, 16);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.Text = "Direccion";
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefono.Location = new System.Drawing.Point(68, 250);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 16);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMail.Location = new System.Drawing.Point(68, 223);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 16);
            this.txtMail.TabIndex = 3;
            this.txtMail.Text = "Correo";
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDNI.Location = new System.Drawing.Point(68, 163);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(180, 17);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.Text = "Identidad";
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNI.Enter += new System.EventHandler(this.txtDNI_Enter);
            this.txtDNI.Leave += new System.EventHandler(this.txtDNI_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.Location = new System.Drawing.Point(68, 93);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 17);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Registro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Registro.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Registro.Location = new System.Drawing.Point(118, 32);
            this.Registro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(86, 35);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "STAFF";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Location = new System.Drawing.Point(287, 13);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 22);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(134, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 491);
            this.ControlBox = false;
            this.Controls.Add(this.PRegistro);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroEmpleados";
            this.Text = "RegistroEmpleados";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.PRegistro.ResumeLayout(false);
            this.PRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PRegistro;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Label labelJefe;
        private System.Windows.Forms.CheckBox chkJefe;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ErrorProvider error;
    }
}