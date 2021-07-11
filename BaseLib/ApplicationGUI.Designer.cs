
namespace CshConsoleAPI
{
	partial class ApplicationGUI
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
			this.Multiply = new System.Windows.Forms.Button();
			this.Number2Text = new System.Windows.Forms.RichTextBox();
			this.Number1Text = new System.Windows.Forms.RichTextBox();
			this.ResultText = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// Multiply
			// 
			this.Multiply.Location = new System.Drawing.Point(272, 162);
			this.Multiply.Name = "Multiply";
			this.Multiply.Size = new System.Drawing.Size(237, 47);
			this.Multiply.TabIndex = 0;
			this.Multiply.Text = "Multiply";
			this.Multiply.UseVisualStyleBackColor = true;
			this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
			// 
			// Number2Text
			// 
			this.Number2Text.Location = new System.Drawing.Point(410, 48);
			this.Number2Text.Name = "Number2Text";
			this.Number2Text.Size = new System.Drawing.Size(357, 40);
			this.Number2Text.TabIndex = 3;
			this.Number2Text.Text = "";
			// 
			// Number1Text
			// 
			this.Number1Text.Location = new System.Drawing.Point(33, 42);
			this.Number1Text.Name = "Number1Text";
			this.Number1Text.Size = new System.Drawing.Size(343, 45);
			this.Number1Text.TabIndex = 4;
			this.Number1Text.Text = "";
			// 
			// ResultText
			// 
			this.ResultText.Location = new System.Drawing.Point(182, 112);
			this.ResultText.Name = "ResultText";
			this.ResultText.Size = new System.Drawing.Size(400, 44);
			this.ResultText.TabIndex = 5;
			this.ResultText.Text = "";
			// 
			// ApplicationGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 237);
			this.Controls.Add(this.ResultText);
			this.Controls.Add(this.Number1Text);
			this.Controls.Add(this.Number2Text);
			this.Controls.Add(this.Multiply);
			this.Name = "ApplicationGUI";
			this.Text = "ApplicationGUI";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Multiply;
		private System.Windows.Forms.RichTextBox Number2Text;
		private System.Windows.Forms.RichTextBox Number1Text;
		private System.Windows.Forms.RichTextBox ResultText;
	}
}