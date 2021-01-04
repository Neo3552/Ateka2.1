namespace Ateka.Modulos.Administrador
{
    partial class Cierremes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cierremes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Nombre_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Cargo_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Comunidad_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Vacio_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Inicio_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPagoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosComunes_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarColillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ateka_lbl = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Cerrar_sesion_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensaje_gbx = new System.Windows.Forms.GroupBox();
            this.RestoMensaje_lbl = new System.Windows.Forms.Label();
            this.Titulo2_lbl = new System.Windows.Forms.Label();
            this.Titulo_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Datos_gbx = new System.Windows.Forms.GroupBox();
            this.Comuna_lbl = new System.Windows.Forms.Label();
            this.Comuna2_lbl = new System.Windows.Forms.Label();
            this.Tipo_comunidad2_lbl = new System.Windows.Forms.Label();
            this.Direccion2_lbl = new System.Windows.Forms.Label();
            this.mts_gbx = new System.Windows.Forms.GroupBox();
            this.Mts2_lbl = new System.Windows.Forms.Label();
            this.mts_lbl = new System.Windows.Forms.Label();
            this.Tipo_comunidad_lbl = new System.Windows.Forms.Label();
            this.Direccion_lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.Mensaje_gbx.SuspendLayout();
            this.Datos_gbx.SuspendLayout();
            this.mts_gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nombre_smi,
            this.Cargo_smi,
            this.Comunidad_smi,
            this.Vacio_smi,
            this.Inicio_smi,
            this.agregarPagoToolStripMenuItem1,
            this.gastosComunes_smi,
            this.cerrarMesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(114, 509);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Nombre_smi
            // 
            this.Nombre_smi.Name = "Nombre_smi";
            this.Nombre_smi.Size = new System.Drawing.Size(101, 19);
            this.Nombre_smi.Text = "$nombre";
            // 
            // Cargo_smi
            // 
            this.Cargo_smi.Name = "Cargo_smi";
            this.Cargo_smi.Size = new System.Drawing.Size(101, 19);
            this.Cargo_smi.Text = "$Unidad";
            // 
            // Comunidad_smi
            // 
            this.Comunidad_smi.Name = "Comunidad_smi";
            this.Comunidad_smi.Size = new System.Drawing.Size(101, 19);
            this.Comunidad_smi.Text = "$comunidad";
            // 
            // Vacio_smi
            // 
            this.Vacio_smi.Name = "Vacio_smi";
            this.Vacio_smi.Size = new System.Drawing.Size(101, 19);
            this.Vacio_smi.Text = "  ";
            // 
            // Inicio_smi
            // 
            this.Inicio_smi.Name = "Inicio_smi";
            this.Inicio_smi.Size = new System.Drawing.Size(113, 19);
            this.Inicio_smi.Text = "Inicio";
            this.Inicio_smi.Click += new System.EventHandler(this.Inicio_smi_Click);
            // 
            // agregarPagoToolStripMenuItem1
            // 
            this.agregarPagoToolStripMenuItem1.Name = "agregarPagoToolStripMenuItem1";
            this.agregarPagoToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.agregarPagoToolStripMenuItem1.Size = new System.Drawing.Size(113, 19);
            this.agregarPagoToolStripMenuItem1.Text = "Proveedores";
            this.agregarPagoToolStripMenuItem1.Click += new System.EventHandler(this.agregarPagoToolStripMenuItem1_Click);
            // 
            // gastosComunes_smi
            // 
            this.gastosComunes_smi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarColillasToolStripMenuItem,
            this.revisarEgresosToolStripMenuItem,
            this.ingresarCargosToolStripMenuItem});
            this.gastosComunes_smi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gastosComunes_smi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gastosComunes_smi.Name = "gastosComunes_smi";
            this.gastosComunes_smi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gastosComunes_smi.Size = new System.Drawing.Size(113, 19);
            this.gastosComunes_smi.Text = "Gastos Comunes";
            this.gastosComunes_smi.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // revisarColillasToolStripMenuItem
            // 
            this.revisarColillasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.revisarColillasToolStripMenuItem.Name = "revisarColillasToolStripMenuItem";
            this.revisarColillasToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.revisarColillasToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.revisarColillasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revisarColillasToolStripMenuItem.Text = "Revisar Colillas";
            this.revisarColillasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.revisarColillasToolStripMenuItem.Click += new System.EventHandler(this.revisarColillasToolStripMenuItem_Click);
            // 
            // revisarEgresosToolStripMenuItem
            // 
            this.revisarEgresosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.revisarEgresosToolStripMenuItem.Name = "revisarEgresosToolStripMenuItem";
            this.revisarEgresosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.revisarEgresosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revisarEgresosToolStripMenuItem.Text = "Ingresar Egresos";
            this.revisarEgresosToolStripMenuItem.Click += new System.EventHandler(this.revisarEgresosToolStripMenuItem_Click);
            // 
            // ingresarCargosToolStripMenuItem
            // 
            this.ingresarCargosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ingresarCargosToolStripMenuItem.Name = "ingresarCargosToolStripMenuItem";
            this.ingresarCargosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ingresarCargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarCargosToolStripMenuItem.Text = "Ingresar Cargos";
            this.ingresarCargosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ingresarCargosToolStripMenuItem.Click += new System.EventHandler(this.ingresarCargosToolStripMenuItem_Click);
            // 
            // cerrarMesToolStripMenuItem
            // 
            this.cerrarMesToolStripMenuItem.Name = "cerrarMesToolStripMenuItem";
            this.cerrarMesToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.cerrarMesToolStripMenuItem.Text = "Cerrar Mes";
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
            this.Ateka_lbl.TabIndex = 17;
            this.Ateka_lbl.Text = "Ateka";
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
            this.menuStrip2.TabIndex = 16;
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
            this.Mensaje_gbx.Location = new System.Drawing.Point(128, 31);
            this.Mensaje_gbx.Name = "Mensaje_gbx";
            this.Mensaje_gbx.Size = new System.Drawing.Size(834, 110);
            this.Mensaje_gbx.TabIndex = 19;
            this.Mensaje_gbx.TabStop = false;
            // 
            // RestoMensaje_lbl
            // 
            this.RestoMensaje_lbl.AutoSize = true;
            this.RestoMensaje_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoMensaje_lbl.ForeColor = System.Drawing.Color.White;
            this.RestoMensaje_lbl.Location = new System.Drawing.Point(230, 68);
            this.RestoMensaje_lbl.Name = "RestoMensaje_lbl";
            this.RestoMensaje_lbl.Size = new System.Drawing.Size(244, 24);
            this.RestoMensaje_lbl.TabIndex = 2;
            this.RestoMensaje_lbl.Text = "Este Proceso es Irreversible";
            // 
            // Titulo2_lbl
            // 
            this.Titulo2_lbl.AutoSize = true;
            this.Titulo2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo2_lbl.ForeColor = System.Drawing.Color.White;
            this.Titulo2_lbl.Location = new System.Drawing.Point(129, 44);
            this.Titulo2_lbl.Name = "Titulo2_lbl";
            this.Titulo2_lbl.Size = new System.Drawing.Size(576, 24);
            this.Titulo2_lbl.TabIndex = 1;
            this.Titulo2_lbl.Text = "Este es el Modulo para Cerrar el Mes de cobros y pasar al siguiente";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(413, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cerrar Mes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datos_gbx
            // 
            this.Datos_gbx.Controls.Add(this.Comuna_lbl);
            this.Datos_gbx.Controls.Add(this.Comuna2_lbl);
            this.Datos_gbx.Controls.Add(this.Tipo_comunidad2_lbl);
            this.Datos_gbx.Controls.Add(this.Direccion2_lbl);
            this.Datos_gbx.Controls.Add(this.mts_gbx);
            this.Datos_gbx.Controls.Add(this.mts_lbl);
            this.Datos_gbx.Controls.Add(this.Tipo_comunidad_lbl);
            this.Datos_gbx.Controls.Add(this.Direccion_lbl);
            this.Datos_gbx.Location = new System.Drawing.Point(748, 147);
            this.Datos_gbx.Name = "Datos_gbx";
            this.Datos_gbx.Size = new System.Drawing.Size(214, 393);
            this.Datos_gbx.TabIndex = 21;
            this.Datos_gbx.TabStop = false;
            // 
            // Comuna_lbl
            // 
            this.Comuna_lbl.AutoSize = true;
            this.Comuna_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comuna_lbl.ForeColor = System.Drawing.Color.Black;
            this.Comuna_lbl.Location = new System.Drawing.Point(33, 200);
            this.Comuna_lbl.Name = "Comuna_lbl";
            this.Comuna_lbl.Size = new System.Drawing.Size(24, 18);
            this.Comuna_lbl.TabIndex = 16;
            this.Comuna_lbl.Text = "$0";
            // 
            // Comuna2_lbl
            // 
            this.Comuna2_lbl.AutoSize = true;
            this.Comuna2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comuna2_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Comuna2_lbl.Location = new System.Drawing.Point(71, 162);
            this.Comuna2_lbl.Name = "Comuna2_lbl";
            this.Comuna2_lbl.Size = new System.Drawing.Size(69, 20);
            this.Comuna2_lbl.TabIndex = 17;
            this.Comuna2_lbl.Text = "Comuna";
            // 
            // Tipo_comunidad2_lbl
            // 
            this.Tipo_comunidad2_lbl.AutoSize = true;
            this.Tipo_comunidad2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo_comunidad2_lbl.ForeColor = System.Drawing.Color.Black;
            this.Tipo_comunidad2_lbl.Location = new System.Drawing.Point(48, 66);
            this.Tipo_comunidad2_lbl.Name = "Tipo_comunidad2_lbl";
            this.Tipo_comunidad2_lbl.Size = new System.Drawing.Size(24, 18);
            this.Tipo_comunidad2_lbl.TabIndex = 0;
            this.Tipo_comunidad2_lbl.Text = "$0";
            // 
            // Direccion2_lbl
            // 
            this.Direccion2_lbl.AutoSize = true;
            this.Direccion2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion2_lbl.ForeColor = System.Drawing.Color.Black;
            this.Direccion2_lbl.Location = new System.Drawing.Point(14, 129);
            this.Direccion2_lbl.Name = "Direccion2_lbl";
            this.Direccion2_lbl.Size = new System.Drawing.Size(29, 18);
            this.Direccion2_lbl.TabIndex = 0;
            this.Direccion2_lbl.Text = "5%";
            // 
            // mts_gbx
            // 
            this.mts_gbx.Controls.Add(this.Mts2_lbl);
            this.mts_gbx.Location = new System.Drawing.Point(51, 265);
            this.mts_gbx.Name = "mts_gbx";
            this.mts_gbx.Size = new System.Drawing.Size(125, 38);
            this.mts_gbx.TabIndex = 14;
            this.mts_gbx.TabStop = false;
            // 
            // Mts2_lbl
            // 
            this.Mts2_lbl.AutoSize = true;
            this.Mts2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mts2_lbl.ForeColor = System.Drawing.Color.Black;
            this.Mts2_lbl.Location = new System.Drawing.Point(30, 11);
            this.Mts2_lbl.Name = "Mts2_lbl";
            this.Mts2_lbl.Size = new System.Drawing.Size(24, 18);
            this.Mts2_lbl.TabIndex = 0;
            this.Mts2_lbl.Text = "$0";
            // 
            // mts_lbl
            // 
            this.mts_lbl.AutoSize = true;
            this.mts_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mts_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mts_lbl.Location = new System.Drawing.Point(47, 233);
            this.mts_lbl.Name = "mts_lbl";
            this.mts_lbl.Size = new System.Drawing.Size(120, 20);
            this.mts_lbl.TabIndex = 15;
            this.mts_lbl.Text = "Mts Comunidad";
            // 
            // Tipo_comunidad_lbl
            // 
            this.Tipo_comunidad_lbl.AutoSize = true;
            this.Tipo_comunidad_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo_comunidad_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Tipo_comunidad_lbl.Location = new System.Drawing.Point(53, 30);
            this.Tipo_comunidad_lbl.Name = "Tipo_comunidad_lbl";
            this.Tipo_comunidad_lbl.Size = new System.Drawing.Size(124, 20);
            this.Tipo_comunidad_lbl.TabIndex = 15;
            this.Tipo_comunidad_lbl.Text = "Tipo Comunidad";
            // 
            // Direccion_lbl
            // 
            this.Direccion_lbl.AutoSize = true;
            this.Direccion_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Direccion_lbl.Location = new System.Drawing.Point(71, 98);
            this.Direccion_lbl.Name = "Direccion_lbl";
            this.Direccion_lbl.Size = new System.Drawing.Size(75, 20);
            this.Direccion_lbl.TabIndex = 13;
            this.Direccion_lbl.Text = "Direccion";
            // 
            // Cierremes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.Datos_gbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mensaje_gbx);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Ateka_lbl);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cierremes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierremes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Mensaje_gbx.ResumeLayout(false);
            this.Mensaje_gbx.PerformLayout();
            this.Datos_gbx.ResumeLayout(false);
            this.Datos_gbx.PerformLayout();
            this.mts_gbx.ResumeLayout(false);
            this.mts_gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Nombre_smi;
        private System.Windows.Forms.ToolStripMenuItem Cargo_smi;
        private System.Windows.Forms.ToolStripMenuItem Comunidad_smi;
        private System.Windows.Forms.ToolStripMenuItem Vacio_smi;
        private System.Windows.Forms.ToolStripMenuItem Inicio_smi;
        private System.Windows.Forms.ToolStripMenuItem agregarPagoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gastosComunes_smi;
        private System.Windows.Forms.ToolStripMenuItem revisarColillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarMesToolStripMenuItem;
        private System.Windows.Forms.Label Ateka_lbl;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Cerrar_sesion_smi;
        private System.Windows.Forms.GroupBox Mensaje_gbx;
        private System.Windows.Forms.Label RestoMensaje_lbl;
        private System.Windows.Forms.Label Titulo2_lbl;
        private System.Windows.Forms.Label Titulo_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Datos_gbx;
        private System.Windows.Forms.Label Comuna_lbl;
        private System.Windows.Forms.Label Comuna2_lbl;
        private System.Windows.Forms.Label Tipo_comunidad2_lbl;
        private System.Windows.Forms.Label Direccion2_lbl;
        private System.Windows.Forms.GroupBox mts_gbx;
        private System.Windows.Forms.Label Mts2_lbl;
        private System.Windows.Forms.Label mts_lbl;
        private System.Windows.Forms.Label Tipo_comunidad_lbl;
        private System.Windows.Forms.Label Direccion_lbl;
    }
}