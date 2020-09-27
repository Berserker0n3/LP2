namespace Atividade4
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textboxA = new System.Windows.Forms.TextBox();
			this.textboxB = new System.Windows.Forms.TextBox();
			this.textboxC = new System.Windows.Forms.TextBox();
			this.textboxRes = new System.Windows.Forms.TextBox();
			this.btCalc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lado A";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Lado B";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(11, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "Lado C";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(12, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "Resultado";
			// 
			// textboxA
			// 
			this.textboxA.Location = new System.Drawing.Point(83, 15);
			this.textboxA.Name = "textboxA";
			this.textboxA.Size = new System.Drawing.Size(100, 20);
			this.textboxA.TabIndex = 4;
			// 
			// textboxB
			// 
			this.textboxB.Location = new System.Drawing.Point(83, 46);
			this.textboxB.Name = "textboxB";
			this.textboxB.Size = new System.Drawing.Size(100, 20);
			this.textboxB.TabIndex = 5;
			// 
			// textboxC
			// 
			this.textboxC.Location = new System.Drawing.Point(83, 77);
			this.textboxC.Name = "textboxC";
			this.textboxC.Size = new System.Drawing.Size(100, 20);
			this.textboxC.TabIndex = 6;
			// 
			// textboxRes
			// 
			this.textboxRes.Enabled = false;
			this.textboxRes.Location = new System.Drawing.Point(103, 106);
			this.textboxRes.Name = "textboxRes";
			this.textboxRes.Size = new System.Drawing.Size(167, 20);
			this.textboxRes.TabIndex = 7;
			// 
			// btCalc
			// 
			this.btCalc.BackColor = System.Drawing.Color.DarkCyan;
			this.btCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btCalc.CausesValidation = false;
			this.btCalc.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btCalc.Location = new System.Drawing.Point(195, 12);
			this.btCalc.Name = "btCalc";
			this.btCalc.Size = new System.Drawing.Size(75, 85);
			this.btCalc.TabIndex = 8;
			this.btCalc.Text = "Calcular";
			this.btCalc.UseVisualStyleBackColor = false;
			this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(282, 139);
			this.Controls.Add(this.btCalc);
			this.Controls.Add(this.textboxRes);
			this.Controls.Add(this.textboxC);
			this.Controls.Add(this.textboxB);
			this.Controls.Add(this.textboxA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textboxA;
		private System.Windows.Forms.TextBox textboxB;
		private System.Windows.Forms.TextBox textboxC;
		private System.Windows.Forms.TextBox textboxRes;
		private System.Windows.Forms.Button btCalc;
	}
}

