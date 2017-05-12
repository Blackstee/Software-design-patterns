using System;
using System.Collections.Generic;
using System.Text;

namespace ServerForBuild
{
	

	public abstract class User_Prototype
	{
		public uint Id { get; set; }
		public string Name { get; set; }
        private List<string> _parts = new List<string>();

         public void Add(string part)
        {
         _parts.Add(part);

          }

       public void Show()
         {
	        Console.WriteLine("\nProcesses -------");
	        foreach (string part in _parts)
		    Console.WriteLine(part);
		}

		public virtual User_Prototype Clone()
		{
			Console.WriteLine("Cloning object");
			return (User_Prototype)this.MemberwiseClone();
		}

         public uint getId(User_Prototype BE)
         {
	            return BE.Id;
		}

         public string getName (User_Prototype BE)
          {
            	return BE.Name;
	    	}
	}

	public class New_User : User_Prototype { }
	public class Old_User : User_Prototype { }


	public static class ElementFactory
	{
		private static  New_User _newPropotype;
		private static  Old_User _oldPropotype;

		static ElementFactory()
		{
            _newPropotype = new New_User();
            _oldPropotype = new Old_User();
			//Using builder create our prototypes
            Director director = new Director();

            User_Prototype _newPr = new New_User();
            User_Prototype _oldPr = new Old_User();

            User_Prototype_Builder b1 = new NewUserBuilder();
            User_Prototype_Builder b2 = new OldUserBuilder();

            // Construct two users
            director.Construct(b1, _newPr);
			User_Prototype _newPrototype = b1.GetResult(_newPr);
            _newPrototype.Show();

			director.Construct(b2, _oldPr );
            User_Prototype _oldPrototype = b2.GetResult(_oldPr);

            _newPrototype.Show();

            _newPrototype.Name = "New user";

            _oldPrototype.Name = "Old user";

		}

		public static New_User CreateNew()
		{
			return (New_User)_newPropotype.Clone();
		}

		public static Old_User CreateOld()
		{
			return (Old_User)_oldPropotype.Clone();
		}

	}
}

