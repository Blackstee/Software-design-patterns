using System;

namespace ServerForBuild
{
	

	abstract class Process_State
	{
		protected Process process;
		protected int balance;
        

		protected int lowerLimit;
		protected int upperLimit;

		// Properties
		public Process Process
		{
			get { return process; }
			set { process = value; }
		}

		public int Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public abstract void AddOnce(int amount);
		public abstract void AddDouble(int amount);
	}


	/// <summary>
	/// A 'ConcreteProcess_State' class
	/// <remarks>
	/// Red indicates that process is overdrawn
	/// </remarks>
	/// </summary>
	class Normal_State: Process_State
	{
        

		// Constructor
        public Normal_State(int balance, Process_State process_state)
		{
			this.balance = balance;
			this.process = process_state.Process;
			Initialize();
		}

		private void Initialize()
		{
			
			lowerLimit = 20;
			upperLimit = 80;
		}

		public override void AddOnce(int amount)
		{
			balance += amount;
			Process_StateChangeCheck();
		}

		public override void AddDouble(int amount)
		{
			AddOnce(amount);
            AddOnce(amount);
		}


		private void Process_StateChangeCheck()
		{
			if (balance >= upperLimit)
			{
				process.Process_State = new Good_State(this);
			}

			else if (balance <= lowerLimit)
			{
				process.Process_State = new Bad_State(this);
			}	
		}
	}

	/// <summary>
	/// A 'ConcreteProcess_State' class
	/// <remarks>
	/// Silver indicates a non-interest bearing state
	/// </remarks>
	/// </summary>
   class Good_State : Process_State
	{
		// Overloaded constructors

		public Good_State(Process_State state) :
		  this(state.Balance, state.Process)
		{
		}

		public Good_State(int balance, Process process)
		{
			this.balance = balance;
			this.process = process;
			Initialize();
		}

		private void Initialize()
		{
			upperLimit = 80;
		}

		public override void AddOnce(int amount)
		{
			
			balance += amount;
			if (balance > 100)
				balance = 100;
			Process_StateChangeCheck();
		}

		public override void AddDouble(int amount)
		{
			AddOnce(amount);
            AddOnce(amount);
		}

		private void Process_StateChangeCheck()
		{
			if (balance < upperLimit)
			{
				process.Process_State = new Normal_State(balance, this);
			}

		}
	}

	/// <summary>
	/// A 'ConcreteProcess_State' class
	/// <remarks>
	/// Gold indicates an interest bearing state
	/// </remarks>
	/// </summary>
	class Bad_State : Process_State
	{
		// Overloaded constructors
		public Bad_State(Process_State state)
		  : this(state.Balance, state.Process)
		{
		}

		public Bad_State(int balance, Process process)
		{
			this.balance = balance;
			this.process = process;
			Initialize();
		}

		private void Initialize()
		{
			lowerLimit = 20;
		}

		public override void AddOnce(int amount)
		{
			balance += amount;
			Process_StateChangeCheck();
		}

		public override void AddDouble(int amount)
		{
			AddOnce(amount);
			AddOnce(amount);
		}

		private void Process_StateChangeCheck()
		{
			if (balance < 0)
			{
				Console.WriteLine("Looooseeer");
			}
			else if (balance > lowerLimit)
			{
				process.Process_State = new Normal_State(balance, this);
			}
		}
	}

	/// <summary>
	/// The 'Context' class
	/// </summary>
	/// 

     abstract class Process
    {
	protected string name;
	

	     public abstract void Show_Info();
         public abstract void AddOnce(int amount);	
         public abstract void AddDouble(int amount);	
         public Process_State _state;


     // Constructor
     public Process()
		{
	      this._state = new Good_State(80, this);
      }

      // Properties
      public double Balance
       {
	       get { return _state.Balance; }
       }

      public Process_State Process_State
       {
	       get { return _state; }
	       set { _state = value; }

	   }


	}
}

