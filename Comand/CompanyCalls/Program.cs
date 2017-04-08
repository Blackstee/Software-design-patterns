using System;

namespace Company
{

	class MainApp
	{
		static void Main()
		{
			// Create invoker
			Diktor dikt = new Diktor();

			// Call to company
			dikt.Call();

			//Create receiver and command
			Department dep = new Department();
			PhoneCall call = new CallToDep1 (dep);
			for (int i = 0; i < 15; i++) 
			{
				if (i%2 == 0)
					call = new CallToDep1(dep);
				else if (i%3 == 0)
					call = new CallToDep2(dep);
				else 
					call = new CallToDep3(dep);
				
				//Set and execute call
				dikt.SetCall(call);
				dikt.ExecuteCall();	
			}

			// Wait for user
			Console.ReadKey();
		}
	}


	abstract class PhoneCall
	{
		protected Department dep;
		public PhoneCall(Department dep)
		{
			this.dep = dep;
		}

		public abstract void Execute();
	}


	class CallToDep1 : PhoneCall
	{
		public CallToDep1(Department dep) :
		base(dep)
		{
		}

		public override void Execute()
		{
			dep.Action("# 1");
		}
	}

	class CallToDep2 : PhoneCall
	{
		public CallToDep2(Department dep) :
		base(dep)
		{
		}

		public override void Execute()
		{
			dep.Action("# 2");
		}
	}

	class CallToDep3 : PhoneCall
	{
		public CallToDep3(Department dep) :
		base(dep)
		{
		}

		public override void Execute()
		{
			dep.Action("# 3");
		}
	}

	class Department
	{
		public void Action(string number)
		{
			Console.WriteLine("\nDepartment " + number + " has got a call");
		}
	}


	class Diktor
	{
		private PhoneCall _call;

		public void Call ()
		{
			Console.WriteLine("Hello! You've called to Company IMHO\n\n Here are the numbers of our departments:\n  425 - Department #1\n  465 - Department #2\n  435 - Department #3\n\n");
		}

		public void SetCall(PhoneCall call)
		{
			this._call = call;
		}

		public void ExecuteCall()
		{
			_call.Execute();
		}
	}
}
