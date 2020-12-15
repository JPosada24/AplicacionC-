
namespace Memorama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelJuego = new System.Windows.Forms.Panel();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.bntReiniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego.Location = new System.Drawing.Point(12, 12);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(519, 474);
            this.panelJuego.TabIndex = 0;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Engravers MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuntaje.Location = new System.Drawing.Point(537, 76);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(212, 22);
            this.lblPuntaje.TabIndex = 1;
            this.lblPuntaje.Text = "Movimientos:";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacion.Font = new System.Drawing.Font("Engravers MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPuntuacion.Location = new System.Drawing.Point(596, 118);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(74, 75);
            this.lblPuntuacion.TabIndex = 2;
            this.lblPuntuacion.Text = "0";
            // 
            // bntReiniciar
            // 
            this.bntReiniciar.BackColor = System.Drawing.Color.CadetBlue;
            this.bntReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntReiniciar.Font = new System.Drawing.Font("Engravers MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntReiniciar.Location = new System.Drawing.Point(552, 344);
            this.bntReiniciar.Name = "bntReiniciar";
            this.bntReiniciar.Size = new System.Drawing.Size(175, 54);
            this.bntReiniciar.TabIndex = 3;
            this.bntReiniciar.Text = "Reiniciar";
            this.bntReiniciar.UseVisualStyleBackColor = false;
            this.bntReiniciar.Click += new System.EventHandler(this.bntReiniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Engravers MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(552, 416);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(175, 54);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memorama.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(750, 498);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntReiniciar);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.panelJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Memorama League of Legends";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Button bntReiniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSalir;
    }
}

