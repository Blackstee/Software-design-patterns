using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voice
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal dog = new Dog ("Doggy");

			dog.VoiceType = new AnimalVoice ("WAFF");

			dog.DoVoice ("Voice!");

			Animal cat = new Cat ("Kitten");

			cat.VoiceType = new Silence ("tsss");

			cat.DoVoice ("silence");

			Console.ReadKey();
		}
	}

	class Animal
	{
		public String AnimalName {get; set;}

		public VoiceType VoiceType {get; set;}

		public virtual void DoVoice (string command)
		{
			VoiceType.ShowVoiceInfo(command);
		}
	}


	class Dog : Animal
	{
		public Dog(string Name)
		{
			AnimalName = Name;
		}
		public override void DoVoice (string command)
		{
			Console.WriteLine("Name: " + AnimalName);
			Console.WriteLine("Type: Dog");
			base.DoVoice(command);
		}
	}


	class Cat : Animal
	{
		public Cat(string Name)
		{
			AnimalName = Name;
		}
		public override void DoVoice (string command)
		{
			Console.WriteLine("Name: " + AnimalName);
			Console.WriteLine("Type: Cat");
			base.DoVoice(command);
		}
	}

	class Mouse : Animal
	{
		public Mouse(string Name)
		{
			AnimalName = Name;
		}
		public override void DoVoice (string command)
		{
			Console.WriteLine("Name: " + AnimalName);
			Console.WriteLine("Type: Mouse");
			base.DoVoice(command);
		}
	}


	abstract class VoiceType
	{
		public abstract void ShowVoiceInfo (String command);
	}

	class AnimalVoice : VoiceType
	{
		String voice;
		public AnimalVoice(String voices)
		{
			voice = voices;
		}
		public override void ShowVoiceInfo(String command)
		{
			Console.WriteLine("Animal makes voice: " + this.voice + " for command " + command + "\n");
		}
	}

	class Silence : VoiceType
	{
		String voice;
		public Silence(String voices)
		{
			voice = voices;
		}
		public override void ShowVoiceInfo (String command)
		{
			Console.WriteLine("Animal keeps silence");
		}
	}
}

