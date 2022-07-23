
namespace Graphics1310
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pizza = new System.Windows.Forms.Button();
            this.ValorHumanas = new System.Windows.Forms.TextBox();
            this.ValorExatas = new System.Windows.Forms.TextBox();
            this.ValorBiologicas = new System.Windows.Forms.TextBox();
            this.ValorAgrarias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pctH = new System.Windows.Forms.Label();
            this.pctEx = new System.Windows.Forms.Label();
            this.PctB = new System.Windows.Forms.Label();
            this.PctAg = new System.Windows.Forms.Label();
            this.Coluna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pizza
            // 
            this.Pizza.Location = new System.Drawing.Point(422, 122);
            this.Pizza.Name = "Pizza";
            this.Pizza.Size = new System.Drawing.Size(152, 47);
            this.Pizza.TabIndex = 0;
            this.Pizza.Text = "Pizza";
            this.Pizza.UseVisualStyleBackColor = true;
            this.Pizza.Click += new System.EventHandler(this.Pizza_Click);
            // 
            // ValorHumanas
            // 
            this.ValorHumanas.Location = new System.Drawing.Point(647, 59);
            this.ValorHumanas.Name = "ValorHumanas";
            this.ValorHumanas.Size = new System.Drawing.Size(100, 23);
            this.ValorHumanas.TabIndex = 1;
            // 
            // ValorExatas
            // 
            this.ValorExatas.Location = new System.Drawing.Point(647, 88);
            this.ValorExatas.Name = "ValorExatas";
            this.ValorExatas.Size = new System.Drawing.Size(100, 23);
            this.ValorExatas.TabIndex = 2;
            // 
            // ValorBiologicas
            // 
            this.ValorBiologicas.Location = new System.Drawing.Point(647, 117);
            this.ValorBiologicas.Name = "ValorBiologicas";
            this.ValorBiologicas.Size = new System.Drawing.Size(100, 23);
            this.ValorBiologicas.TabIndex = 3;
            // 
            // ValorAgrarias
            // 
            this.ValorAgrarias.Location = new System.Drawing.Point(647, 146);
            this.ValorAgrarias.Name = "ValorAgrarias";
            this.ValorAgrarias.Size = new System.Drawing.Size(100, 23);
            this.ValorAgrarias.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(580, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Humanas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(580, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Exatas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(580, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Biológicas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(583, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Agrárias";
            // 
            // pctH
            // 
            this.pctH.AutoSize = true;
            this.pctH.BackColor = System.Drawing.SystemColors.Desktop;
            this.pctH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pctH.Location = new System.Drawing.Point(12, 426);
            this.pctH.Name = "pctH";
            this.pctH.Size = new System.Drawing.Size(136, 15);
            this.pctH.TabIndex = 10;
            this.pctH.Text = "Porcentagem Humanas";
            // 
            // pctEx
            // 
            this.pctEx.AutoSize = true;
            this.pctEx.BackColor = System.Drawing.SystemColors.Highlight;
            this.pctEx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pctEx.Location = new System.Drawing.Point(154, 426);
            this.pctEx.Name = "pctEx";
            this.pctEx.Size = new System.Drawing.Size(120, 15);
            this.pctEx.TabIndex = 11;
            this.pctEx.Text = "Porcentagem Exatas";
            // 
            // PctB
            // 
            this.PctB.AutoSize = true;
            this.PctB.BackColor = System.Drawing.Color.Yellow;
            this.PctB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PctB.Location = new System.Drawing.Point(280, 426);
            this.PctB.Name = "PctB";
            this.PctB.Size = new System.Drawing.Size(140, 15);
            this.PctB.TabIndex = 12;
            this.PctB.Text = "Porcentagem Biológicas";
            // 
            // PctAg
            // 
            this.PctAg.AutoSize = true;
            this.PctAg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PctAg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PctAg.Location = new System.Drawing.Point(426, 426);
            this.PctAg.Name = "PctAg";
            this.PctAg.Size = new System.Drawing.Size(130, 15);
            this.PctAg.TabIndex = 13;
            this.PctAg.Text = "Porcentagem Agrárias";
            // 
            // Coluna
            // 
            this.Coluna.Location = new System.Drawing.Point(422, 62);
            this.Coluna.Name = "Coluna";
            this.Coluna.Size = new System.Drawing.Size(152, 49);
            this.Coluna.TabIndex = 14;
            this.Coluna.Text = "Coluna";
            this.Coluna.UseVisualStyleBackColor = true;
            this.Coluna.Click += new System.EventHandler(this.Coluna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coluna);
            this.Controls.Add(this.PctAg);
            this.Controls.Add(this.PctB);
            this.Controls.Add(this.pctEx);
            this.Controls.Add(this.pctH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorAgrarias);
            this.Controls.Add(this.ValorBiologicas);
            this.Controls.Add(this.ValorExatas);
            this.Controls.Add(this.ValorHumanas);
            this.Controls.Add(this.Pizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pizza;
        private System.Windows.Forms.TextBox ValorHumanas;
        private System.Windows.Forms.TextBox ValorExatas;
        private System.Windows.Forms.TextBox ValorBiologicas;
        private System.Windows.Forms.TextBox ValorAgrarias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pctH;
        private System.Windows.Forms.Label pctEx;
        private System.Windows.Forms.Label PctB;
        private System.Windows.Forms.Label PctAg;
        private System.Windows.Forms.Button Coluna;
    }
}

