using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerForBuild
{


	class Health : Process
	{
		public Health(string name)
		{
			
			this.name = name;
		}

		public override void Show_Info()
		{
			Console.WriteLine("This is Process.\nName - {0}\nBalance - {1}%\n",
               this.name, this.Balance);
		}


         public override void AddOnce(int amount)
         {
            _state.AddOnce(amount);
            Console.WriteLine("Added Once {0}% --- ", amount);
             Console.WriteLine(" Balance = {0}%", this.Balance);
            Console.WriteLine(" Status = {0}",
             this.Process_State.GetType().Name);
             Console.WriteLine("");
          }

         public override void AddDouble(int amount)
         {
        	_state.AddDouble(amount);
         	Console.WriteLine("Added double {0}% --- ", amount);
        	Console.WriteLine(" Balance = {0}%", this.Balance);
        	Console.WriteLine(" Status = {0}\n",
        	  this.Process_State.GetType().Name);
		}
	}


       class Money : Process
      {
	         public Money(string name)
	         {

               this.name = name;
	         }

	         public override void Show_Info()
	        {
		        Console.WriteLine("This is Process.\nName - {0}\nBalance - {1}%\n",
               this.name, this.Balance);
	        }
            public override void AddOnce(int amount)
             {
                _state.AddOnce(amount);
                Console.WriteLine("Added Once {0}% --- ", amount);
                Console.WriteLine(" Balance = {0}%", this.Balance);
			    Console.WriteLine(" Status = {0}",
                 this.Process_State.GetType().Name);
                Console.WriteLine("");
              }

              public override void AddDouble(int amount)
              {
               	_state.AddDouble(amount);
            	Console.WriteLine("Added double {0}% --- ", amount);
              	Console.WriteLine(" Balance = {0}%", this.Balance);
              	Console.WriteLine(" Status = {0}\n",
            	  this.Process_State.GetType().Name);
		}

	 }




	class Success : Process
	{
		public Success(string name)
		{

			this.name = name;
		}

		public override void Show_Info()
		{
			Console.WriteLine("This is Process.\nName - {0}\nBalance - {1}%\n",
		   this.name, this.Balance);

		}
        public override void AddOnce(int amount)
        {
            _state.AddOnce(amount);
            Console.WriteLine("Added Once {0}% --- ", amount);
            Console.WriteLine(" Balance = {0}%", this.Balance);
            Console.WriteLine(" Status = {0}",
             this.Process_State.GetType().Name);
             Console.WriteLine("");
         }
 
         public override void AddDouble(int amount)
         {
        	_state.AddDouble(amount);
          	Console.WriteLine("Added double {0}% --- ", amount);
        	Console.WriteLine(" Balance = {0}%", this.Balance);
         	Console.WriteLine(" Status = {0}\n",
            this.Process_State.GetType().Name);
		}
	}




    class Time : Process
    {
	    public Time(string name)
	    {

              this.name = name;
	    }

	    public override void Show_Info()
	    {
		       Console.WriteLine("This is Process.\nName - {0}\nBalance - {1}%\n",
			   this.name, this.Balance);
	    }

        public override void AddOnce(int amount)
        {
               _state.AddOnce(amount);
               Console.WriteLine("Added Once {0}% --- ", amount);
               Console.WriteLine(" Balance = {0}%", this.Balance);
               Console.WriteLine(" Status = {0}",
               this.Process_State.GetType().Name);
               Console.WriteLine("");
         }

         public override void AddDouble(int amount)
         {
	           _state.AddDouble(amount);
	           Console.WriteLine("Added double {0}% --- ", amount);
	           Console.WriteLine(" Balance = {0}%", this.Balance);
	           Console.WriteLine(" Status = {0}\n",
	           this.Process_State.GetType().Name);
		 }

	    
	}





	//Декоратор
	abstract class Decorator : Process
	{
		protected Process Pr;

		public void SetFeaturesOn(Process baseProcess)
		{
			this.Pr = baseProcess;
		}

		public override void Show_Info()
		{
			if (Pr != null) Pr.Show_Info();
		}

		public override void AddOnce(int amount)
        {
            if (Pr != null) Pr.AddOnce(amount);
         }

        public override void AddDouble(int amount)
         {
          	 if (Pr != null) Pr.AddDouble(amount);
		}
	}


	class AddingOnceMaxDecorator : Decorator
	{

		public override void AddOnce(int amount)
		{
			Console.Write("Added one feature to process");
			base.AddOnce(amount);
		}

		public override void AddDouble(int amount)
		{
			Console.Write("Can't add double feature to process");
		}

		public override void Show_Info()
		{
			base.Show_Info();
			Console.WriteLine("Additional feature: Only Once\n");
		}

	}


	class AddingTwiceOnlyDecorator : Decorator
	{
		public override void AddOnce(int amount)
		{
			Console.Write("Can't add once feature to process");
		}

       public override void AddDouble(int amount)
        {
			Console.Write("Added double feature to process");
			base.AddDouble(amount);
		}

		public override void Show_Info()
		{
			base.Show_Info();
			Console.WriteLine("Additional feature: Only Twice\n");
        }
    }
    
}

