using System.Windows.Forms;
using System.Diagnostics;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace VulkanInfo_GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private async void GetInfoButton_ClickAsync(object sender, EventArgs e)
		{
			string fileNotFoundMessage = "Could not find VulkanInfo, make sure the Vulkan Runtime is installed.";
			string fileNotFoundCaption = "File not found";

			string vkInfoOutput = string.Empty;

			using (var vkInfoProc = new Process())
			{
				vkInfoProc.StartInfo.UseShellExecute = false;
				vkInfoProc.StartInfo.RedirectStandardOutput = true;
				vkInfoProc.StartInfo.CreateNoWindow = true;

				vkInfoProc.StartInfo.FileName = "cmd.exe";

				string vkInfoExeName = Environment.Is64BitOperatingSystem ? "vulkaninfo.exe" : "vulkaninfo32.exe";
				vkInfoProc.StartInfo.Arguments = "/c \"" + vkInfoExeName + "\"";
				
				try
				{
					vkInfoProc.Start();

					getInfoButton.Enabled = false;

					infoTextBox.Text = await vkInfoProc.StandardOutput.ReadToEndAsync();

					vkInfoProc.Dispose();

					getInfoButton.Enabled = false;
					saveToFileButton.Enabled = true;
				}
				catch(Win32Exception)
				{
					MessageBox.Show(fileNotFoundMessage,
						fileNotFoundCaption,
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}
		}

		private void SaveToFileButton_Click(object sender, EventArgs e)
		{
			if(saveInfoDialog.ShowDialog() == DialogResult.OK)
				File.WriteAllText(saveInfoDialog.FileName, infoTextBox.Text);
		}
	}
}
