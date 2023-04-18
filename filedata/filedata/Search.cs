namespace filedata
{
	using System;
	using System.Collections.Generic;

	class Search
	{
		public Search()
		{
			inserts();
		}

		private List<string> ID;

		private List<string> Name;

		private List<string> Stage;

		private void inserts()
		{
			ID = ReadOnly.ID;
			Name = ReadOnly.Name;
			Stage = ReadOnly.Stage;
		}

		public void search()
		{

			int ch = 0;
			do
			{
				Console.WriteLine("1 search by id");
				Console.WriteLine("2 search by name");
				Console.WriteLine("3 search by stage");
				ch = Convert.ToInt32(Console.ReadLine());
				switch (ch)
				{
					case 1:
						Console.WriteLine("search id : ");

						var ids = Convert.ToInt32(Console.ReadLine()).ToString();
						Searcher(ids, ID);
						break;

					case 2:
						Console.WriteLine("search Name : ");

						var name = Console.ReadLine();
						Searcher(name, Name);
						break;

					case 3:
						Console.WriteLine("search Stage");

						var stage = Console.ReadLine();
						Searcher(stage, Stage);
						break;

					default:
						break;


				}
			}
			while (ch != 4);
		}

		private void Searcher(string ids, List<string> data)
		{
			for (var i = 0; i < data.Count; i++)
			{
				if (ids == data[i])
				{
					Console.WriteLine($@"{ID[i]}, {Name[i]}, {Stage[i]}");
				}
			}
		}
	}
}