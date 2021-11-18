namespace Projeto_de_3_Camadas.UI
{
    partial class Form_Loguin
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.linkEsqueceSenha = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(348, 21);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(42, 13);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "E-MAIL";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(346, 144);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(44, 13);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "SENHA";
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(301, 283);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(130, 40);
            this.btnentrar.TabIndex = 2;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(281, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(281, 206);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(168, 20);
            this.txtsenha.TabIndex = 4;
            // 
            // linkEsqueceSenha
            // 
            this.linkEsqueceSenha.AutoSize = true;
            this.linkEsqueceSenha.Location = new System.Drawing.Point(298, 379);
            this.linkEsqueceSenha.Name = "linkEsqueceSenha";
            this.linkEsqueceSenha.Size = new System.Drawing.Size(115, 13);
            this.linkEsqueceSenha.TabIndex = 5;
            this.linkEsqueceSenha.TabStop = true;
            this.linkEsqueceSenha.Text = "Esqueceu sua Senha?";
            this.linkEsqueceSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEsqueceSenha_LinkClicked);
            // 
            // Form_Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkEsqueceSenha);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblemail);
            this.Name = "Form_Loguin";
            this.Text = "Form_Loguin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.LinkLabel linkEsqueceSenha;
    }
}