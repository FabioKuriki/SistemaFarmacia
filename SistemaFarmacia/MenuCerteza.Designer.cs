namespace SistemaFarmacia
{
    partial class MenuCerteza
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
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSim = new System.Windows.Forms.Button();
            this.botaoNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tem Certeza?\r\n";
            // 
            // botaoSim
            // 
            this.botaoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSim.Location = new System.Drawing.Point(33, 97);
            this.botaoSim.Name = "botaoSim";
            this.botaoSim.Size = new System.Drawing.Size(95, 59);
            this.botaoSim.TabIndex = 1;
            this.botaoSim.Text = "Sim";
            this.botaoSim.UseVisualStyleBackColor = true;
            this.botaoSim.Click += new System.EventHandler(this.botaoSim_Click);
            // 
            // botaoNao
            // 
            this.botaoNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNao.Location = new System.Drawing.Point(156, 97);
            this.botaoNao.Name = "botaoNao";
            this.botaoNao.Size = new System.Drawing.Size(95, 59);
            this.botaoNao.TabIndex = 2;
            this.botaoNao.Text = "Não";
            this.botaoNao.UseVisualStyleBackColor = true;
            this.botaoNao.Click += new System.EventHandler(this.botaoNao_Click);
            // 
            // MenuCerteza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 203);
            this.Controls.Add(this.botaoNao);
            this.Controls.Add(this.botaoSim);
            this.Controls.Add(this.label1);
            this.Name = "MenuCerteza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoNao;
        public System.Windows.Forms.Button botaoSim;
    }
}