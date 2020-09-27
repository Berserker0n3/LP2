namespace Atividade3
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbfem = new System.Windows.Forms.RadioButton();
			this.rdbmasc = new System.Windows.Forms.RadioButton();
			this.btncalc = new System.Windows.Forms.Button();
			this.mtxtalt = new System.Windows.Forms.MaskedTextBox();
			this.mtxtpeso = new System.Windows.Forms.MaskedTextBox();
			this.pbimage = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Altura";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "Peso";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
			this.groupBox1.Controls.Add(this.rdbfem);
			this.groupBox1.Controls.Add(this.rdbmasc);
			this.groupBox1.Font = new System.Drawing.Font("Adobe Devanagari", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(17, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(226, 111);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sexo";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// rdbfem
			// 
			this.rdbfem.AutoSize = true;
			this.rdbfem.Location = new System.Drawing.Point(6, 68);
			this.rdbfem.Name = "rdbfem";
			this.rdbfem.Size = new System.Drawing.Size(102, 30);
			this.rdbfem.TabIndex = 1;
			this.rdbfem.Text = "Feminino";
			this.rdbfem.UseVisualStyleBackColor = true;
			// 
			// rdbmasc
			// 
			this.rdbmasc.AutoSize = true;
			this.rdbmasc.Checked = true;
			this.rdbmasc.Location = new System.Drawing.Point(6, 32);
			this.rdbmasc.Name = "rdbmasc";
			this.rdbmasc.Size = new System.Drawing.Size(106, 30);
			this.rdbmasc.TabIndex = 0;
			this.rdbmasc.TabStop = true;
			this.rdbmasc.Text = "Masculino";
			this.rdbmasc.UseVisualStyleBackColor = true;
			this.rdbmasc.CheckedChanged += new System.EventHandler(this.rdbmasc_CheckedChanged);
			// 
			// btncalc
			// 
			this.btncalc.BackColor = System.Drawing.Color.Gainsboro;
			this.btncalc.Location = new System.Drawing.Point(17, 201);
			this.btncalc.Name = "btncalc";
			this.btncalc.Size = new System.Drawing.Size(226, 74);
			this.btncalc.TabIndex = 3;
			this.btncalc.Text = "Calcular";
			this.btncalc.UseVisualStyleBackColor = false;
			this.btncalc.Click += new System.EventHandler(this.button1_Click);
			// 
			// mtxtalt
			// 
			this.mtxtalt.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.mtxtalt.Location = new System.Drawing.Point(114, 18);
			this.mtxtalt.Mask = "000 cm";
			this.mtxtalt.Name = "mtxtalt";
			this.mtxtalt.PromptChar = ' ';
			this.mtxtalt.Size = new System.Drawing.Size(129, 20);
			this.mtxtalt.TabIndex = 4;
			this.mtxtalt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// mtxtpeso
			// 
			this.mtxtpeso.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.mtxtpeso.Location = new System.Drawing.Point(114, 58);
			this.mtxtpeso.Mask = "000 kg";
			this.mtxtpeso.Name = "mtxtpeso";
			this.mtxtpeso.PromptChar = ' ';
			this.mtxtpeso.Size = new System.Drawing.Size(129, 20);
			this.mtxtpeso.TabIndex = 5;
			this.mtxtpeso.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// pbimage
			// 
			this.pbimage.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pbimage.Location = new System.Drawing.Point(249, 18);
			this.pbimage.Name = "pbimage";
			this.pbimage.Size = new System.Drawing.Size(272, 257);
			this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbimage.TabIndex = 6;
			this.pbimage.TabStop = false;
			this.pbimage.Click += new System.EventHandler(this.pbimage_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(535, 293);
			this.Controls.Add(this.pbimage);
			this.Controls.Add(this.mtxtpeso);
			this.Controls.Add(this.mtxtalt);
			this.Controls.Add(this.btncalc);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbfem;
		private System.Windows.Forms.RadioButton rdbmasc;
		private System.Windows.Forms.Button btncalc;
		private System.Windows.Forms.MaskedTextBox mtxtalt;
		private System.Windows.Forms.MaskedTextBox mtxtpeso;
		private System.Windows.Forms.PictureBox pbimage;
	}
}

