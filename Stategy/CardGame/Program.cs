using System; 


namespace CardGame 
{

	class MainApp
	{

		static void Main()
		{
			Context context;
			Player Nastya = new Player ("Nastya");
			Player Vasya = new Player ("Vasya");
			context = new Context(new Durak());
			context.ContextInterface( Nastya, Vasya);

			context = new Context(new Sunduchki());
			context.ContextInterface( Nastya, Vasya);

			context = new Context(new Pjanitsa());
			context.ContextInterface( Nastya, Vasya);


			Console.ReadKey();
		}
	}

	public class Player {
		
		protected string Name;
		protected int countCards;

		public Player (string Name)
		{
			this.Name = Name;
			this.countCards = 0;
			Console.WriteLine ("\nHello, " + this.Name + "!\n");
		}

		public void AddCard()
		{
			this.countCards++;
			Console.WriteLine ("Added card to player: " + this.Name + ", and now he/she has " + this.countCards + " cards");
		}

		public int GetCountCards()
		{
			return this.countCards;
		}
		public void GiveBackCard()
		{
			this.countCards = 0;
			Console.WriteLine ("\nPlayer: " + this.Name + " has " + this.countCards + " cards");
		}
	}
		

	abstract class Strategy
	{
		public abstract void Algorithm(params Player[] players);
	}

	class Durak : Strategy
	{
		public override void Algorithm(params Player[] players)
		{
			Console.WriteLine ("\n\nTHE GAME DURAK HAS STARTED! Take your cards!\n");
			if (players.Length >= 6)
				Console.WriteLine ("\nToo many players!");
			else if (players.Length <= 1)
				Console.WriteLine ("\nNeed more players!");
			else {
				for (int i = 0; i < 6; i++)
					for (int k = 0; k < players.Length; k++)
						players [k].AddCard ();
			}
			Console.WriteLine ("\nPlaying game . . .");
			Console.WriteLine ("\nGAME FINISHED! Give all your cards back!\n");
			for (int k = 0; k < players.Length; k++)
				players [k].GiveBackCard ();
		}
	}



	class Sunduchki : Strategy
	{
		public override void Algorithm(params Player[] players)
		{
			Console.WriteLine ("\n\nTHE GAME SUNDUCHKI HAS STARTED! Take your cards!\n");
			if (players.Length >= 6)
				Console.WriteLine ("\nToo many players!");
			else if (players.Length <= 1)
				Console.WriteLine ("\nNeed more players!");
			else {
				for (int i = 0; i < 4; i++)
					for (int k = 0; k < players.Length; k++)
						players [k].AddCard ();
			}
			Console.WriteLine ("\nPlaying game . . .");
			Console.WriteLine ("\nGAME FINISHED! Give all your cards back!\n");
			for (int k = 0; k < players.Length; k++)
				players [k].GiveBackCard ();
		}
	}


	class Pjanitsa : Strategy
	{
		public override void Algorithm(params Player[] players)
		{
			Console.WriteLine ("\n\nTHE GAME PJANITSA HAS STARTED! Take your cards!\n");
			if (players.Length <= 1)
				Console.WriteLine ("\nNeed more players!");
			else if (36 % players.Length != 0)
				Console.WriteLine ("\nNeed more or less players!");
			else if (players.Length > 12)
				Console.WriteLine ("\nToo many players!");
			else {
				for (int i = 0; i < 36/players.Length; i++)
					for (int k = 0; k < players.Length; k++)
						players [k].AddCard ();
			}
			Console.WriteLine ("\nPlaying game . . .");
			Console.WriteLine ("\nGAME FINISHED! Give all your cards back!\n");
			for (int k = 0; k < players.Length; k++)
				players [k].GiveBackCard ();
		}
	}


	class Context
	{
		private Strategy _strategy;

		public Context(Strategy strategy)
		{
			this._strategy = strategy;
		}

		public void ContextInterface(params Player[] players )
		{
			_strategy.Algorithm(players);
		}
	}
}
