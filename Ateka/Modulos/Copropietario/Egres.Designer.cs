namespace Ateka.Modulos.Copropietario
{
    partial class Egres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Egres));
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
            this.Datos_unidad_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Cerrar_sesion_smi = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensaje_lbl = new System.Windows.Forms.GroupBox();
            this.Deuda_anterior_lbl = new System.Windows.Forms.Label();
            this.Monto_anterior_gbx = new System.Windows.Forms.GroupBox();
            this.Monto_anterior_lbl = new System.Windows.Forms.Label();
            this.Periodo_cbx = new System.Windows.Forms.ComboBox();
            this.Periodo_lbl = new System.Windows.Forms.Label();
            this.Total_deuda_lbl = new System.Windows.Forms.Label();
            this.Deuda_total_gbx = new System.Windows.Forms.GroupBox();
            this.Monto_actual_lbl = new System.Windows.Forms.Label();
            this.Egresos2_lbl = new System.Windows.Forms.Label();
            this.Egreso_gbx = new System.Windows.Forms.GroupBox();
            this.Descripcipn_egreso_lbl = new System.Windows.Forms.Label();
            this.Dewcrpcion_egreso_gbx = new System.Windows.Forms.DataGridView();
            this.Total_egresos_lbl = new System.Windows.Forms.Label();
            this.Monto_dgb = new System.Windows.Forms.DataGridView();
            this.Egreso_dgv = new System.Windows.Forms.DataGridView();
            this.Monto_egreso_lbl = new System.Windows.Forms.Label();
            this.Egreso_lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.Mensaje_lbl.SuspendLayout();
            this.Monto_anterior_gbx.SuspendLayout();
            this.Deuda_total_gbx.SuspendLayout();
            this.Egreso_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dewcrpcion_egreso_gbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monto_dgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egreso_dgv)).BeginInit();
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
            this.Ateka_lbl.TabIndex = 5;
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
            this.Datos_unidad_smi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 31);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(148, 509);
            this.menuStrip1.TabIndex = 3;
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
            // Datos_unidad_smi
            // 
            this.Datos_unidad_smi.Name = "Datos_unidad_smi";
            this.Datos_unidad_smi.Size = new System.Drawing.Size(135, 19);
            this.Datos_unidad_smi.Text = "Visualizar Datos Unidad";
            this.Datos_unidad_smi.Click += new System.EventHandler(this.Datos_unidad_smi_Click);
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
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Cerrar_sesion_smi
            // 
            this.Cerrar_sesion_smi.ForeColor = System.Drawing.Color.White;
            this.Cerrar_sesion_smi.Name = "Cerrar_sesion_smi";
            this.Cerrar_sesion_smi.Size = new System.Drawing.Size(41, 19);
            this.Cerrar_sesion_smi.Text = "Salir";
            this.Cerrar_sesion_smi.Click += new System.EventHandler(this.Cerrar_sesion_smi_Click);
            // 
            // Mensaje_lbl
            // 
            this.Mensaje_lbl.Controls.Add(this.Deuda_anterior_lbl);
            this.Mensaje_lbl.Controls.Add(this.Monto_anterior_gbx);
            this.Mensaje_lbl.Controls.Add(this.Periodo_cbx);
            this.Mensaje_lbl.Controls.Add(this.Periodo_lbl);
            this.Mensaje_lbl.Controls.Add(this.Total_deuda_lbl);
            this.Mensaje_lbl.Controls.Add(this.Deuda_total_gbx);
            this.Mensaje_lbl.Location = new System.Drawing.Point(151, 34);
            this.Mensaje_lbl.Name = "Mensaje_lbl";
            this.Mensaje_lbl.Size = new System.Drawing.Size(827, 88);
            this.Mensaje_lbl.TabIndex = 10;
            this.Mensaje_lbl.TabStop = false;
            // 
            // Deuda_anterior_lbl
            // 
            this.Deuda_anterior_lbl.AutoSize = true;
            this.Deuda_anterior_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deuda_anterior_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Deuda_anterior_lbl.Location = new System.Drawing.Point(405, 16);
            this.Deuda_anterior_lbl.Name = "Deuda_anterior_lbl";
            this.Deuda_anterior_lbl.Size = new System.Drawing.Size(106, 18);
            this.Deuda_anterior_lbl.TabIndex = 5;
            this.Deuda_anterior_lbl.Text = "Monto Anterior";
            // 
            // Monto_anterior_gbx
            // 
            this.Monto_anterior_gbx.Controls.Add(this.Monto_anterior_lbl);
            this.Monto_anterior_gbx.Location = new System.Drawing.Point(393, 33);
            this.Monto_anterior_gbx.Name = "Monto_anterior_gbx";
            this.Monto_anterior_gbx.Size = new System.Drawing.Size(152, 49);
            this.Monto_anterior_gbx.TabIndex = 4;
            this.Monto_anterior_gbx.TabStop = false;
            // 
            // Monto_anterior_lbl
            // 
            this.Monto_anterior_lbl.AutoSize = true;
            this.Monto_anterior_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto_anterior_lbl.Location = new System.Drawing.Point(41, 17);
            this.Monto_anterior_lbl.Name = "Monto_anterior_lbl";
            this.Monto_anterior_lbl.Size = new System.Drawing.Size(24, 18);
            this.Monto_anterior_lbl.TabIndex = 4;
            this.Monto_anterior_lbl.Text = "$0";
            // 
            // Periodo_cbx
            // 
            this.Periodo_cbx.FormattingEnabled = true;
            this.Periodo_cbx.Location = new System.Drawing.Point(27, 51);
            this.Periodo_cbx.Name = "Periodo_cbx";
            this.Periodo_cbx.Size = new System.Drawing.Size(121, 21);
            this.Periodo_cbx.TabIndex = 3;
            this.Periodo_cbx.SelectedIndexChanged += new System.EventHandler(this.Periodo_cbx_SelectedIndexChanged);
            // 
            // Periodo_lbl
            // 
            this.Periodo_lbl.AutoSize = true;
            this.Periodo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Periodo_lbl.Location = new System.Drawing.Point(24, 20);
            this.Periodo_lbl.Name = "Periodo_lbl";
            this.Periodo_lbl.Size = new System.Drawing.Size(129, 18);
            this.Periodo_lbl.TabIndex = 2;
            this.Periodo_lbl.Text = "Selecione Periodo";
            // 
            // Total_deuda_lbl
            // 
            this.Total_deuda_lbl.AutoSize = true;
            this.Total_deuda_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_deuda_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Total_deuda_lbl.Location = new System.Drawing.Point(239, 16);
            this.Total_deuda_lbl.Name = "Total_deuda_lbl";
            this.Total_deuda_lbl.Size = new System.Drawing.Size(88, 18);
            this.Total_deuda_lbl.TabIndex = 1;
            this.Total_deuda_lbl.Text = "Deuda Total";
            // 
            // Deuda_total_gbx
            // 
            this.Deuda_total_gbx.Controls.Add(this.Monto_actual_lbl);
            this.Deuda_total_gbx.Location = new System.Drawing.Point(209, 33);
            this.Deuda_total_gbx.Name = "Deuda_total_gbx";
            this.Deuda_total_gbx.Size = new System.Drawing.Size(152, 49);
            this.Deuda_total_gbx.TabIndex = 0;
            this.Deuda_total_gbx.TabStop = false;
            // 
            // Monto_actual_lbl
            // 
            this.Monto_actual_lbl.AutoSize = true;
            this.Monto_actual_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto_actual_lbl.Location = new System.Drawing.Point(41, 17);
            this.Monto_actual_lbl.Name = "Monto_actual_lbl";
            this.Monto_actual_lbl.Size = new System.Drawing.Size(0, 18);
            this.Monto_actual_lbl.TabIndex = 4;
            // 
            // Egresos2_lbl
            // 
            this.Egresos2_lbl.AutoSize = true;
            this.Egresos2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egresos2_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Egresos2_lbl.Location = new System.Drawing.Point(282, 138);
            this.Egresos2_lbl.Name = "Egresos2_lbl";
            this.Egresos2_lbl.Size = new System.Drawing.Size(315, 25);
            this.Egresos2_lbl.TabIndex = 9;
            this.Egresos2_lbl.Text = "Total Egresos de la Comunidad";
            // 
            // Egreso_gbx
            // 
            this.Egreso_gbx.Controls.Add(this.Descripcipn_egreso_lbl);
            this.Egreso_gbx.Controls.Add(this.Dewcrpcion_egreso_gbx);
            this.Egreso_gbx.Controls.Add(this.Total_egresos_lbl);
            this.Egreso_gbx.Controls.Add(this.Monto_dgb);
            this.Egreso_gbx.Controls.Add(this.Egreso_dgv);
            this.Egreso_gbx.Controls.Add(this.Monto_egreso_lbl);
            this.Egreso_gbx.Controls.Add(this.Egreso_lbl);
            this.Egreso_gbx.Location = new System.Drawing.Point(238, 166);
            this.Egreso_gbx.Name = "Egreso_gbx";
            this.Egreso_gbx.Size = new System.Drawing.Size(392, 348);
            this.Egreso_gbx.TabIndex = 8;
            this.Egreso_gbx.TabStop = false;
            // 
            // Descripcipn_egreso_lbl
            // 
            this.Descripcipn_egreso_lbl.AutoSize = true;
            this.Descripcipn_egreso_lbl.Location = new System.Drawing.Point(164, 33);
            this.Descripcipn_egreso_lbl.Name = "Descripcipn_egreso_lbl";
            this.Descripcipn_egreso_lbl.Size = new System.Drawing.Size(61, 13);
            this.Descripcipn_egreso_lbl.TabIndex = 6;
            this.Descripcipn_egreso_lbl.Text = "Descrpcion";
            // 
            // Dewcrpcion_egreso_gbx
            // 
            this.Dewcrpcion_egreso_gbx.AllowUserToAddRows = false;
            this.Dewcrpcion_egreso_gbx.AllowUserToDeleteRows = false;
            this.Dewcrpcion_egreso_gbx.AllowUserToResizeColumns = false;
            this.Dewcrpcion_egreso_gbx.AllowUserToResizeRows = false;
            this.Dewcrpcion_egreso_gbx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dewcrpcion_egreso_gbx.BackgroundColor = System.Drawing.Color.White;
            this.Dewcrpcion_egreso_gbx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dewcrpcion_egreso_gbx.ColumnHeadersVisible = false;
            this.Dewcrpcion_egreso_gbx.Location = new System.Drawing.Point(123, 59);
            this.Dewcrpcion_egreso_gbx.Name = "Dewcrpcion_egreso_gbx";
            this.Dewcrpcion_egreso_gbx.ReadOnly = true;
            this.Dewcrpcion_egreso_gbx.RowHeadersVisible = false;
            this.Dewcrpcion_egreso_gbx.Size = new System.Drawing.Size(137, 181);
            this.Dewcrpcion_egreso_gbx.TabIndex = 5;
            // 
            // Total_egresos_lbl
            // 
            this.Total_egresos_lbl.AutoSize = true;
            this.Total_egresos_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_egresos_lbl.Location = new System.Drawing.Point(137, 256);
            this.Total_egresos_lbl.Name = "Total_egresos_lbl";
            this.Total_egresos_lbl.Size = new System.Drawing.Size(180, 16);
            this.Total_egresos_lbl.TabIndex = 4;
            this.Total_egresos_lbl.Text = "Total hasta la fecha: %monto";
            // 
            // Monto_dgb
            // 
            this.Monto_dgb.AllowUserToAddRows = false;
            this.Monto_dgb.AllowUserToDeleteRows = false;
            this.Monto_dgb.AllowUserToResizeColumns = false;
            this.Monto_dgb.AllowUserToResizeRows = false;
            this.Monto_dgb.BackgroundColor = System.Drawing.Color.White;
            this.Monto_dgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Monto_dgb.ColumnHeadersVisible = false;
            this.Monto_dgb.Location = new System.Drawing.Point(270, 59);
            this.Monto_dgb.Name = "Monto_dgb";
            this.Monto_dgb.ReadOnly = true;
            this.Monto_dgb.RowHeadersVisible = false;
            this.Monto_dgb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Monto_dgb.Size = new System.Drawing.Size(89, 181);
            this.Monto_dgb.TabIndex = 3;
            // 
            // Egreso_dgv
            // 
            this.Egreso_dgv.AllowUserToAddRows = false;
            this.Egreso_dgv.AllowUserToDeleteRows = false;
            this.Egreso_dgv.AllowUserToResizeColumns = false;
            this.Egreso_dgv.AllowUserToResizeRows = false;
            this.Egreso_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Egreso_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Egreso_dgv.ColumnHeadersVisible = false;
            this.Egreso_dgv.Location = new System.Drawing.Point(17, 59);
            this.Egreso_dgv.Name = "Egreso_dgv";
            this.Egreso_dgv.ReadOnly = true;
            this.Egreso_dgv.RowHeadersVisible = false;
            this.Egreso_dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Egreso_dgv.Size = new System.Drawing.Size(91, 181);
            this.Egreso_dgv.TabIndex = 2;
            // 
            // Monto_egreso_lbl
            // 
            this.Monto_egreso_lbl.AutoSize = true;
            this.Monto_egreso_lbl.Location = new System.Drawing.Point(292, 33);
            this.Monto_egreso_lbl.Name = "Monto_egreso_lbl";
            this.Monto_egreso_lbl.Size = new System.Drawing.Size(37, 13);
            this.Monto_egreso_lbl.TabIndex = 1;
            this.Monto_egreso_lbl.Text = "Monto";
            // 
            // Egreso_lbl
            // 
            this.Egreso_lbl.AutoSize = true;
            this.Egreso_lbl.Location = new System.Drawing.Point(34, 33);
            this.Egreso_lbl.Name = "Egreso_lbl";
            this.Egreso_lbl.Size = new System.Drawing.Size(45, 13);
            this.Egreso_lbl.TabIndex = 0;
            this.Egreso_lbl.Text = "Egresos";
            // 
            // Egres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.Mensaje_lbl);
            this.Controls.Add(this.Egresos2_lbl);
            this.Controls.Add(this.Egreso_gbx);
            this.Controls.Add(this.Ateka_lbl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Egres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egres";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Mensaje_lbl.ResumeLayout(false);
            this.Mensaje_lbl.PerformLayout();
            this.Monto_anterior_gbx.ResumeLayout(false);
            this.Monto_anterior_gbx.PerformLayout();
            this.Deuda_total_gbx.ResumeLayout(false);
            this.Deuda_total_gbx.PerformLayout();
            this.Egreso_gbx.ResumeLayout(false);
            this.Egreso_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dewcrpcion_egreso_gbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monto_dgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Egreso_dgv)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem Datos_unidad_smi;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Cerrar_sesion_smi;
        private System.Windows.Forms.GroupBox Mensaje_lbl;
        private System.Windows.Forms.Label Deuda_anterior_lbl;
        private System.Windows.Forms.GroupBox Monto_anterior_gbx;
        private System.Windows.Forms.Label Monto_anterior_lbl;
        private System.Windows.Forms.ComboBox Periodo_cbx;
        private System.Windows.Forms.Label Periodo_lbl;
        private System.Windows.Forms.Label Total_deuda_lbl;
        private System.Windows.Forms.GroupBox Deuda_total_gbx;
        private System.Windows.Forms.Label Monto_actual_lbl;
        private System.Windows.Forms.Label Egresos2_lbl;
        private System.Windows.Forms.GroupBox Egreso_gbx;
        private System.Windows.Forms.Label Descripcipn_egreso_lbl;
        private System.Windows.Forms.DataGridView Dewcrpcion_egreso_gbx;
        private System.Windows.Forms.Label Total_egresos_lbl;
        private System.Windows.Forms.DataGridView Monto_dgb;
        private System.Windows.Forms.DataGridView Egreso_dgv;
        private System.Windows.Forms.Label Monto_egreso_lbl;
        private System.Windows.Forms.Label Egreso_lbl;
    }
}