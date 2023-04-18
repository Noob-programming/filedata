namespace filedata
{
	using System;
	using System.Collections.Generic;

	internal class DElData
	{
		private List<string> id;

		private List<string> name;

		private List<string> stage;
		public DElData()
		{
			id = ReadOnly.ID;
			name = ReadOnly.Name;
			stage = ReadOnly.Stage;

		}

		public void Deleteitem()
		{
			var ch = 0;
			do
			{
				Console.WriteLine("1  id to delete:");
				//Console.WriteLine("2  name to delete:");
				//Console.WriteLine("3  stage to delete:");
				Console.WriteLine("4 exit");

				ch = Convert.ToInt32(Console.ReadLine());
				switch (ch)
				{
					case 1:
						Console.WriteLine("what id to delete:");
						var delid = Convert.ToInt32(Console.ReadLine());
						Delitem(ch, delid.ToString());

						break;

					//case 2:
					//	Console.WriteLine("what name to delete:");
					//	var delname = Console.ReadLine();
					//	Delitem(ch, delname);
					//	break;
					//case 3:
					//	Console.WriteLine("what stage to delete:");
					//	var delstage = Console.ReadLine();
					//	Delitem(ch, delstage);
					//	break;
					default:
						break;
				}
			}
			while (ch != 4);
		}

		private void Delitem(int indexdel, string item)
		{


			switch (indexdel)
			{
				case 1:
					for (var i = 0; i < id.Count; i++)
					{
						if (item != id[i]) continue;
						{
							id.RemoveAt(i);
							name.RemoveAt(i);
							stage.RemoveAt(i);

							break;
						}
					}


					break;

					//case 2:
					//	for (var i = 0; i < name.Count; i++)
					//	{
					//		if (item != name[i]) continue;
					//		{
					//			id.RemoveAt(i);
					//			name.RemoveAt(i);
					//			stage.RemoveAt(i);

					//			break;
					//		}
					//	}


					//	break;
					//case 3:
					//	for (var i = 0; i < stage.Count; i++)
					//	{
					//		if (item != stage[i]) continue;
					//		{
					//			id.RemoveAt(i);
					//			name.RemoveAt(i);
					//			stage.RemoveAt(i);

					//			break;
					//		}
					//	}



					//	break;
			}
			UpdataAfterDelete();
		}

		private void UpdataAfterDelete()
		{
			ReadOnly.ID = id;
			ReadOnly.Name = name;
			ReadOnly.Stage = stage;
		}
	}
}