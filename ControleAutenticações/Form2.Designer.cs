
namespace ControleAutenticações
{
    partial class Form2
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
            this.btnDia = new System.Windows.Forms.Button();
            this.btnUsb = new System.Windows.Forms.Button();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnBrl = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDia
            // 
            this.btnDia.Location = new System.Drawing.Point(450, 63);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(119, 77);
            this.btnDia.TabIndex = 0;
            this.btnDia.Text = "Que dia é hoje?";
            this.btnDia.UseVisualStyleBackColor = true;
            this.btnDia.Click += new System.EventHandler(this.btnDia_Click);
            // 
            // btnUsb
            // 
            this.btnUsb.Location = new System.Drawing.Point(291, 163);
            this.btnUsb.Name = "btnUsb";
            this.btnUsb.Size = new System.Drawing.Size(119, 77);
            this.btnUsb.TabIndex = 1;
            this.btnUsb.Text = "USB-BRL";
            this.btnUsb.UseVisualStyleBackColor = true;
            this.btnUsb.Click += new System.EventHandler(this.btnUsb_Click);
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(291, 63);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(119, 77);
            this.btnHora.TabIndex = 2;
            this.btnHora.Text = "Que horas são?";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnBrl
            // 
            this.btnBrl.Location = new System.Drawing.Point(450, 163);
            this.btnBrl.Name = "btnBrl";
            this.btnBrl.Size = new System.Drawing.Size(119, 77);
            this.btnBrl.TabIndex = 3;
            this.btnBrl.Text = "BRL-USB";
            this.btnBrl.UseVisualStyleBackColor = true;
            this.btnBrl.Click += new System.EventHandler(this.btnBrl_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(351, 334);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 77);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(408, 272);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(140, 20);
            this.txtCep.TabIndex = 5;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(336, 275);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(26, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "Cep";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBrl);
            this.Controls.Add(this.btnHora);
            this.Controls.Add(this.btnUsb);
            this.Controls.Add(this.btnDia);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnUsb;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnBrl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
    }
}