namespace filedata
{
	using System;

	internal static class Program
	{

		private static void Main(string[] args)
		{
			var idFile = "id.txt";
			var nameFile = "name.txt";
			var stageFile = "stage.txt";
			try
			{
				ReadOnly.ID = FileReader.ReadFiles(idFile);
				ReadOnly.Name = FileReader.ReadFiles(nameFile);
				ReadOnly.Stage = FileReader.ReadFiles(stageFile);

				var file = new FileEditer();
				var adddata = new AddData();
				var deldata = new DElData();

				var serach = new Search();
				var ShowData = new ShowData();

				var ch = 0;
				do
				{
					Console.WriteLine("1 Add info data .");
					Console.WriteLine("2 Edit data .");
					Console.WriteLine("3 Delete data .");
					Console.WriteLine("4 search data .");
					Console.WriteLine("5 Show data .");
					Console.WriteLine("0 exit ");
					ch = Convert.ToInt32(Console.ReadLine());
					switch (ch)
					{
						case 1:
							adddata.add();
							break;
						case 2:
							file.EditData();
							break;
						case 3:
							deldata.Deleteitem();
							break;
						case 4:
							serach.search();
							break;
						case 5:
							ShowData.Show();
							break;
						default:
							break;
					}
				}
				while (ch != 0);

				Console.Read();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				FileAdding.FileAppend(idFile, ReadOnly.ID);
				FileAdding.FileAppend(nameFile, ReadOnly.Name);
				FileAdding.FileAppend(stageFile, ReadOnly.Stage);
			}
		}
	}
}