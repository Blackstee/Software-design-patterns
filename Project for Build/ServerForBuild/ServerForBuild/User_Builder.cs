using System;
using System.Collections.Generic;

namespace ServerForBuild
{
	
	class Director
	{
		
		public void Construct(User_Prototype_Builder builder, User_Prototype u)
		{
			builder.BuildProcessSuccess(u);
			builder.BuildProcessTime(u);
			builder.BuildProcessMoney(u);
			builder.BuildProcessHealth(u);
		}
	}

	/// <summary>
	/// The 'User_Prototype_Builder' abstract class
	/// </summary>
	abstract class User_Prototype_Builder
	{
		public abstract void BuildProcessSuccess(User_Prototype u);
		public abstract void BuildProcessTime(User_Prototype u);
        public abstract void BuildProcessMoney(User_Prototype u);
        public abstract void BuildProcessHealth(User_Prototype u);
		public abstract User_Prototype GetResult(User_Prototype u);
	}

	/// <summary>
	/// The 'NewUserBuilder' class
	/// </summary>
	class NewUserBuilder : User_Prototype_Builder
	{
		

		public override void BuildProcessSuccess(User_Prototype u1)
		{
			u1.Add("PartA");
		}

         public override void BuildProcessHealth(User_Prototype u1)
         {
         	u1.Add("PartA");
		}

         public override void BuildProcessMoney(User_Prototype u1)
        {
	        u1.Add("PartA");
		}

		public override void BuildProcessTime(User_Prototype u1)
		{
			u1.Add("PartB");
		}

		public override User_Prototype GetResult(User_Prototype u)
		{
			return u;
		}
	}

	/// <summary> 
	/// The 'OldUserBuilder' class
	/// </summary>
	class OldUserBuilder : User_Prototype_Builder
	{

		public override void BuildProcessSuccess(User_Prototype u1)
		{
			u1.Add("PartX");
		}

		public override void BuildProcessTime(User_Prototype u1)
		{
			u1.Add("PartY");
		}

        public override void BuildProcessHealth(User_Prototype u1)
        {
            u1.Add("PartA");
         }

         public override void BuildProcessMoney(User_Prototype u1)
         {
        	u1.Add("PartA");
		}
		public override User_Prototype GetResult(User_Prototype u1)
		{
			return u1;
		}
	}


}

