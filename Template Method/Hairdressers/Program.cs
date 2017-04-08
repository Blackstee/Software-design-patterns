using System;

namespace Hairdressers
{
	class MainApp
	{
		static void Main()
		{
			AbstractClass HairCut = new HairStyle1();
			Console.WriteLine ("\n OUR FIRST HAIR STYLE IS CUTTING THE HAIR\n"); 
			HairCut.TemplateMethod();
			Console.WriteLine (" OUR FIRST HAIR STYLE IS FINISHED\n"); 

			AbstractClass HairDyeing = new HairStyle2();
			Console.WriteLine ("\n OUR SECOND HAIR STYLE IS DYEING THE HAIR\n"); 
			HairDyeing.TemplateMethod();
			Console.WriteLine (" OUR SECOND HAIR STYLE IS FINISHED\n"); 

			AbstractClass HairArranging = new HairStyle3();
			Console.WriteLine ("\n OUR THIRD HAIR STYLE IS ARRANGING THE HAIR\n"); 
			HairArranging.TemplateMethod();
			Console.WriteLine (" OUR THIRD HAIR STYLE IS FINISHED\n"); 

			// Wait for user
			Console.ReadKey();
		}
	}

	abstract class AbstractClass
	{
		public abstract void WashHair();
		public abstract void CombHair();
		public abstract void StyleHair();
		public abstract void DryHair();
		public abstract void VarnishHair();


		public void TemplateMethod()
		{
			
			WashHair();
			CombHair();
			StyleHair ();
			DryHair ();
			VarnishHair ();

			Console.WriteLine("");
		}
	}


	class HairStyle1 : AbstractClass
	{
		public override void WashHair()
		{
			Console.WriteLine("While doing the first hair style, we have washed the hair");
		}
		public override void CombHair()
		{
			Console.WriteLine("While doing the first hair style, we have combed the hair");
		}
		public override void StyleHair()
		{
			Console.WriteLine("While doing the first hair style, we have cut the hair");
		}
		public override void DryHair()
		{
			Console.WriteLine("While doing the first hair style, we have dryed the hair");
		}
		public override void VarnishHair()
		{
			Console.WriteLine("While doing the first hair style, we have varnished the hair");
		}
	}
		
	class HairStyle2 : AbstractClass
	{
		public override void WashHair()
		{
			Console.WriteLine("While doing the second hair style, we have washed the hair");
		}
		public override void CombHair()
		{
			Console.WriteLine("While doing the second hair style, we have combed the hair");
		}
		public override void StyleHair()
		{
			Console.WriteLine("While doing the second hair style, we have dyed the hair");
		}
		public override void DryHair()
		{
			Console.WriteLine("While doing the second hair style, we have dryed the hair");
		}
		public override void VarnishHair()
		{
			Console.WriteLine("While doing the second hair style, we have varnished the hair");
		}
	}
	class HairStyle3 : AbstractClass
	{
		public override void WashHair()
		{
			Console.WriteLine("While doing the third hair style, we have washed the hair");
		}
		public override void DryHair()
		{
			Console.WriteLine("While doing the third hair style, we have dryed the hair");
		}
		public override void CombHair()
		{
			Console.WriteLine("While doing the third hair style, we have combed the hair");
		}
		public override void StyleHair()
		{
			Console.WriteLine("While doing the third hair style, we have arranged the hair");
		}

		public override void VarnishHair()
		{
			Console.WriteLine("While doing the third hair style, we have varnished the hair");
		}
	}
}