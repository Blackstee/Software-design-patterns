
using System;
using System.Collections;



namespace ServerForBuild
{
	
	class Workers_Flyweight
	{
		private Hashtable workers = new Hashtable();

		// Constructor
		public Workers_Flyweight()
		{
			workers.Add("X", new ConcreteWorker("cfgvhgj"));
			workers.Add("Y", new ConcreteWorker("vbnm"));
			workers.Add("Z", new ConcreteWorker("vbnm"));
		}

		public Worker GetWorker(string key)
		{
			return ((Worker)workers[key]);
		}
	}

	/// <summary>
	/// The 'Worker' abstract class
	/// </summary>
	abstract class Worker : IWorker
	{  
        public void Update(Change_Observer changer)
        {
              	Console.WriteLine("Notified &name& of {0}'s " +
             	 "change to {1}$", changer.Symbol, changer.Salary);
          }
		public abstract void Operation(int extrinsicstate);
	}

	/// <summary>
	/// The 'ConcreteWorker' class
	/// </summary>
	class ConcreteWorker : Worker
	{

         private string _name;
         private Change_Observer _changer;

          // Constructor



          public ConcreteWorker(string name)
           {
             this._name = name;
            }



          // Gets or sets the changer
          public Change_Observer Change_Observer
          {
	          get { return _changer; }
	          set { _changer = value; }
		  }
		public override void Operation(int extrinsicstate)
		{
			Console.WriteLine("ConcreteWorker: " + extrinsicstate);
		}
	}


}


