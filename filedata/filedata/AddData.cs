namespace filedata
{
	using System;

	class AddData
	{
		public void add()
		{
			Console.WriteLine("add id: ");
			var Id = Console.ReadLine();

			Console.WriteLine("add name: ");
			var name = Console.ReadLine();

			Console.WriteLine("add at stage: ");
			var stage = Console.ReadLine();

			ReadOnly.ID.Add(Id);
			ReadOnly.Name.Add(name);
			ReadOnly.Stage.Add(stage);
		}
	}
}