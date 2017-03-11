using System;
using System.Collections.Generic;

namespace Hospital
{
	class MainApp
	{
		static void Main()
		{
			//town is a root
			Composite town = new Composite("Kyiv");

			//hospitals
			Composite hosp1 = new Composite("Ohmadit");
			town.Add(hosp1);
			Composite hosp2 = new Composite("Stomatology");
			town.Add(hosp2);
			Composite hosp3 = new Composite("Emergency hospital for adults");
			town.Add(hosp3);

			//departments            
			Composite dep1 = new Composite("Children surgery ");
			hosp1.Add (dep1);
			Composite dep2 = new Composite("Children therapies");
			hosp1.Add (dep2);
			Composite dep3 = new Composite ("Children dermatology");
			hosp1.Add (dep3);
			Composite dep4 = new Composite("Teeth implants");
			hosp2.Add (dep4);
			Composite dep5 = new Composite ("Teeth surgery");
			hosp2.Add (dep5);
			Composite dep6 = new Composite ("Teeth therapies");
			hosp2.Add (dep6);
			Composite dep7 = new Composite ("Traumatology");
			hosp3.Add (dep7);
			Composite dep8 = new Composite ("Surgery");
			hosp3.Add (dep8);
			Composite dep9 = new Composite("Neurology");
			hosp3.Add (dep9);
			Composite dep10 = new Composite ("Oncology");
			hosp3.Add (dep10);

			//doctors
			Doctor d1 = new Doctor ("Zaharov Anatolij");
			dep1.Add (d1);
			Doctor d2 = new Doctor ("Kovalenko Elena");
			dep1.Add (d2);
			Doctor d3 = new Doctor ("Golubova Marina");
			dep2.Add (d3);
			Doctor d4 = new Doctor ("Merkulova Tanya");
			dep2.Add (d4);
			Doctor d5 = new Doctor ("Noskov Oleg");
			dep3.Add (d5);
			Doctor d6 = new Doctor ("Laurence Barber");
			dep3.Add (d6);
			Doctor d7 = new Doctor ("Wilfred Russell");
			dep3.Add (d7);
			Doctor d8 = new Doctor ("Christopher Kennedy");
			dep4.Add (d8);
			Doctor d9 = new Doctor ("Victoria Jacobs");
			dep4.Add (d9);
			Doctor d10 = new Doctor ("Edwina Blair");
			dep4.Add (d10);
			Doctor d11 = new Doctor ("Sophie Garrison");
			dep4.Add (d11);
			Doctor d12 = new Doctor ("Richard Williams");
			dep5.Add (d12);
			Doctor d13 = new Doctor ("Robert Hampton");
			dep6.Add (d13);
			Doctor d14 = new Doctor ("Ophelia Atkinson");
			dep6.Add (d14);
			Doctor d15 = new Doctor ("Ronald Horton");
			dep7.Add (d15);
			Doctor d16 = new Doctor ("Cori Berry");
			dep7.Add (d16);
			Doctor d17 = new Doctor ("Ethel Manning");
			dep8.Add (d17);
			Doctor d18 = new Doctor ("Donald Joseph");
			dep9.Add (d18);
			Doctor d19 = new Doctor ("Jane Lee");
			dep9.Add (d19);
			Doctor d20 = new Doctor ("Mary Sparks");
			dep9.Add (d20);
			Doctor d21 = new Doctor ("Peter Wood");
			dep9.Add (d21);
			Doctor d22 = new Doctor ("Amanda Rice");
			dep10.Add (d22);
			Doctor d23 = new Doctor ("Frank Flynn");
			dep10.Add (d23);
			Doctor d24 = new Doctor ("Rosamund Fletcher");
			dep10.Add (d24);
			Doctor d25 = new Doctor ("Agatha Wilkinson");
			dep10.Add (d25);
			Doctor d26 = new Doctor ("David Hodges");
			dep10.Add (d26);


			// Display all info
			town.GetInfo();
			town.GetDoctors ();
			town.Display(2);
			dep10.MakeChief (d26);
			town.DoCheckup (d23, d24, d21);
			town.GetInfo();
			town.GetDoctors ();
			town.Display(2);
			Console.ReadKey();
		}
	}
}


