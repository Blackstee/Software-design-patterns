using System;


namespace canteen
{
	class MainApp
	{
		public static void Main()
		{
			Cook c = Cook.Instance ();
			Console.WriteLine(c.GiveFood (32));

			Console.ReadKey();
		}
	}

	abstract class CanteenFactory
	{
		public abstract MeatDish CreateMeatDish();
		public abstract  SideDish CreateSideDish();
	}


	class FirstСonveyorFactory : CanteenFactory
	{
		public override MeatDish CreateMeatDish()
		{
				return new PorkChop ();

		}
		public override SideDish CreateSideDish()
		{
			
				return new Potatoes ();
			
		}
	}

	class SecondСonveyorFactory : CanteenFactory
	{
		public override MeatDish CreateMeatDish()
		{
			return new PorkChop ();

		}
		public override SideDish CreateSideDish()
		{

			return new Pasta ();

		}
	}

	class ThirdСonveyorFactory : CanteenFactory
	{
		public override MeatDish CreateMeatDish()
		{
			return new ChickenCutlet ();

		}
		public override SideDish CreateSideDish()
		{

			return new Potatoes ();

		}
	}

	class FourthСonveyorFactory : CanteenFactory
	{
		public override MeatDish CreateMeatDish()
		{
			return new ChickenCutlet  ();

		}
		public override SideDish CreateSideDish()
		{

			return new Pasta ();

		}
	}


	abstract class MeatDish
	{
	}

	abstract class SideDish
	{
		public abstract void Combine(MeatDish md);
	}

	class PorkChop : MeatDish
	{
	}

	class Potatoes : SideDish
	{

		public override void Combine(MeatDish md)
		{
			
			Console.WriteLine(this.GetType().Name +
				" combines with " + md.GetType().Name);
		}
	}

	class ChickenCutlet : MeatDish
	{

	}

	class Pasta : SideDish
	{


		public override void Combine(MeatDish md)
		{

			Console.WriteLine(this.GetType().Name +
				" combines with " + md.GetType().Name);
		}
	}


	class Dishes
	{
		private MeatDish _meatdish;
		private SideDish _sidedish;

		public Dishes(CanteenFactory factory)
		{
			_meatdish = factory.CreateMeatDish();
			_sidedish = factory.CreateSideDish();
		}
		public void MakeDish()
		{
			_sidedish.Combine(_meatdish);
		}
	}

	class Cook
	{
		private int Potatoes = 6;
		private int Pasta = 7;
		private int PorkChop = 5;
		private int ChickenCutlet = 10;
		private static Cook _instance;
		protected Cook()
		{
		}
		public static Cook Instance()
		{

			if (_instance == null)
				_instance = new Cook();
			return _instance;

		}
		public string GiveFood (int count)
		{
			if (Potatoes > 0 && PorkChop > 0) {
				CanteenFactory f = new FirstСonveyorFactory ();
				Dishes d = new Dishes (f);
				do {
					d.MakeDish ();
					Potatoes--;
					PorkChop--;
					count--;
				} while (count > 0 && Potatoes > 0 && PorkChop > 0);
			}
			if (Potatoes == 0 && PorkChop > 0)
			{
				CanteenFactory s = new SecondСonveyorFactory();
				Dishes d = new Dishes(s);
				do {
					d.MakeDish ();
					Pasta--;
					PorkChop--;
					count--;
				} while (count > 0 && Pasta > 0 && PorkChop > 0);
			}
			if (Potatoes > 0 && PorkChop == 0)
			{
				CanteenFactory t = new ThirdСonveyorFactory();
				Dishes d = new Dishes(t);
				do {
					d.MakeDish ();
					Potatoes--;
					ChickenCutlet--;
					count--;
				} while (count > 0 && Potatoes > 0 && ChickenCutlet > 0);

			}
			if (Potatoes == 0 && PorkChop == 0) {
				CanteenFactory f = new FourthСonveyorFactory ();
				Dishes d = new Dishes (f);
				do {
					d.MakeDish ();
					Pasta--;
					ChickenCutlet--;
					count--;
				} while (count > 0 && Pasta > 0 && ChickenCutlet > 0);

			} 
			if (count == 0)
				return "____FINISHED COOKING!___";
				return "___We don't have enough dishes, sorry :(";

		}
	}
}