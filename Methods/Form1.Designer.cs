namespace Methods
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnProcessNumber = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter an Integer :";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(122, 8);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(100, 20);
			this.txtInput.TabIndex = 1;
			this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnProcessNumber
			// 
			this.btnProcessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcessNumber.Location = new System.Drawing.Point(12, 60);
			this.btnProcessNumber.Name = "btnProcessNumber";
			this.btnProcessNumber.Size = new System.Drawing.Size(165, 58);
			this.btnProcessNumber.TabIndex = 2;
			this.btnProcessNumber.Text = "Procress the Number";
			this.btnProcessNumber.UseVisualStyleBackColor = true;
			this.btnProcessNumber.Click += new System.EventHandler(this.btnProcessNumber_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(261, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(177, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "This number is divisable by :";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(264, 31);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(60, 212);
			this.listBox1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Is it a prime number?";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Prime Factors";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 314);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnProcessNumber);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnProcessNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

