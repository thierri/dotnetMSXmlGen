using System;
using System.Diagnostics;
using System.Runtime.Loader;

namespace dotnetPOC
{
	class Utils
	{
		public void GenerateClsFromXSD(string filename){
			string cmd = "xsd " + filename + ".xsd /c";
			var escapedArgs = cmd.Replace("\"", "\\\"");
			var process = new Process()
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "/bin/bash",
					Arguments = $"-c \"{escapedArgs}\"",
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true,
				}
			};
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
		}
	}
}