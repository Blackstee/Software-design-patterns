using System;
using System.Collections.Generic;


namespace Drinks
{


	class Drink
	{
		private string _drinkType;

		private Dictionary<string,string> _parts = 
			new Dictionary<string,string>();

		public Drink(string drinkType)
		{
			this._drinkType = drinkType;
		}

		public string this[string key]
		{
			get { return _parts[key]; }
			set { _parts[key] = value; }
		}

		public void Show()
		{
			Console.WriteLine("\n---------------------------");
			Console.WriteLine("Drink type: {0}", _drinkType);
			Console.WriteLine(" What cup? : {0}", _parts["cup"]);
			Console.WriteLine(" Tea or coffee? : {0}", _parts["ingr"]);
			Console.WriteLine(" How much water? : {0}", _parts["water"]);
			Console.WriteLine(" How much sugar? : {0}", _parts["sugar"]);
		}
	}

	
	abstract class DrinksAutomat {
		protected Drink drink;
		public Drink Drink
		{
			get { return drink; }
		}

		public abstract void chooseCup();
		public abstract void addIngr(); // clothes
		public abstract void addWater();
		public abstract void addSugar();

	}

	  class Late : DrinksAutomat {

		public Late ()
		{
			drink = new Drink("Late");
		}
		
		public override void chooseCup()
		{
			drink["cup"] = "Small cup";
		}
		public override void addIngr()
		{
			drink["ingr"] = "Coffee";
		}
		public override void addWater()
		{
			drink["water"] = "50 ml of water";
		}
		public override void addSugar()
		{
			drink["sugar"] = "two spoons of sugar";
		}

	}

	class Americano : DrinksAutomat {

		public Americano ()
		{
			drink = new Drink("Americano");
		}

		public override void chooseCup()
		{
			drink["cup"] = "Small cup";
		}
		public override void addIngr()
		{
			drink["ingr"] = "Coffee";
		}
		public override void addWater()
		{
			drink["water"] = "50 ml of water";
		}
		public override void addSugar()
		{
			drink["sugar"] = "two spoons of sugar";
		}

	}

	class Capuccino : DrinksAutomat {

		public Capuccino ()
		{
			drink = new Drink("Capuccino");
		}

		public override void chooseCup()
		{
			drink["cup"] = "Small cup";
		}
		public override void addIngr()
		{
			drink["ingr"] = "Coffee";
		}
		public override void addWater()
		{
			drink["water"] = "50 ml of water";
		}
		public override void addSugar()
		{
			drink["sugar"] = "one spoon of sugar";
		}

	}

	class Tea : DrinksAutomat {

		public Tea ()
		{
			drink = new Drink("Tea");
		}

		public override void chooseCup()
		{
			drink["cup"] = "Big cup";
		}
		public override void addIngr()
		{
			drink["ingr"] = "Tea";
		}
		public override void addWater()
		{
			drink["water"] = "100 ml of water";
		}
		public override void addSugar()
		{
			drink["sugar"] = "two spoons of sugar";
		}

	}

	class Cacao : DrinksAutomat {

		public Cacao ()
		{
			drink = new Drink("Cacao");
		}

		public override void chooseCup()
		{
			drink["cup"] = "Big cup";
		}
		public override void addIngr()
		{
			drink["ingr"] = "Cacao";
		}
		public override void addWater()
		{
			drink["water"] = "70 ml of water";
		}
		public override void addSugar()
		{
			drink["sugar"] = "three spoons of sugar";
		}

	}

	class Automat
	{
		public void Construct(DrinksAutomat DA)
		{
			DA.chooseCup();
			DA.addIngr();
			DA.addWater();
			DA.addSugar();
		}
	} 



	// Integration with overal application
	public class Application {
		public static void Main(String[] args) {
			String drink = "Late";
			DrinksAutomat drautomat;
			Automat aut = new Automat();

			if (drink.Equals ("Late")) {
				drautomat = new Late ();
			} else if (drink.Equals ("Americano")) {
				drautomat = new Americano ();
			} else if (drink.Equals ("Cappuccino")) {
				drautomat = new Capuccino ();
			} else if (drink.Equals ("Tea")) {
				drautomat = new Tea ();
			} else if (drink.Equals ("Cacao")) {
				drautomat = new Cacao ();
			} else drautomat = new Late ();
			aut.Construct(drautomat);
			drautomat.Drink.Show();


		}
	}
}
