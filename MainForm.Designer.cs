namespace VulkanInfo_GUI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.getInfoButton = new System.Windows.Forms.Button();
			this.infoTextBox = new System.Windows.Forms.RichTextBox();
			this.saveToFileButton = new System.Windows.Forms.Button();
			this.saveInfoDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// getInfoButton
			// 
			this.getInfoButton.Location = new System.Drawing.Point(12, 12);
			this.getInfoButton.Name = "getInfoButton";
			this.getInfoButton.Size = new System.Drawing.Size(108, 23);
			this.getInfoButton.TabIndex = 0;
			this.getInfoButton.Text = "Run VulkanInfo";
			this.getInfoButton.UseVisualStyleBackColor = true;
			this.getInfoButton.Click += new System.EventHandler(this.GetInfoButton_Click);
			// 
			// infoTextBox
			// 
			this.infoTextBox.Location = new System.Drawing.Point(12, 41);
			this.infoTextBox.Name = "infoTextBox";
			this.infoTextBox.ReadOnly = true;
			this.infoTextBox.Size = new System.Drawing.Size(760, 508);
			this.infoTextBox.TabIndex = 1;
			this.infoTextBox.Text = "";
			// 
			// saveToFileButton
			// 
			this.saveToFileButton.Enabled = false;
			this.saveToFileButton.Location = new System.Drawing.Point(127, 12);
			this.saveToFileButton.Name = "saveToFileButton";
			this.saveToFileButton.Size = new System.Drawing.Size(75, 23);
			this.saveToFileButton.TabIndex = 2;
			this.saveToFileButton.Text = "Save as...";
			this.saveToFileButton.UseVisualStyleBackColor = true;
			this.saveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
			// 
			// saveInfoDialog
			// 
			this.saveInfoDialog.DefaultExt = "txt";
			this.saveInfoDialog.FileName = "VulkanInfo";
			this.saveInfoDialog.Filter = "Text File|.txt|All files|*.*";
			this.saveInfoDialog.Title = "Save Vulkan Information";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.saveToFileButton);
			this.Controls.Add(this.infoTextBox);
			this.Controls.Add(this.getInfoButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VulkanInfo - GUI";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button getInfoButton;
		private System.Windows.Forms.RichTextBox infoTextBox;
		private System.Windows.Forms.Button saveToFileButton;
		private System.Windows.Forms.SaveFileDialog saveInfoDialog;
	}
}

