using System;



namespace ServerForBuild
   {
         interface IAdding
         {
	        void Add();
          	void Reduce();
          }

          class Algorithm
         {
	          public void CountingMethod(IAdding a)
	          {
			    a.Add();
			    a.Reduce();
	           }
          }

          class ForWorkers : IAdding
          {
            	public void Add()
            	{
			        Console.WriteLine ("ForWorkers: Added  amount");
             	}
              	public void Reduce()
               	{
	             	Console.WriteLine ("ForWorkers: Reduced  amount");
	            }
           }

          class ForShop : IAdding
          {
	            public void Add()
	            {
	             	Console.WriteLine ("ForShop: Added  amount");
	            }
	            public void Reduce()
	            {
	            	Console.WriteLine ("ForWorkers: Added  amount");
               	}
           }
	
   }
