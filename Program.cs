using System;
using System.Diagnostics;
using System.Runtime.Loader;

namespace dotnetPOC
{
	class Program
	{
		static void Main(string[] args)
		{
			Utils teste = new Utils();
			teste.GenerateClsFromXSD("ACTC101");
			
			var myAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath("/Users/thierri/Desktop/GIT/dotnetPOC/" + filename + @".cs");
            var myType = myAssembly.GetType("ACTC101ComplexType");
			var serializer = new System.Xml.Serialization.XmlSerializer();
		}
	}
}
