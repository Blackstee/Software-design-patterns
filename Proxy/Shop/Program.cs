using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{

	class Program
	{
		static void Main(string[] args)
		{
			Control control = new Control();
			Offer of = new Offer ();
			of.addof ("Meat");
			of.addof("Bread");
			of.addof ("Juice");

			Product p1 = new Product("Meat", true, 100, of);
			Product p2 = new Product ("Bread", false, 100, of);
			Product p3 = new Product ("Tosts", true, 100, of);
			Product p4 = new Product ("Cheeze", false, 100, of);

			control.Get_Check(p1);
			control.Get_Check(p2);
			control.Get_Check(p3);
			control.Get_Check(p4);
			Console.ReadKey();
		}    
	}
		

	class Offer: List<string>
	{

		public void addof (string name)
		{
			this.Add (name);
			Console.WriteLine (" Product added to offer list:  {0}", name);
		}

		public bool Check_offer (string name)
		{
			if (this.Contains (name))
				return true;
			else
				return false;
		}
	}

	class Product
	{
		
		public string name;

		//gives -30%
		public bool special_offer;

		//gives -20%
		public bool card;

		public double price;

		public Product (string name, bool card, double price, Offer of)
		{
			this.name = name;
			this.card = card;
			this.price = price;
			this.special_offer = of.Check_offer (name);
		}

		//couldn't use simultaneously card and special offer
	}

	//interface
	abstract class Abst_Cashdesk
	{
		public abstract void Get_Check(Product p);
	}

	//realsubject
	class Cashdesk : Abst_Cashdesk
	{
		public override void Get_Check (Product p)
		{
			Console.WriteLine("\n There is no special offer for this product : {0}, so we have used your card\n The price is: {1}\n", p.name, p.price);
		}
	}

	//proxy
	class Control : Abst_Cashdesk
	{        
		Cashdesk cd = new Cashdesk();        

		public override void Get_Check(Product p)
		{
			if (!p.special_offer && p.card) {
				p.price	 = p.price*0.8;
				cd.Get_Check (p);
			} else if (p.special_offer) {
				p.price	 = p.price*0.7;
				Console.WriteLine ("\n There is the special offer for this product : {0}\n The price is: {1}\n", p.name, p.price);
			}
				else 
				Console.WriteLine("\n The product: {0}\n The price is: {1}\n", p.name, p.price);
		}
	}
		
}
