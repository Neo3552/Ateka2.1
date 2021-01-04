namespace Ateka
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coproietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Contrasena_txt = new System.Windows.Forms.TextBox();
            this.Nombre_txt = new System.Windows.Forms.TextBox();
            this.Nombre_lbl = new System.Windows.Forms.Label();
            this.Contrasena_lbl = new System.Windows.Forms.Label();
            this.Ingresar_btn = new System.Windows.Forms.Button();
            this.Comunidad_cbx = new System.Windows.Forms.ComboBox();
            this.Comunidad_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guion_lbl = new System.Windows.Forms.Label();
            this.Dv_txt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioSesionToolStripMenuItem
            // 
            this.inicioSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coproietarioToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.inicioSesionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inicioSesionToolStripMenuItem.Name = "inicioSesionToolStripMenuItem";
            this.inicioSesionToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.inicioSesionToolStripMenuItem.Text = "Inicio Sesion";
            // 
            // coproietarioToolStripMenuItem
            // 
            this.coproietarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.coproietarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.coproietarioToolStripMenuItem.Name = "coproietarioToolStripMenuItem";
            this.coproietarioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.coproietarioToolStripMenuItem.Text = "Coproietario";
            this.coproietarioToolStripMenuItem.Click += new System.EventHandler(this.coproietarioToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.administracionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.administracionToolStripMenuItem.Text = "Administracion";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Contrasena_txt
            // 
            this.Contrasena_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contrasena_txt.Location = new System.Drawing.Point(172, 165);
            this.Contrasena_txt.Name = "Contrasena_txt";
            this.Contrasena_txt.PasswordChar = '*';
            this.Contrasena_txt.Size = new System.Drawing.Size(100, 20);
            this.Contrasena_txt.TabIndex = 1;
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.Location = new System.Drawing.Point(172, 126);
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(100, 20);
            this.Nombre_txt.TabIndex = 2;
            // 
            // Nombre_lbl
            // 
            this.Nombre_lbl.AutoSize = true;
            this.Nombre_lbl.ForeColor = System.Drawing.Color.Black;
            this.Nombre_lbl.Location = new System.Drawing.Point(57, 129);
            this.Nombre_lbl.Name = "Nombre_lbl";
            this.Nombre_lbl.Size = new System.Drawing.Size(36, 13);
            this.Nombre_lbl.TabIndex = 3;
            this.Nombre_lbl.Text = "$texto";
            // 
            // Contrasena_lbl
            // 
            this.Contrasena_lbl.AutoSize = true;
            this.Contrasena_lbl.ForeColor = System.Drawing.Color.Black;
            this.Contrasena_lbl.Location = new System.Drawing.Point(57, 172);
            this.Contrasena_lbl.Name = "Contrasena_lbl";
            this.Contrasena_lbl.Size = new System.Drawing.Size(61, 13);
            this.Contrasena_lbl.TabIndex = 4;
            this.Contrasena_lbl.Text = "Contraseña";
            // 
            // Ingresar_btn
            // 
            this.Ingresar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Ingresar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Ingresar_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Ingresar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar_btn.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar_btn.ForeColor = System.Drawing.Color.White;
            this.Ingresar_btn.Location = new System.Drawing.Point(112, 202);
            this.Ingresar_btn.Name = "Ingresar_btn";
            this.Ingresar_btn.Size = new System.Drawing.Size(75, 26);
            this.Ingresar_btn.TabIndex = 5;
            this.Ingresar_btn.Text = "Ingresar";
            this.Ingresar_btn.UseVisualStyleBackColor = false;
            this.Ingresar_btn.Click += new System.EventHandler(this.Ingresar_btn_Click);
            // 
            // Comunidad_cbx
            // 
            this.Comunidad_cbx.FormattingEnabled = true;
            this.Comunidad_cbx.Location = new System.Drawing.Point(172, 86);
            this.Comunidad_cbx.Name = "Comunidad_cbx";
            this.Comunidad_cbx.Size = new System.Drawing.Size(111, 21);
            this.Comunidad_cbx.TabIndex = 6;
            // 
            // Comunidad_lbl
            // 
            this.Comunidad_lbl.AutoSize = true;
            this.Comunidad_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.Comunidad_lbl.Location = new System.Drawing.Point(57, 89);
            this.Comunidad_lbl.Name = "Comunidad_lbl";
            this.Comunidad_lbl.Size = new System.Drawing.Size(60, 13);
            this.Comunidad_lbl.TabIndex = 7;
            this.Comunidad_lbl.Text = "Comunidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Software de Administracion de Edificio";
            // 
            // Guion_lbl
            // 
            this.Guion_lbl.AutoSize = true;
            this.Guion_lbl.Location = new System.Drawing.Point(278, 129);
            this.Guion_lbl.Name = "Guion_lbl";
            this.Guion_lbl.Size = new System.Drawing.Size(10, 13);
            this.Guion_lbl.TabIndex = 10;
            this.Guion_lbl.Text = "-";
            this.Guion_lbl.Visible = false;
            // 
            // Dv_txt
            // 
            this.Dv_txt.Enabled = false;
            this.Dv_txt.Location = new System.Drawing.Point(294, 126);
            this.Dv_txt.Name = "Dv_txt";
            this.Dv_txt.Size = new System.Drawing.Size(19, 20);
            this.Dv_txt.TabIndex = 11;
            this.Dv_txt.Visible = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(355, 258);
            this.Controls.Add(this.Dv_txt);
            this.Controls.Add(this.Guion_lbl);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contrasena_txt);
            this.Controls.Add(this.Nombre_lbl);
            this.Controls.Add(this.Ingresar_btn);
            this.Controls.Add(this.Comunidad_lbl);
            this.Controls.Add(this.Contrasena_lbl);
            this.Controls.Add(this.Comunidad_cbx);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coproietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.TextBox Contrasena_txt;
        private System.Windows.Forms.TextBox Nombre_txt;
        private System.Windows.Forms.Label Nombre_lbl;
        private System.Windows.Forms.Label Contrasena_lbl;
        private System.Windows.Forms.Button Ingresar_btn;
        private System.Windows.Forms.ComboBox Comunidad_cbx;
        private System.Windows.Forms.Label Comunidad_lbl;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Guion_lbl;
        private System.Windows.Forms.TextBox Dv_txt;
    }
}

