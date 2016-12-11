namespace grayCode
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonStart = new System.Windows.Forms.Button();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.textBoxRec = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNonRec = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(105, 51);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 0;
			this.buttonStart.Text = "Вывести код";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(12, 25);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(100, 20);
			this.textBoxInput.TabIndex = 1;
			// 
			// textBoxRec
			// 
			this.textBoxRec.Location = new System.Drawing.Point(12, 103);
			this.textBoxRec.Multiline = true;
			this.textBoxRec.Name = "textBoxRec";
			this.textBoxRec.ReadOnly = true;
			this.textBoxRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxRec.Size = new System.Drawing.Size(126, 215);
			this.textBoxRec.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Количество разрядов кода Грея";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Рекурсивный результат";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(153, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Нерекурсивный результат";
			// 
			// textBoxNonRec
			// 
			this.textBoxNonRec.Location = new System.Drawing.Point(161, 103);
			this.textBoxNonRec.Multiline = true;
			this.textBoxNonRec.Name = "textBoxNonRec";
			this.textBoxNonRec.ReadOnly = true;
			this.textBoxNonRec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxNonRec.Size = new System.Drawing.Size(126, 215);
			this.textBoxNonRec.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 330);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxNonRec);
			this.Controls.Add(this.textBoxRec);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.buttonStart);
			this.Name = "Form1";
			this.Text = "Генератор кода Грея";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.TextBox textBoxRec;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxNonRec;
	}
}

