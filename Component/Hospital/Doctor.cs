using System;

namespace Hospital
{
	class Doctor : ResidentalComponent
	{

		public Doctor(string name) : base(name)
		{
			Random rnd = new Random();
			this.patients = rnd.Next (50);
			this.doctors = 1;
		}

		public override void Add(ResidentalComponent c)
		{
			Console.WriteLine("Impossible operation");
		}

		public override void Remove(ResidentalComponent c)
		{
			Console.WriteLine("Impossible operation");
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new String('-', depth) + name + ", Patients: " + patients.ToString());
		}

		public override int GetInfo()
		{
			return this.patients;
		}

		public override int GetDoctors()
		{
			return this.doctors;
		}

		public override void  MakeChief (ResidentalComponent component)
		{
			Console.WriteLine("Impossible operation");

		}

		public override void RemoveChief ()
		{
			Console.WriteLine("Impossible operation");

		}
		public override string GetChief ()
		{
			Console.WriteLine("Impossible operation");
			return this.chief;
		}

		public override string GetName ()
		{

			return this.name;
		}

		public override void DoCheckup (params ResidentalComponent[] doctors)
		{
			Console.WriteLine("Impossible operation");
		}

		public override void AddPatient ()
		{
			this.patients ++;
		}
	}
}

