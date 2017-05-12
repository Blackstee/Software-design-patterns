using System;
using System.Collections.Generic;


namespace ServerForBuild
{


	abstract class Change_Observer
	{
		private string _symbol;
		private int _salary;
		private List<IWorker> _workers = new List<IWorker>();

		// Constructor
		public Change_Observer(string symbol, int salary)
		{
			this._symbol = symbol;
			this._salary = salary;
		}

		public void Attach(IWorker worker)
		{
			_workers.Add(worker);
		}

		public void Detach(IWorker worker)
		{
			_workers.Remove(worker);
		}

		public void Notify()
		{
			foreach (IWorker worker in _workers)
			{
				worker.Update(this);
			}

			Console.WriteLine("");
		}

		// Gets or sets the salary
		public int Salary
		{
			get { return _salary; }
			set
			{
				if (_salary != value)
				{
					_salary = value;
					Notify();
				}
			}
		}

		// Gets the symbol
		public string Symbol
		{
			get { return _symbol; }
		}
	}

	/// <summary>
	/// The 'ConcreteSubject' class
	/// </summary>
	class Company : Change_Observer
	{
		// Constructor
		public Company(string symbol, int salary)
		  : base(symbol, salary)
		{
		}
	}

	/// <summary>
	/// The 'Observer' interface
	/// </summary>
	interface IWorker
	{
		void Update(Change_Observer changer);
	}


}
