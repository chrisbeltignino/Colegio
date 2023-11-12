
namespace FormMain
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelSIdeMenu = new System.Windows.Forms.Panel();
            panelSubMenuEstadistica = new System.Windows.Forms.Panel();
            btn_Destino = new System.Windows.Forms.Button();
            btn_CantPasajeros = new System.Windows.Forms.Button();
            btn_Recaudacion = new System.Windows.Forms.Button();
            btn_Estadisticas = new System.Windows.Forms.Button();
            panelSubMenuCruceros = new System.Windows.Forms.Panel();
            btn_InfoCruceros = new System.Windows.Forms.Button();
            btn_VenderCrucero = new System.Windows.Forms.Button();
            btn_Cruceros = new System.Windows.Forms.Button();
            panelSubMenuViajes = new System.Windows.Forms.Panel();
            btn_CrearViaje = new System.Windows.Forms.Button();
            btn_VerViajes = new System.Windows.Forms.Button();
            btn_Viajes = new System.Windows.Forms.Button();
            panelLogo = new System.Windows.Forms.Panel();
            panelFormulario = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panelSIdeMenu.SuspendLayout();
            panelSubMenuEstadistica.SuspendLayout();
            panelSubMenuCruceros.SuspendLayout();
            panelSubMenuViajes.SuspendLayout();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSIdeMenu
            // 
            panelSIdeMenu.AutoScroll = true;
            panelSIdeMenu.BackColor = System.Drawing.Color.Black;
            panelSIdeMenu.Controls.Add(panelSubMenuEstadistica);
            panelSIdeMenu.Controls.Add(btn_Estadisticas);
            panelSIdeMenu.Controls.Add(panelSubMenuCruceros);
            panelSIdeMenu.Controls.Add(btn_Cruceros);
            panelSIdeMenu.Controls.Add(panelSubMenuViajes);
            panelSIdeMenu.Controls.Add(btn_Viajes);
            panelSIdeMenu.Controls.Add(panelLogo);
            panelSIdeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelSIdeMenu.Location = new System.Drawing.Point(0, 0);
            panelSIdeMenu.Name = "panelSIdeMenu";
            panelSIdeMenu.Size = new System.Drawing.Size(200, 561);
            panelSIdeMenu.TabIndex = 6;
            // 
            // panelSubMenuEstadistica
            // 
            panelSubMenuEstadistica.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelSubMenuEstadistica.Controls.Add(btn_Destino);
            panelSubMenuEstadistica.Controls.Add(btn_CantPasajeros);
            panelSubMenuEstadistica.Controls.Add(btn_Recaudacion);
            panelSubMenuEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuEstadistica.Location = new System.Drawing.Point(0, 339);
            panelSubMenuEstadistica.Name = "panelSubMenuEstadistica";
            panelSubMenuEstadistica.Size = new System.Drawing.Size(200, 102);
            panelSubMenuEstadistica.TabIndex = 6;
            panelSubMenuEstadistica.Visible = false;
            // 
            // btn_Destino
            // 
            btn_Destino.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Destino.FlatAppearance.BorderSize = 0;
            btn_Destino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_Destino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Destino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Destino.ForeColor = System.Drawing.Color.LightGray;
            btn_Destino.Location = new System.Drawing.Point(0, 69);
            btn_Destino.Name = "btn_Destino";
            btn_Destino.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_Destino.Size = new System.Drawing.Size(200, 30);
            btn_Destino.TabIndex = 4;
            btn_Destino.Text = "Destino mas elegido";
            btn_Destino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Destino.UseVisualStyleBackColor = true;
            // 
            // btn_CantPasajeros
            // 
            btn_CantPasajeros.Dock = System.Windows.Forms.DockStyle.Top;
            btn_CantPasajeros.FlatAppearance.BorderSize = 0;
            btn_CantPasajeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_CantPasajeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_CantPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_CantPasajeros.ForeColor = System.Drawing.Color.LightGray;
            btn_CantPasajeros.Location = new System.Drawing.Point(0, 30);
            btn_CantPasajeros.Name = "btn_CantPasajeros";
            btn_CantPasajeros.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_CantPasajeros.Size = new System.Drawing.Size(200, 39);
            btn_CantPasajeros.TabIndex = 3;
            btn_CantPasajeros.Text = "Cant. de pasajeros por crucero";
            btn_CantPasajeros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_CantPasajeros.UseVisualStyleBackColor = true;
            // 
            // btn_Recaudacion
            // 
            btn_Recaudacion.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Recaudacion.FlatAppearance.BorderSize = 0;
            btn_Recaudacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_Recaudacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Recaudacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Recaudacion.ForeColor = System.Drawing.Color.LightGray;
            btn_Recaudacion.Location = new System.Drawing.Point(0, 0);
            btn_Recaudacion.Name = "btn_Recaudacion";
            btn_Recaudacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_Recaudacion.Size = new System.Drawing.Size(200, 30);
            btn_Recaudacion.TabIndex = 2;
            btn_Recaudacion.Text = "Recaudación";
            btn_Recaudacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Recaudacion.UseVisualStyleBackColor = true;
            // 
            // btn_Estadisticas
            // 
            btn_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Estadisticas.FlatAppearance.BorderSize = 0;
            btn_Estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btn_Estadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Estadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            btn_Estadisticas.Location = new System.Drawing.Point(0, 299);
            btn_Estadisticas.Name = "btn_Estadisticas";
            btn_Estadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btn_Estadisticas.Size = new System.Drawing.Size(200, 40);
            btn_Estadisticas.TabIndex = 5;
            btn_Estadisticas.Text = "Estadisticas";
            btn_Estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Estadisticas.UseVisualStyleBackColor = true;
            btn_Estadisticas.Click += btn_Estadisticas_Click;
            // 
            // panelSubMenuCruceros
            // 
            panelSubMenuCruceros.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelSubMenuCruceros.Controls.Add(btn_InfoCruceros);
            panelSubMenuCruceros.Controls.Add(btn_VenderCrucero);
            panelSubMenuCruceros.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuCruceros.Location = new System.Drawing.Point(0, 234);
            panelSubMenuCruceros.Name = "panelSubMenuCruceros";
            panelSubMenuCruceros.Size = new System.Drawing.Size(200, 65);
            panelSubMenuCruceros.TabIndex = 4;
            panelSubMenuCruceros.Visible = false;
            // 
            // btn_InfoCruceros
            // 
            btn_InfoCruceros.Dock = System.Windows.Forms.DockStyle.Top;
            btn_InfoCruceros.FlatAppearance.BorderSize = 0;
            btn_InfoCruceros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_InfoCruceros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_InfoCruceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_InfoCruceros.ForeColor = System.Drawing.Color.LightGray;
            btn_InfoCruceros.Location = new System.Drawing.Point(0, 30);
            btn_InfoCruceros.Name = "btn_InfoCruceros";
            btn_InfoCruceros.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_InfoCruceros.Size = new System.Drawing.Size(200, 32);
            btn_InfoCruceros.TabIndex = 3;
            btn_InfoCruceros.Text = "Informacion de Cruceros";
            btn_InfoCruceros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_InfoCruceros.UseVisualStyleBackColor = true;
            btn_InfoCruceros.Click += btn_InfoCruceros_Click;
            // 
            // btn_VenderCrucero
            // 
            btn_VenderCrucero.Dock = System.Windows.Forms.DockStyle.Top;
            btn_VenderCrucero.FlatAppearance.BorderSize = 0;
            btn_VenderCrucero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_VenderCrucero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_VenderCrucero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_VenderCrucero.ForeColor = System.Drawing.Color.LightGray;
            btn_VenderCrucero.Location = new System.Drawing.Point(0, 0);
            btn_VenderCrucero.Name = "btn_VenderCrucero";
            btn_VenderCrucero.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_VenderCrucero.Size = new System.Drawing.Size(200, 30);
            btn_VenderCrucero.TabIndex = 2;
            btn_VenderCrucero.Text = "Crear Crucero";
            btn_VenderCrucero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_VenderCrucero.UseVisualStyleBackColor = true;
            btn_VenderCrucero.Click += btn_VenderCrucero_Click;
            // 
            // btn_Cruceros
            // 
            btn_Cruceros.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Cruceros.FlatAppearance.BorderSize = 0;
            btn_Cruceros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btn_Cruceros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Cruceros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Cruceros.ForeColor = System.Drawing.Color.Gainsboro;
            btn_Cruceros.Location = new System.Drawing.Point(0, 194);
            btn_Cruceros.Name = "btn_Cruceros";
            btn_Cruceros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btn_Cruceros.Size = new System.Drawing.Size(200, 40);
            btn_Cruceros.TabIndex = 3;
            btn_Cruceros.Text = "Cruceros";
            btn_Cruceros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Cruceros.UseVisualStyleBackColor = true;
            btn_Cruceros.Click += btn_Cruceros_Click;
            // 
            // panelSubMenuViajes
            // 
            panelSubMenuViajes.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            panelSubMenuViajes.Controls.Add(btn_CrearViaje);
            panelSubMenuViajes.Controls.Add(btn_VerViajes);
            panelSubMenuViajes.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuViajes.Location = new System.Drawing.Point(0, 131);
            panelSubMenuViajes.Name = "panelSubMenuViajes";
            panelSubMenuViajes.Size = new System.Drawing.Size(200, 63);
            panelSubMenuViajes.TabIndex = 2;
            panelSubMenuViajes.Visible = false;
            // 
            // btn_CrearViaje
            // 
            btn_CrearViaje.Dock = System.Windows.Forms.DockStyle.Top;
            btn_CrearViaje.FlatAppearance.BorderSize = 0;
            btn_CrearViaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_CrearViaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_CrearViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_CrearViaje.ForeColor = System.Drawing.Color.LightGray;
            btn_CrearViaje.Location = new System.Drawing.Point(0, 30);
            btn_CrearViaje.Name = "btn_CrearViaje";
            btn_CrearViaje.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_CrearViaje.Size = new System.Drawing.Size(200, 30);
            btn_CrearViaje.TabIndex = 3;
            btn_CrearViaje.Text = "Vender Viaje";
            btn_CrearViaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_CrearViaje.UseVisualStyleBackColor = true;
            btn_CrearViaje.Click += btn_CrearViaje_Click;
            // 
            // btn_VerViajes
            // 
            btn_VerViajes.Dock = System.Windows.Forms.DockStyle.Top;
            btn_VerViajes.FlatAppearance.BorderSize = 0;
            btn_VerViajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            btn_VerViajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_VerViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_VerViajes.ForeColor = System.Drawing.Color.LightGray;
            btn_VerViajes.Location = new System.Drawing.Point(0, 0);
            btn_VerViajes.Name = "btn_VerViajes";
            btn_VerViajes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            btn_VerViajes.Size = new System.Drawing.Size(200, 30);
            btn_VerViajes.TabIndex = 2;
            btn_VerViajes.Text = "Ver Viajes";
            btn_VerViajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_VerViajes.UseVisualStyleBackColor = true;
            btn_VerViajes.Click += btn_VerViajes_Click;
            // 
            // btn_Viajes
            // 
            btn_Viajes.Dock = System.Windows.Forms.DockStyle.Top;
            btn_Viajes.FlatAppearance.BorderSize = 0;
            btn_Viajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            btn_Viajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btn_Viajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Viajes.ForeColor = System.Drawing.Color.Gainsboro;
            btn_Viajes.Location = new System.Drawing.Point(0, 91);
            btn_Viajes.Name = "btn_Viajes";
            btn_Viajes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btn_Viajes.Size = new System.Drawing.Size(200, 40);
            btn_Viajes.TabIndex = 1;
            btn_Viajes.Text = "Viajes";
            btn_Viajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Viajes.UseVisualStyleBackColor = true;
            btn_Viajes.Click += btn_Viajes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            panelLogo.Location = new System.Drawing.Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new System.Drawing.Size(200, 91);
            panelLogo.TabIndex = 0;
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = System.Drawing.Color.FromArgb(64, 0, 64);
            panelFormulario.Controls.Add(pictureBox1);
            panelFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            panelFormulario.Location = new System.Drawing.Point(200, 0);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new System.Drawing.Size(1101, 561);
            panelFormulario.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(333, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(428, 405);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1301, 561);
            Controls.Add(panelFormulario);
            Controls.Add(panelSIdeMenu);
            IsMdiContainer = true;
            MinimumSize = new System.Drawing.Size(900, 600);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += FormMain_Load;
            panelSIdeMenu.ResumeLayout(false);
            panelSubMenuEstadistica.ResumeLayout(false);
            panelSubMenuCruceros.ResumeLayout(false);
            panelSubMenuViajes.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelSIdeMenu;
        private System.Windows.Forms.Panel panelSubMenuViajes;
        private System.Windows.Forms.Button btn_CrearViaje;
        private System.Windows.Forms.Button btn_VerViajes;
        private System.Windows.Forms.Button btn_Viajes;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuEstadistica;
        private System.Windows.Forms.Button btn_Destino;
        private System.Windows.Forms.Button btn_CantPasajeros;
        private System.Windows.Forms.Button btn_Recaudacion;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Panel panelSubMenuCruceros;
        private System.Windows.Forms.Button btn_InfoCruceros;
        private System.Windows.Forms.Button btn_VenderCrucero;
        private System.Windows.Forms.Button btn_Cruceros;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}