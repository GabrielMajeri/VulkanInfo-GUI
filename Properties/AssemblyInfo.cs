using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("VulkanInfo GUI")]
[assembly: AssemblyDescription("Small program to obtain information from the Vulkan Runtime.")]

#if DEBUG
	[assembly: AssemblyConfiguration("Debug")]
#else
	[assembly: AssemblyConfiguration("Release")]
#endif
	
[assembly: AssemblyProduct("Graphical User Interface for VulkanInfo")]
[assembly: AssemblyCopyright("Copyright © 2016 - 2017")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: AssemblyVersion("1.1.0.0")]
