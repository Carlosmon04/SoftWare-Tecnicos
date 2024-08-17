namespace SoftwareProject
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.LateralMenu = new System.Windows.Forms.Panel();
            this.subMenuInventario = new System.Windows.Forms.Panel();
            this.btnInfoInv = new System.Windows.Forms.Button();
            this.btnCompraInv = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.subMenuClie = new System.Windows.Forms.Panel();
            this.btnAConsultarClie = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.subMenuEmpleado = new System.Windows.Forms.Panel();
            this.btnInfoEmpleado = new System.Windows.Forms.Button();
            this.btnAggEmpleado = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnServicios = new System.Windows.Forms.Button();
            this.subMenuS = new System.Windows.Forms.Panel();
            this.btnInfoS = new System.Windows.Forms.Button();
            this.btnAgregarS = new System.Windows.Forms.Button();
            this.subMenuP = new System.Windows.Forms.Panel();
            this.btnInfoP = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnPaquetes = new System.Windows.Forms.Button();
            this.LateralMenu.SuspendLayout();
            this.subMenuInventario.SuspendLayout();
            this.subMenuClie.SuspendLayout();
            this.subMenuEmpleado.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subMenuS.SuspendLayout();
            this.subMenuP.SuspendLayout();
            this.SuspendLayout();
            // 
            // LateralMenu
            // 
            this.LateralMenu.AutoScroll = true;
            this.LateralMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.LateralMenu.Controls.Add(this.subMenuP);
            this.LateralMenu.Controls.Add(this.btnPaquetes);
            this.LateralMenu.Controls.Add(this.subMenuS);
            this.LateralMenu.Controls.Add(this.btnServicios);
            this.LateralMenu.Controls.Add(this.subMenuInventario);
            this.LateralMenu.Controls.Add(this.btnInventario);
            this.LateralMenu.Controls.Add(this.subMenuClie);
            this.LateralMenu.Controls.Add(this.btnClientes);
            this.LateralMenu.Controls.Add(this.subMenuEmpleado);
            this.LateralMenu.Controls.Add(this.btnEmpleados);
            this.LateralMenu.Controls.Add(this.panelLogo);
            this.LateralMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LateralMenu.Location = new System.Drawing.Point(0, 0);
            this.LateralMenu.Name = "LateralMenu";
            this.LateralMenu.Size = new System.Drawing.Size(281, 723);
            this.LateralMenu.TabIndex = 0;
            // 
            // subMenuInventario
            // 
            this.subMenuInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuInventario.Controls.Add(this.btnInfoInv);
            this.subMenuInventario.Controls.Add(this.btnCompraInv);
            this.subMenuInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuInventario.Location = new System.Drawing.Point(0, 416);
            this.subMenuInventario.Name = "subMenuInventario";
            this.subMenuInventario.Size = new System.Drawing.Size(260, 101);
            this.subMenuInventario.TabIndex = 4;
            // 
            // btnInfoInv
            // 
            this.btnInfoInv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoInv.FlatAppearance.BorderSize = 0;
            this.btnInfoInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoInv.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfoInv.Location = new System.Drawing.Point(0, 45);
            this.btnInfoInv.Name = "btnInfoInv";
            this.btnInfoInv.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnInfoInv.Size = new System.Drawing.Size(260, 45);
            this.btnInfoInv.TabIndex = 3;
            this.btnInfoInv.Text = "Informacion";
            this.btnInfoInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoInv.UseVisualStyleBackColor = true;
            this.btnInfoInv.Click += new System.EventHandler(this.btnInfoInv_Click);
            // 
            // btnCompraInv
            // 
            this.btnCompraInv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompraInv.FlatAppearance.BorderSize = 0;
            this.btnCompraInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraInv.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompraInv.Location = new System.Drawing.Point(0, 0);
            this.btnCompraInv.Name = "btnCompraInv";
            this.btnCompraInv.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnCompraInv.Size = new System.Drawing.Size(260, 45);
            this.btnCompraInv.TabIndex = 1;
            this.btnCompraInv.Text = "Hacer Compra";
            this.btnCompraInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompraInv.UseVisualStyleBackColor = true;
            this.btnCompraInv.Click += new System.EventHandler(this.btnCompraInv_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.Location = new System.Drawing.Point(0, 365);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(260, 51);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // subMenuClie
            // 
            this.subMenuClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuClie.Controls.Add(this.btnAConsultarClie);
            this.subMenuClie.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuClie.Location = new System.Drawing.Point(0, 315);
            this.subMenuClie.Name = "subMenuClie";
            this.subMenuClie.Size = new System.Drawing.Size(260, 50);
            this.subMenuClie.TabIndex = 3;
 
            // 
            // btnAConsultarClie
            // 
            this.btnAConsultarClie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAConsultarClie.FlatAppearance.BorderSize = 0;
            this.btnAConsultarClie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAConsultarClie.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAConsultarClie.Location = new System.Drawing.Point(0, 0);
            this.btnAConsultarClie.Name = "btnAConsultarClie";
            this.btnAConsultarClie.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnAConsultarClie.Size = new System.Drawing.Size(260, 45);
            this.btnAConsultarClie.TabIndex = 1;
            this.btnAConsultarClie.Text = "Consultar";
            this.btnAConsultarClie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAConsultarClie.UseVisualStyleBackColor = true;
            this.btnAConsultarClie.Click += new System.EventHandler(this.btnAggClie_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Location = new System.Drawing.Point(0, 264);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(260, 51);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // subMenuEmpleado
            // 
            this.subMenuEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuEmpleado.Controls.Add(this.btnInfoEmpleado);
            this.subMenuEmpleado.Controls.Add(this.btnAggEmpleado);
            this.subMenuEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuEmpleado.Location = new System.Drawing.Point(0, 163);
            this.subMenuEmpleado.Name = "subMenuEmpleado";
            this.subMenuEmpleado.Size = new System.Drawing.Size(260, 101);
            this.subMenuEmpleado.TabIndex = 1;
            // 
            // btnInfoEmpleado
            // 
            this.btnInfoEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoEmpleado.FlatAppearance.BorderSize = 0;
            this.btnInfoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfoEmpleado.Location = new System.Drawing.Point(0, 45);
            this.btnInfoEmpleado.Name = "btnInfoEmpleado";
            this.btnInfoEmpleado.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnInfoEmpleado.Size = new System.Drawing.Size(260, 45);
            this.btnInfoEmpleado.TabIndex = 3;
            this.btnInfoEmpleado.Text = "Informacion";
            this.btnInfoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoEmpleado.UseVisualStyleBackColor = true;
            this.btnInfoEmpleado.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAggEmpleado
            // 
            this.btnAggEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAggEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAggEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAggEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnAggEmpleado.Name = "btnAggEmpleado";
            this.btnAggEmpleado.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnAggEmpleado.Size = new System.Drawing.Size(260, 45);
            this.btnAggEmpleado.TabIndex = 1;
            this.btnAggEmpleado.Text = "Agregar";
            this.btnAggEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAggEmpleado.UseVisualStyleBackColor = true;
            this.btnAggEmpleado.Click += new System.EventHandler(this.btnAggUser_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 112);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(260, 51);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleado";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(260, 112);
            this.panelLogo.TabIndex = 1;
            // 
            // panelForms
            // 
            this.panelForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.panelForms.Controls.Add(this.pictureBox1);
            this.panelForms.Location = new System.Drawing.Point(281, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1067, 723);
            this.panelForms.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnServicios
            // 
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServicios.Location = new System.Drawing.Point(0, 517);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnServicios.Size = new System.Drawing.Size(260, 51);
            this.btnServicios.TabIndex = 6;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.button1_Click);
            // 
            // subMenuS
            // 
            this.subMenuS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuS.Controls.Add(this.btnInfoS);
            this.subMenuS.Controls.Add(this.btnAgregarS);
            this.subMenuS.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuS.Location = new System.Drawing.Point(0, 568);
            this.subMenuS.Name = "subMenuS";
            this.subMenuS.Size = new System.Drawing.Size(260, 101);
            this.subMenuS.TabIndex = 7;
            // 
            // btnInfoS
            // 
            this.btnInfoS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoS.FlatAppearance.BorderSize = 0;
            this.btnInfoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfoS.Location = new System.Drawing.Point(0, 45);
            this.btnInfoS.Name = "btnInfoS";
            this.btnInfoS.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnInfoS.Size = new System.Drawing.Size(260, 45);
            this.btnInfoS.TabIndex = 3;
            this.btnInfoS.Text = "Informacion";
            this.btnInfoS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoS.UseVisualStyleBackColor = true;
            this.btnInfoS.Click += new System.EventHandler(this.btnInfoS_Click);
            // 
            // btnAgregarS
            // 
            this.btnAgregarS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarS.FlatAppearance.BorderSize = 0;
            this.btnAgregarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarS.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarS.Name = "btnAgregarS";
            this.btnAgregarS.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnAgregarS.Size = new System.Drawing.Size(260, 45);
            this.btnAgregarS.TabIndex = 1;
            this.btnAgregarS.Text = "Agregar";
            this.btnAgregarS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarS.UseVisualStyleBackColor = true;
            this.btnAgregarS.Click += new System.EventHandler(this.btnAgregarS_Click);
            // 
            // subMenuP
            // 
            this.subMenuP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuP.Controls.Add(this.btnInfoP);
            this.subMenuP.Controls.Add(this.btnAgregarP);
            this.subMenuP.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuP.Location = new System.Drawing.Point(0, 720);
            this.subMenuP.Name = "subMenuP";
            this.subMenuP.Size = new System.Drawing.Size(260, 101);
            this.subMenuP.TabIndex = 9;
            // 
            // btnInfoP
            // 
            this.btnInfoP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoP.FlatAppearance.BorderSize = 0;
            this.btnInfoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfoP.Location = new System.Drawing.Point(0, 45);
            this.btnInfoP.Name = "btnInfoP";
            this.btnInfoP.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnInfoP.Size = new System.Drawing.Size(260, 45);
            this.btnInfoP.TabIndex = 3;
            this.btnInfoP.Text = "Informacion";
            this.btnInfoP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoP.UseVisualStyleBackColor = true;
            this.btnInfoP.Click += new System.EventHandler(this.btnInfoP_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarP.FlatAppearance.BorderSize = 0;
            this.btnAgregarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarP.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Padding = new System.Windows.Forms.Padding(51, 0, 0, 0);
            this.btnAgregarP.Size = new System.Drawing.Size(260, 45);
            this.btnAgregarP.TabIndex = 1;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnPaquetes
            // 
            this.btnPaquetes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaquetes.FlatAppearance.BorderSize = 0;
            this.btnPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaquetes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPaquetes.Location = new System.Drawing.Point(0, 669);
            this.btnPaquetes.Name = "btnPaquetes";
            this.btnPaquetes.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnPaquetes.Size = new System.Drawing.Size(260, 51);
            this.btnPaquetes.TabIndex = 8;
            this.btnPaquetes.Text = "Paquetes";
            this.btnPaquetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquetes.UseVisualStyleBackColor = true;
            this.btnPaquetes.Click += new System.EventHandler(this.btnPaquetes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1347, 723);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.LateralMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio Tecnico Avanzado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LateralMenu.ResumeLayout(false);
            this.subMenuInventario.ResumeLayout(false);
            this.subMenuClie.ResumeLayout(false);
            this.subMenuEmpleado.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            this.panelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subMenuS.ResumeLayout(false);
            this.subMenuP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LateralMenu;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel subMenuEmpleado;
        private System.Windows.Forms.Button btnInfoEmpleado;
        private System.Windows.Forms.Button btnAggEmpleado;
        private System.Windows.Forms.Panel subMenuClie;
        private System.Windows.Forms.Button btnAConsultarClie;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel subMenuInventario;
        private System.Windows.Forms.Button btnInfoInv;
        private System.Windows.Forms.Button btnCompraInv;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel subMenuS;
        private System.Windows.Forms.Button btnInfoS;
        private System.Windows.Forms.Button btnAgregarS;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Panel subMenuP;
        private System.Windows.Forms.Button btnInfoP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnPaquetes;
    }
}

