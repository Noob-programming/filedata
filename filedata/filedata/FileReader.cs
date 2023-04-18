namespace filedata
{
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;

	internal static class FileReader
	{
		public static List<string> ReadFiles(string filename)
		{
			return File.ReadAllLines(filename).ToList();
		}
	}
}