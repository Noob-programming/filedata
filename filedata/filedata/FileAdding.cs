namespace filedata
{
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;

	internal abstract class FileAdding
	{
		public static void FileAppend(string filename, List<string> cat)
		{
			File.Delete(filename);

			foreach (var t in cat.Where(t => t != string.Empty))
			{
				File.AppendAllText(filename, t);

				File.AppendAllText(filename, "\n");
			}
		}
	}
}