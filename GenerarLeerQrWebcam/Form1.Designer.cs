
namespace GenerarLeerQrWebcam
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
      this.txtTexto = new System.Windows.Forms.TextBox();
      this.cbCamara = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pbImagen = new System.Windows.Forms.PictureBox();
      this.btnIniciar = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
      this.SuspendLayout();
      // 
      // txtTexto
      // 
      this.txtTexto.Location = new System.Drawing.Point(15, 52);
      this.txtTexto.Name = "txtTexto";
      this.txtTexto.ReadOnly = true;
      this.txtTexto.Size = new System.Drawing.Size(359, 20);
      this.txtTexto.TabIndex = 0;
      // 
      // cbCamara
      // 
      this.cbCamara.FormattingEnabled = true;
      this.cbCamara.Location = new System.Drawing.Point(15, 25);
      this.cbCamara.Name = "cbCamara";
      this.cbCamara.Size = new System.Drawing.Size(278, 21);
      this.cbCamara.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Camara";
      // 
      // pbImagen
      // 
      this.pbImagen.Location = new System.Drawing.Point(15, 92);
      this.pbImagen.Name = "pbImagen";
      this.pbImagen.Size = new System.Drawing.Size(359, 326);
      this.pbImagen.TabIndex = 3;
      this.pbImagen.TabStop = false;
      // 
      // btnIniciar
      // 
      this.btnIniciar.Location = new System.Drawing.Point(299, 25);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(75, 23);
      this.btnIniciar.TabIndex = 4;
      this.btnIniciar.Text = "Iniciar";
      this.btnIniciar.UseVisualStyleBackColor = true;
      this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 430);
      this.Controls.Add(this.btnIniciar);
      this.Controls.Add(this.pbImagen);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbCamara);
      this.Controls.Add(this.txtTexto);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Leer codigo QR usando la webcam";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtTexto;
    private System.Windows.Forms.ComboBox cbCamara;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pbImagen;
    private System.Windows.Forms.Button btnIniciar;
    private System.Windows.Forms.Timer timer1;
  }
}

