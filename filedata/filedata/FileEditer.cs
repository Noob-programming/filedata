namespace filedata
{
	using System;
	using System.Collections.Generic;

	public class FileEditer
	{


		private List<string> id;

		private List<string> name;

		private List<string> stage;

		public FileEditer()
		{
			id = ReadOnly.ID;
			name = ReadOnly.Name;
			stage = ReadOnly.Stage;
		}

		void SaveAfterEdit()
		{
			ReadOnly.Stage = stage;
			ReadOnly.ID = id;
			ReadOnly.Name = name;
		}
		public void EditData()
		{
			int ch = 0;
			do
			{
				Console.WriteLine("1  id to update:");
				Console.WriteLine("2  name to update:");
				Console.WriteLine("3  stage to update:");
				Console.WriteLine("4 exit");

				ch = Convert.ToInt32(Console.ReadLine());
				switch (ch)
				{
					case 1:
						Console.WriteLine("what id to update:");
						var idnew = Convert.ToInt32(Console.ReadLine());
						itemEdit(idnew.ToString(), id, "enter new id to replace: ");

						break;

					case 2:
						Console.WriteLine("what name to update:");
						var newname = Console.ReadLine();
						itemEdit(newname, name, "what new name to replace: ");
						break;
					case 3:
						Console.WriteLine("what stage to update:");
						var newstage = Console.ReadLine();
						itemEdit(newstage, stage, "enter new stage to replace: ");
						break;
					default:
						Console.WriteLine("error input");
						break;
				}
			}
			while (ch != 4);
			SaveAfterEdit();
		}



		private void itemEdit(string item, List<string> data, string ms)
		{
			for (var i = 0; i < data.Count; i++)
			{
				if (item != data[i]) continue;
				{
					Console.Write($"{ms}");
					var s = Console.ReadLine();
					data[i] = s;
					break;
				}
			}


		}
	}
}