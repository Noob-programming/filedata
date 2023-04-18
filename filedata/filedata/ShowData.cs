namespace filedata
{
	using System;
	using System.Collections.Generic;

	internal class ShowData
	{
		private List<string> ID;

		private List<string> Name;

		private List<string> Stage;

		public ShowData()
		{
			ID = ReadOnly.ID;
			Name = ReadOnly.Name;
			Stage = ReadOnly.Stage;
		}

		public void Show()
		{
			Console.WriteLine("ID\t Name\t Stage");
			for (int i = 0; i < ID.Count; i++)
			{
				Console.WriteLine($"{ID[i]}\t{Name[i]}\t {Stage[i]}");
			}
		}

	}
}