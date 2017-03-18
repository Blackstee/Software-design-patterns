using System;
using System.Collections;



namespace Mosaic
{

	class MainApp
	{

		static void Main()
		{
			
			MosaicFactory factory = new MosaicFactory();

			Color yellow = factory.GetColor ("Yellow");
			yellow.Display ();
			while (yellow.Operation ())
				yellow.Display ();
				
			Color blue = factory.GetColor ("Blue");
			blue.Display ();
			while (blue.Operation ())
			blue.Display ();

			Console.ReadKey();
		}
	}
		
	class MosaicFactory
	{
		private Hashtable cards = new Hashtable();

		public MosaicFactory()
		{
			cards.Add("Yellow", new Yellow());
			cards.Add("Blue", new Blue());
		}

		public Color GetColor (string key)
		{
			return ((Color)cards[key]);
		}
	}
		
	abstract class Color
	{
		protected string name;
		protected int X;
		protected int Y;

		public abstract void Display();

		public abstract bool Operation();
	}
		
	class Yellow : Color
	{
		public Yellow ()
		{
			this.name = "Yellow";
			this.X = 50;
			this.Y = 25;

		}
		public override void Display()
		{
			Console.WriteLine("\nCard: {0}, Position ({1};{2})\n", this.name, this.X, this.Y);
		}

		public override bool Operation()
		{
			while (this.X != 0) {
				if (this.Y == 1) {
					this.X--;
					this.Y = 25;
					if (this.X == 0)
						return false;
				} else
					this.Y--;
				return true;
			}
			return false;
		}
	}

	class Blue : Color
	{
		public Blue ()
		{
			this.name = "Blue";
			this.X = 100;
			this.Y = 50;

		}
		public override void Display()
		{
			Console.WriteLine("\nCard: {0}, Position ({1};{2})\n", this.name, this.X, this.Y);
		}

		public override bool Operation()
		{
			while (this.X != 49) 
			{
				if (this.Y == 26) {
					this.X--;
					this.Y = 50;
					if (this.X == 49)
						return false;
				} else
					this.Y--;
				return true;
			}
			return false;
		}
	}
}