namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboxCasado = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RDBMasc = new System.Windows.Forms.RadioButton();
            this.RDBFem = new System.Windows.Forms.RadioButton();
            this.CalcBT = new System.Windows.Forms.Button();
            this.TXTboxFilhos = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTboxSal = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTboxName = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTboxDescIRPF = new System.Windows.Forms.MaskedTextBox();
            this.TXTboxDescINSS = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTboxSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.TXTboxAliIRPF = new System.Windows.Forms.MaskedTextBox();
            this.TXTboxSalFam = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTboxAliINSS = new System.Windows.Forms.MaskedTextBox();
            this.TXTboxResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TXTboxName);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CalcBT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXTboxFilhos);
            this.groupBox1.Controls.Add(this.TXTboxSal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 180);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CboxCasado);
            this.groupBox2.Location = new System.Drawing.Point(293, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 57);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // CboxCasado
            // 
            this.CboxCasado.AutoSize = true;
            this.CboxCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxCasado.Location = new System.Drawing.Point(37, 19);
            this.CboxCasado.Name = "CboxCasado";
            this.CboxCasado.Size = new System.Drawing.Size(89, 24);
            this.CboxCasado.TabIndex = 9;
            this.CboxCasado.Text = "Casado";
            this.CboxCasado.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RDBMasc);
            this.groupBox3.Controls.Add(this.RDBFem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(293, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 90);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // RDBMasc
            // 
            this.RDBMasc.AutoSize = true;
            this.RDBMasc.Location = new System.Drawing.Point(19, 55);
            this.RDBMasc.Name = "RDBMasc";
            this.RDBMasc.Size = new System.Drawing.Size(107, 24);
            this.RDBMasc.TabIndex = 1;
            this.RDBMasc.Text = "Masculino";
            this.RDBMasc.UseVisualStyleBackColor = true;
            // 
            // RDBFem
            // 
            this.RDBFem.AutoSize = true;
            this.RDBFem.Checked = true;
            this.RDBFem.Location = new System.Drawing.Point(19, 25);
            this.RDBFem.Name = "RDBFem";
            this.RDBFem.Size = new System.Drawing.Size(100, 24);
            this.RDBFem.TabIndex = 0;
            this.RDBFem.TabStop = true;
            this.RDBFem.Text = "Feminino";
            this.RDBFem.UseVisualStyleBackColor = true;
            // 
            // CalcBT
            // 
            this.CalcBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBT.Location = new System.Drawing.Point(10, 122);
            this.CalcBT.Name = "CalcBT";
            this.CalcBT.Size = new System.Drawing.Size(263, 47);
            this.CalcBT.TabIndex = 32;
            this.CalcBT.Text = "Calcular Desconto";
            this.CalcBT.UseVisualStyleBackColor = true;
            this.CalcBT.Click += new System.EventHandler(this.CalcBT_Click);
            // 
            // TXTboxFilhos
            // 
            this.TXTboxFilhos.Location = new System.Drawing.Point(191, 89);
            this.TXTboxFilhos.Mask = "00";
            this.TXTboxFilhos.Name = "TXTboxFilhos";
            this.TXTboxFilhos.Size = new System.Drawing.Size(82, 22);
            this.TXTboxFilhos.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Número de Filhos";
            // 
            // TXTboxSal
            // 
            this.TXTboxSal.Location = new System.Drawing.Point(191, 54);
            this.TXTboxSal.Mask = "00000.00";
            this.TXTboxSal.Name = "TXTboxSal";
            this.TXTboxSal.Size = new System.Drawing.Size(82, 22);
            this.TXTboxSal.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Salário Bruto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome do Funcionário";
            // 
            // TXTboxName
            // 
            this.TXTboxName.Location = new System.Drawing.Point(191, 19);
            this.TXTboxName.Name = "TXTboxName";
            this.TXTboxName.Size = new System.Drawing.Size(82, 22);
            this.TXTboxName.TabIndex = 25;
            this.TXTboxName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.TXTboxResult);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TXTboxDescIRPF);
            this.groupBox4.Controls.Add(this.TXTboxDescINSS);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TXTboxSalLiq);
            this.groupBox4.Controls.Add(this.TXTboxAliIRPF);
            this.groupBox4.Controls.Add(this.TXTboxSalFam);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TXTboxAliINSS);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 180);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descontos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(314, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Desconto IRPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(314, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Desconto INSS";
            // 
            // TXTboxDescIRPF
            // 
            this.TXTboxDescIRPF.Enabled = false;
            this.TXTboxDescIRPF.Location = new System.Drawing.Point(318, 151);
            this.TXTboxDescIRPF.Name = "TXTboxDescIRPF";
            this.TXTboxDescIRPF.Size = new System.Drawing.Size(125, 22);
            this.TXTboxDescIRPF.TabIndex = 33;
            // 
            // TXTboxDescINSS
            // 
            this.TXTboxDescINSS.Enabled = false;
            this.TXTboxDescINSS.Location = new System.Drawing.Point(318, 99);
            this.TXTboxDescINSS.Name = "TXTboxDescINSS";
            this.TXTboxDescINSS.Size = new System.Drawing.Size(125, 22);
            this.TXTboxDescINSS.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Salário Líquido";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Salário Família";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Alíquota IRPF";
            // 
            // TXTboxSalLiq
            // 
            this.TXTboxSalLiq.Enabled = false;
            this.TXTboxSalLiq.Location = new System.Drawing.Point(148, 151);
            this.TXTboxSalLiq.Name = "TXTboxSalLiq";
            this.TXTboxSalLiq.Size = new System.Drawing.Size(125, 22);
            this.TXTboxSalLiq.TabIndex = 28;
            // 
            // TXTboxAliIRPF
            // 
            this.TXTboxAliIRPF.Enabled = false;
            this.TXTboxAliIRPF.Location = new System.Drawing.Point(148, 99);
            this.TXTboxAliIRPF.Name = "TXTboxAliIRPF";
            this.TXTboxAliIRPF.Size = new System.Drawing.Size(125, 22);
            this.TXTboxAliIRPF.TabIndex = 27;
            // 
            // TXTboxSalFam
            // 
            this.TXTboxSalFam.Enabled = false;
            this.TXTboxSalFam.Location = new System.Drawing.Point(148, 125);
            this.TXTboxSalFam.Name = "TXTboxSalFam";
            this.TXTboxSalFam.Size = new System.Drawing.Size(125, 22);
            this.TXTboxSalFam.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Alíquota INSS";
            // 
            // TXTboxAliINSS
            // 
            this.TXTboxAliINSS.Enabled = false;
            this.TXTboxAliINSS.Location = new System.Drawing.Point(148, 73);
            this.TXTboxAliINSS.Name = "TXTboxAliINSS";
            this.TXTboxAliINSS.Size = new System.Drawing.Size(125, 22);
            this.TXTboxAliINSS.TabIndex = 24;
            // 
            // TXTboxResult
            // 
            this.TXTboxResult.Location = new System.Drawing.Point(10, 22);
            this.TXTboxResult.Multiline = true;
            this.TXTboxResult.Name = "TXTboxResult";
            this.TXTboxResult.Size = new System.Drawing.Size(483, 45);
            this.TXTboxResult.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 390);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CboxCasado;
        private System.Windows.Forms.MaskedTextBox TXTboxName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RDBMasc;
        private System.Windows.Forms.RadioButton RDBFem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TXTboxFilhos;
        private System.Windows.Forms.MaskedTextBox TXTboxSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox TXTboxDescIRPF;
        private System.Windows.Forms.MaskedTextBox TXTboxDescINSS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TXTboxSalLiq;
        private System.Windows.Forms.MaskedTextBox TXTboxAliIRPF;
        private System.Windows.Forms.MaskedTextBox TXTboxSalFam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TXTboxAliINSS;
        private System.Windows.Forms.TextBox TXTboxResult;
    }
}

