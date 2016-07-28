using System;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace VulkanInfo_GUI
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			var screenSize = Screen.PrimaryScreen.WorkingArea;

			// TODO: localize this text
			var warningMessage = "Your primary monitor's resolution is less than 800x600, and is therefore unsupported. You might not be able to see all the information properly.";
			var warningCaption = "Warning - Monitor resolution is too small";

			if (screenSize.Width < 800 || screenSize.Height < 600)
				MessageBox.Show(warningMessage, warningCaption, MessageBoxButtons.OK);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
