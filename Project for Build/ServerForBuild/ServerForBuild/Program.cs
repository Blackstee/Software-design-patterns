using System;


namespace ServerForBuild
{

	class MainApp
	{

		static void Main()
		{

			//Cloning for users saves

			// Create two instances and clone each

            New_User newBox = ElementFactory.CreateNew();
			Console.WriteLine("Cloning object");
			uint id =  newBox.getId(newBox);
			Console.WriteLine(id);
            string title = newBox.getName(newBox);
			Console.WriteLine(title);



			//Flyweight for workers


             // Arbitrary extrinsic state
            int extrinsicstate = 22;

            Workers_Flyweight factory = new Workers_Flyweight();

            // Work with different flyweight instances
            Worker fx = factory.GetWorker("X");
            fx.Operation(--extrinsicstate);

            Worker fy = factory.GetWorker("Y");
            fy.Operation(--extrinsicstate);

			Worker fz = factory.GetWorker("Z");
            fz.Operation(--extrinsicstate);





			//Observer

            // Create IBM stock and attach investors
            Company ibm = new Company("IBM", 120);
            ibm.Attach(new ConcreteWorker("Sorros"));
			ibm.Attach(new ConcreteWorker("Berkshire"));

			// Fluctuating prices will notify investors
			ibm.Salary = 120;
			ibm.Salary = 121;
			ibm.Salary = 120;
			ibm.Salary = 120;






			//State

            // Open a new account
             Process account = new Health("Health");

            // Apply financial transactions

            account.AddOnce(10);
			account.AddOnce(10);
			account.AddDouble(10);




			//Template method for adding money or count

             Algorithm m = new Algorithm();

             m.CountingMethod(new ForWorkers());
   	     	 m.CountingMethod(new ForShop());



			//Decorator for different processes

            //Створюємо єкземпляр класу "Гвинтівка" та два "Декоратори"
            Process R1 = new Health("Health");
            Decorator S1 = new AddingOnceMaxDecorator();
            Decorator S2 = new AddingTwiceOnlyDecorator();

            //Повязуємо декоратори та робимо виклики
            S1.SetFeaturesOn(R1);
			S2.SetFeaturesOn(S1);

			S2.Show_Info();
			S2.AddOnce(20);



			// Wait for user
			Console.ReadKey();
		}

	}


}


