using System;
using System.Collections.Generic;

namespace Hospital
{
	abstract class ResidentalComponent
	{
		protected string name;
		protected int doctors;
		protected int patients;
		protected string chief;

		// Constructor
		public ResidentalComponent(string name)
		{
			this.name = name;
		}

		public abstract void Add(ResidentalComponent c);
		public abstract void Remove(ResidentalComponent c);
		public abstract int GetInfo();
		public abstract int GetDoctors();
		public abstract void MakeChief (ResidentalComponent c);
		public abstract void RemoveChief ();
		public abstract string GetChief ();
		public abstract string GetName ();
		public abstract void AddPatient ();
		public abstract void DoCheckup (params ResidentalComponent[] doctors); 
		public abstract void Display(int depth);

	}

	class Composite : ResidentalComponent
	{
		private List<ResidentalComponent> _children = new List<ResidentalComponent>();

		// Constructor
		public Composite(string name) : base(name) 
		{
			this.patients = 0;
			this.doctors = 0;
			this.chief = "no one";

		}

		public override void Add(ResidentalComponent component)
		{
			_children.Add(component);
		}

		public override void Remove(ResidentalComponent component)
		{
			_children.Remove(component);
		}

		public override void MakeChief (ResidentalComponent component)
		{
			this.chief = component.GetName();
			Console.WriteLine("Chief added");
		}

		public override void RemoveChief ()
		{
			this.chief = "no one";
			Console.WriteLine("Chief removed");
		}

		public override string GetChief ()
		{
			return this.chief;
		}

		public override string GetName ()
		{
			return this.name;
		}

		public override void AddPatient ()
		{
			Console.WriteLine ("\n Can't add a patient\n");
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new String('-', depth) + name + "\n" + new String('-', depth)+ "Patients: " + this.patients.ToString() + ", Doctors: " + this.doctors.ToString() + ", Chief: " + this.GetChief());

			// Recursively display child nodes
			foreach (ResidentalComponent component in _children)
			{
				component.Display(depth + 2);
			}
		}


		public override int GetInfo()
		{
			this.patients = 0;
			foreach (ResidentalComponent component in _children)
			{
				this.patients += component.GetInfo ();
			}            
			return this.patients;
		}

		public override int GetDoctors()
		{
			this.doctors = 0;
			foreach (ResidentalComponent component in _children) 
			{
				this.doctors += component.GetDoctors ();
			}
			return this.doctors;
		}

		public override void DoCheckup (params ResidentalComponent[] doctors)
		{
			for (int i = 0; i < doctors.Length; i++)
			{
				doctors [i].AddPatient();
				Console.WriteLine ("Patient went for check-up to " + doctors[i].GetName());
			}

		}


	}
}

