namespace Ateka.Modulos.Copropietario
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Ateka_lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Nombre_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Unidad_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Comunidad_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Vacio_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Inicio_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosComunes_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarColillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Datos_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Cerrar_sesion_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensaje_gbx = new System.Windows.Forms.GroupBox();
            this.RestoMensaje_lbl = new System.Windows.Forms.Label();
            this.Titulo2_lbl = new System.Windows.Forms.Label();
            this.Titulo_lbl = new System.Windows.Forms.Label();
            this.porcentaje_lbl = new System.Windows.Forms.Label();
            this.Datos_gbx = new System.Windows.Forms.GroupBox();
            this.Pago_anterior_gbx = new System.Windows.Forms.GroupBox();
            this.Pago_anterior_lbl = new System.Windows.Forms.Label();
            this.Anterior_lbl = new System.Windows.Forms.Label();
            this.Actual_gbx = new System.Windows.Forms.GroupBox();
            this.MontoActual_lbl = new System.Windows.Forms.Label();
            this.Actua_lbl = new System.Windows.Forms.Label();
            this.Prorrateo_gbx = new System.Windows.Forms.GroupBox();
            this.porrateo_lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.Mensaje_gbx.SuspendLayout();
            this.Datos_gbx.SuspendLayout();
            this.Pago_anterior_gbx.SuspendLayout();
            this.Actual_gbx.SuspendLayout();
            this.Prorrateo_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ateka_lbl
            // 
            this.Ateka_lbl.AutoSize = true;
            this.Ateka_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Ateka_lbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ateka_lbl.ForeColor = System.Drawing.Color.White;
            this.Ateka_lbl.Location = new System.Drawing.Point(39, 5);
            this.Ateka_lbl.Name = "Ateka_lbl";
            this.Ateka_lbl.Size = new System.Drawing.Size(59, 22);
            this.Ateka_lbl.TabIndex = 11;
            this.Ateka_lbl.Text = "Ateka";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nombre_smi,
            this.Unidad_smi,
            this.Comunidad_smi,
            this.Vacio_smi,
            this.Inicio_smi,
            this.gastosComunes_smi,
            this.Datos_smi,
            this.agregarPagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(148, 509);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Nombre_smi
            // 
            this.Nombre_smi.Name = "Nombre_smi";
            this.Nombre_smi.Size = new System.Drawing.Size(135, 19);
            this.Nombre_smi.Text = "$nombre";
            // 
            // Unidad_smi
            // 
            this.Unidad_smi.Name = "Unidad_smi";
            this.Unidad_smi.Size = new System.Drawing.Size(135, 19);
            this.Unidad_smi.Text = "$Unidad";
            // 
            // Comunidad_smi
            // 
            this.Comunidad_smi.Name = "Comunidad_smi";
            this.Comunidad_smi.Size = new System.Drawing.Size(135, 19);
            this.Comunidad_smi.Text = "$comunidad";
            // 
            // Vacio_smi
            // 
            this.Vacio_smi.Name = "Vacio_smi";
            this.Vacio_smi.Size = new System.Drawing.Size(135, 19);
            this.Vacio_smi.Text = "  ";
            // 
            // Inicio_smi
            // 
            this.Inicio_smi.Name = "Inicio_smi";
            this.Inicio_smi.Size = new System.Drawing.Size(135, 19);
            this.Inicio_smi.Text = "Inicio";
            this.Inicio_smi.Click += new System.EventHandler(this.Inicio_smi_Click);
            // 
            // gastosComunes_smi
            // 
            this.gastosComunes_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarColillasToolStripMenuItem,
            this.revisarEgresosToolStripMenuItem});
            this.gastosComunes_smi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gastosComunes_smi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gastosComunes_smi.Name = "gastosComunes_smi";
            this.gastosComunes_smi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gastosComunes_smi.Size = new System.Drawing.Size(135, 19);
            this.gastosComunes_smi.Text = "Gastos Comunes";
            this.gastosComunes_smi.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // revisarColillasToolStripMenuItem
            // 
            this.revisarColillasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.revisarColillasToolStripMenuItem.Name = "revisarColillasToolStripMenuItem";
            this.revisarColillasToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.revisarColillasToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.revisarColillasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.revisarColillasToolStripMenuItem.Text = "Revisar Colillas";
            this.revisarColillasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revisarColillasToolStripMenuItem.Click += new System.EventHandler(this.revisarColillasToolStripMenuItem_Click);
            // 
            // revisarEgresosToolStripMenuItem
            // 
            this.revisarEgresosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.revisarEgresosToolStripMenuItem.Name = "revisarEgresosToolStripMenuItem";
            this.revisarEgresosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.revisarEgresosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.revisarEgresosToolStripMenuItem.Text = "Revisar Egresos";
            this.revisarEgresosToolStripMenuItem.Click += new System.EventHandler(this.revisarEgresosToolStripMenuItem_Click);
            // 
            // Datos_smi
            // 
            this.Datos_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.cambiarDatosToolStripMenuItem});
            this.Datos_smi.Name = "Datos_smi";
            this.Datos_smi.Size = new System.Drawing.Size(135, 19);
            this.Datos_smi.Text = "Cambio de datos";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cambiarDatosToolStripMenuItem
            // 
            this.cambiarDatosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cambiarDatosToolStripMenuItem.Name = "cambiarDatosToolStripMenuItem";
            this.cambiarDatosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cambiarDatosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarDatosToolStripMenuItem.Text = "Cambiar Datos";
            this.cambiarDatosToolStripMenuItem.Click += new System.EventHandler(this.cambiarDatosToolStripMenuItem_Click);
            // 
            // agregarPagoToolStripMenuItem
            // 
            this.agregarPagoToolStripMenuItem.Name = "agregarPagoToolStripMenuItem";
            this.agregarPagoToolStripMenuItem.Size = new System.Drawing.Size(135, 19);
            this.agregarPagoToolStripMenuItem.Text = "Visualizar Datos Unidad";
            this.agregarPagoToolStripMenuItem.Click += new System.EventHandler(this.agregarPagoToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cerrar_sesion_smi});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 2, 0, 10);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(962, 31);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Cerrar_sesion_smi
            // 
            this.Cerrar_sesion_smi.ForeColor = System.Drawing.Color.White;
            this.Cerrar_sesion_smi.Name = "Cerrar_sesion_smi";
            this.Cerrar_sesion_smi.Size = new System.Drawing.Size(93, 19);
            this.Cerrar_sesion_smi.Text = "Cerrar Session";
            this.Cerrar_sesion_smi.Click += new System.EventHandler(this.Cerrar_sesion_smi_Click);
            // 
            // Mensaje_gbx
            // 
            this.Mensaje_gbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Mensaje_gbx.Controls.Add(this.RestoMensaje_lbl);
            this.Mensaje_gbx.Controls.Add(this.Titulo2_lbl);
            this.Mensaje_gbx.Controls.Add(this.Titulo_lbl);
            this.Mensaje_gbx.Location = new System.Drawing.Point(148, 31);
            this.Mensaje_gbx.Name = "Mensaje_gbx";
            this.Mensaje_gbx.Size = new System.Drawing.Size(817, 110);
            this.Mensaje_gbx.TabIndex = 12;
            this.Mensaje_gbx.TabStop = false;
            // 
            // RestoMensaje_lbl
            // 
            this.RestoMensaje_lbl.AutoSize = true;
            this.RestoMensaje_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoMensaje_lbl.ForeColor = System.Drawing.Color.White;
            this.RestoMensaje_lbl.Location = new System.Drawing.Point(292, 68);
            this.RestoMensaje_lbl.Name = "RestoMensaje_lbl";
            this.RestoMensaje_lbl.Size = new System.Drawing.Size(144, 24);
            this.RestoMensaje_lbl.TabIndex = 2;
            this.RestoMensaje_lbl.Text = "Edificio ATEKA¡";
            // 
            // Titulo2_lbl
            // 
            this.Titulo2_lbl.AutoSize = true;
            this.Titulo2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo2_lbl.ForeColor = System.Drawing.Color.White;
            this.Titulo2_lbl.Location = new System.Drawing.Point(129, 44);
            this.Titulo2_lbl.Name = "Titulo2_lbl";
            this.Titulo2_lbl.Size = new System.Drawing.Size(514, 24);
            this.Titulo2_lbl.TabIndex = 1;
            this.Titulo2_lbl.Text = "!Bienvenido al SIstema de Administracion de Condominios y";
            // 
            // Titulo_lbl
            // 
            this.Titulo_lbl.AutoSize = true;
            this.Titulo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_lbl.ForeColor = System.Drawing.Color.White;
            this.Titulo_lbl.Location = new System.Drawing.Point(260, 20);
            this.Titulo_lbl.Name = "Titulo_lbl";
            this.Titulo_lbl.Size = new System.Drawing.Size(135, 24);
            this.Titulo_lbl.TabIndex = 0;
            this.Titulo_lbl.Text = "Hola, $nombre";
            // 
            // porcentaje_lbl
            // 
            this.porcentaje_lbl.AutoSize = true;
            this.porcentaje_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.porcentaje_lbl.Location = new System.Drawing.Point(39, 15);
            this.porcentaje_lbl.Name = "porcentaje_lbl";
            this.porcentaje_lbl.Size = new System.Drawing.Size(85, 20);
            this.porcentaje_lbl.TabIndex = 13;
            this.porcentaje_lbl.Text = "Porcentaje";
            this.porcentaje_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Datos_gbx
            // 
            this.Datos_gbx.Controls.Add(this.Pago_anterior_gbx);
            this.Datos_gbx.Controls.Add(this.Anterior_lbl);
            this.Datos_gbx.Controls.Add(this.Actual_gbx);
            this.Datos_gbx.Controls.Add(this.Actua_lbl);
            this.Datos_gbx.Controls.Add(this.Prorrateo_gbx);
            this.Datos_gbx.Controls.Add(this.porcentaje_lbl);
            this.Datos_gbx.Location = new System.Drawing.Point(810, 147);
            this.Datos_gbx.Name = "Datos_gbx";
            this.Datos_gbx.Size = new System.Drawing.Size(155, 393);
            this.Datos_gbx.TabIndex = 14;
            this.Datos_gbx.TabStop = false;
            this.Datos_gbx.Enter += new System.EventHandler(this.Datos_gbx_Enter);
            // 
            // Pago_anterior_gbx
            // 
            this.Pago_anterior_gbx.Controls.Add(this.Pago_anterior_lbl);
            this.Pago_anterior_gbx.Location = new System.Drawing.Point(22, 213);
            this.Pago_anterior_gbx.Name = "Pago_anterior_gbx";
            this.Pago_anterior_gbx.Size = new System.Drawing.Size(125, 38);
            this.Pago_anterior_gbx.TabIndex = 14;
            this.Pago_anterior_gbx.TabStop = false;
            // 
            // Pago_anterior_lbl
            // 
            this.Pago_anterior_lbl.AutoSize = true;
            this.Pago_anterior_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pago_anterior_lbl.Location = new System.Drawing.Point(30, 11);
            this.Pago_anterior_lbl.Name = "Pago_anterior_lbl";
            this.Pago_anterior_lbl.Size = new System.Drawing.Size(24, 18);
            this.Pago_anterior_lbl.TabIndex = 0;
            this.Pago_anterior_lbl.Text = "$0";
            // 
            // Anterior_lbl
            // 
            this.Anterior_lbl.AutoSize = true;
            this.Anterior_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anterior_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Anterior_lbl.Location = new System.Drawing.Point(33, 189);
            this.Anterior_lbl.Name = "Anterior_lbl";
            this.Anterior_lbl.Size = new System.Drawing.Size(114, 20);
            this.Anterior_lbl.TabIndex = 15;
            this.Anterior_lbl.Text = "Monto Anterior";
            // 
            // Actual_gbx
            // 
            this.Actual_gbx.Controls.Add(this.MontoActual_lbl);
            this.Actual_gbx.Location = new System.Drawing.Point(22, 123);
            this.Actual_gbx.Name = "Actual_gbx";
            this.Actual_gbx.Size = new System.Drawing.Size(125, 38);
            this.Actual_gbx.TabIndex = 14;
            this.Actual_gbx.TabStop = false;
            // 
            // MontoActual_lbl
            // 
            this.MontoActual_lbl.AutoSize = true;
            this.MontoActual_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoActual_lbl.Location = new System.Drawing.Point(30, 11);
            this.MontoActual_lbl.Name = "MontoActual_lbl";
            this.MontoActual_lbl.Size = new System.Drawing.Size(24, 18);
            this.MontoActual_lbl.TabIndex = 0;
            this.MontoActual_lbl.Text = "$0";
            // 
            // Actua_lbl
            // 
            this.Actua_lbl.AutoSize = true;
            this.Actua_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actua_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Actua_lbl.Location = new System.Drawing.Point(39, 99);
            this.Actua_lbl.Name = "Actua_lbl";
            this.Actua_lbl.Size = new System.Drawing.Size(103, 20);
            this.Actua_lbl.TabIndex = 15;
            this.Actua_lbl.Text = "Monto Actual";
            this.Actua_lbl.Click += new System.EventHandler(this.Actua_lbl_Click);
            // 
            // Prorrateo_gbx
            // 
            this.Prorrateo_gbx.Controls.Add(this.porrateo_lbl);
            this.Prorrateo_gbx.Location = new System.Drawing.Point(22, 38);
            this.Prorrateo_gbx.Name = "Prorrateo_gbx";
            this.Prorrateo_gbx.Size = new System.Drawing.Size(125, 38);
            this.Prorrateo_gbx.TabIndex = 0;
            this.Prorrateo_gbx.TabStop = false;
            // 
            // porrateo_lbl
            // 
            this.porrateo_lbl.AutoSize = true;
            this.porrateo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porrateo_lbl.Location = new System.Drawing.Point(40, 11);
            this.porrateo_lbl.Name = "porrateo_lbl";
            this.porrateo_lbl.Size = new System.Drawing.Size(29, 18);
            this.porrateo_lbl.TabIndex = 0;
            this.porrateo_lbl.Text = "5%";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.Datos_gbx);
            this.Controls.Add(this.Mensaje_gbx);
            this.Controls.Add(this.Ateka_lbl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Mensaje_gbx.ResumeLayout(false);
            this.Mensaje_gbx.PerformLayout();
            this.Datos_gbx.ResumeLayout(false);
            this.Datos_gbx.PerformLayout();
            this.Pago_anterior_gbx.ResumeLayout(false);
            this.Pago_anterior_gbx.PerformLayout();
            this.Actual_gbx.ResumeLayout(false);
            this.Actual_gbx.PerformLayout();
            this.Prorrateo_gbx.ResumeLayout(false);
            this.Prorrateo_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ateka_lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Nombre_smi;
        private System.Windows.Forms.ToolStripMenuItem Unidad_smi;
        private System.Windows.Forms.ToolStripMenuItem Comunidad_smi;
        private System.Windows.Forms.ToolStripMenuItem Vacio_smi;
        private System.Windows.Forms.ToolStripMenuItem Inicio_smi;
        private System.Windows.Forms.ToolStripMenuItem gastosComunes_smi;
        private System.Windows.Forms.ToolStripMenuItem revisarColillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Datos_smi;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPagoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Cerrar_sesion_smi;
        private System.Windows.Forms.GroupBox Mensaje_gbx;
        private System.Windows.Forms.Label porcentaje_lbl;
        private System.Windows.Forms.GroupBox Datos_gbx;
        private System.Windows.Forms.GroupBox Prorrateo_gbx;
        private System.Windows.Forms.Label porrateo_lbl;
        private System.Windows.Forms.GroupBox Pago_anterior_gbx;
        private System.Windows.Forms.Label Pago_anterior_lbl;
        private System.Windows.Forms.Label Anterior_lbl;
        private System.Windows.Forms.GroupBox Actual_gbx;
        private System.Windows.Forms.Label MontoActual_lbl;
        private System.Windows.Forms.Label Actua_lbl;
        private System.Windows.Forms.Label RestoMensaje_lbl;
        private System.Windows.Forms.Label Titulo2_lbl;
        private System.Windows.Forms.Label Titulo_lbl;
    }
}