using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChornobylDoc
{

	class MainApp
	{
		static void Main()
		{
			
		
			Group kp_51_list_chornobil = new Group ("KP-51");
			ConcreteLeader leader1 = new ConcreteLeader(kp_51_list_chornobil);

			ConcreteStudent1 Vasya = new ConcreteStudent1(leader1, "Vasya");
			ConcreteStudent2 Nastya = new ConcreteStudent2(leader1, "Nastya");
			ConcreteStudent3 Petya = new ConcreteStudent3(leader1, "Petya");
			ConcreteStudent4 Galya = new ConcreteStudent4(leader1, "Galya");
			ConcreteStudent5 Masha = new ConcreteStudent5(leader1, "Masha");

			leader1.Student1 = Vasya;
			leader1.Student2 = Nastya;
			leader1.Student3 = Petya;
			leader1.Student4 = Galya;
			leader1.Student5 = Masha;

			kp_51_list_chornobil.addst (Vasya);
			kp_51_list_chornobil.addst (Nastya);
			kp_51_list_chornobil.addst (Galya);

			leader1.SendToStudent("How are you?", Vasya);
			Vasya.Answer ("Fine, thanks");
			leader1.SendToStudent("Please send me your Chornobil certificate", Vasya);
			Vasya.Answer ("Okay");
			leader1.SendToGroup ("Please send me your Chornobil certificate");
			Galya.Answer ("Okay");
			Nastya.Answer ("Okay");

			// Wait for user
			Console.ReadKey();
		}
	}

	class Group: List<Student>
	{
		string name;

		public Group (string name)
		{
			this.name = name;
		}

		public void addst (Student st)
		{
			this.Add (st);
			Console.WriteLine (" Student added to list:  {0}", st.name);
		}

		public bool Check_student (Student st)
		{
			if (this.Contains (st))
				return true;
			else
				return false;
		}
			
	}

	abstract class Leader
	{
		public abstract void SendToStudent (string message, Student st);
		public abstract bool CheckIfInListStudent(Student st);
		public abstract bool CheckIfAnsweredStudent(string message, Student st);
		public abstract void SendToGroup(string message);
	}


	class ConcreteLeader : Leader
	{
		private Group group;
		private ConcreteStudent1 _student1;
		private ConcreteStudent2 _student2;
		private ConcreteStudent3 _student3;
		private ConcreteStudent4 _student4;
		private ConcreteStudent5 _student5;


		public ConcreteLeader (Group group)
		{
			this.group = group;
		}

		public ConcreteStudent1 Student1
		{
			set { _student1 = value; }
		}

		public ConcreteStudent2 Student2
		{
			set { _student2 = value; }
		}

		public ConcreteStudent3 Student3
		{
			set { _student3 = value; }
		}

		public ConcreteStudent4 Student4
		{
			set { _student4 = value; }
		}

		public ConcreteStudent5 Student5
		{
			set { _student5 = value; }
		}
			

		public override void SendToStudent (string message, Student st)
		{
			if (this.CheckIfInListStudent(st))
				st.Notify(message);
			else
				Console.WriteLine ("\n The student " + st.name + " is not in this group list");
		}

		public override bool CheckIfInListStudent(Student st)
		{
			if (this.group.Check_student(st))
				return true;
			else return false;
		}

		public override bool CheckIfAnsweredStudent(string message, Student st)
		{
			if (st.answered)
				return true;
			else
				return false;
		}

		public override void SendToGroup(string message)
		{
			foreach (Student st in this.group)
				st.Notify(message);
		}
	}


	abstract class Student
	{
		public string name;
		protected Leader leader;
		public bool answered;

		// Constructor
		public Student(Leader leader)
		{
			this.leader = leader;
			this.answered = false;
		}

		public abstract void AddToList (Group group);
		public abstract void Notify (string message);
		public abstract void Answer (string message);
	}
		
	class ConcreteStudent1 : Student
	{
		// Constructor
		public ConcreteStudent1(Leader leader, string name)
			: base(leader)
		{
			this.name = name;
		}

		public override void AddToList(Group group)
		{
			group.addst (this);
		}

		public void Send(string message)
		{
			leader.SendToStudent(message, this);
		}
		public override void Notify(string message)
		{
			Console.WriteLine("\n Student #1 " + this.name+ " gets message: \n\t"
				+ message);
		}

		public override void Answer (string message)
		{
			this.answered = true;
			Console.WriteLine("\n Student #1 " + this.name+ " sends message back : \n\t"
				+ message);
		}

	}

	class ConcreteStudent2 : Student
	{
		// Constructor
		public ConcreteStudent2(Leader leader, string name)
			: base(leader)
		{
			this.name = name;
		}

		public override void AddToList(Group group)
		{
			group.addst (this);
		}

		public void Send(string message)
		{
			leader.SendToStudent(message, this);
		}
		public override void Notify(string message)
		{
			Console.WriteLine("\n Student #2 " + this.name+ " gets message: \n\t"
				+ message);
		}

		public override void Answer (string message)
		{
			this.answered = true;
			Console.WriteLine("\n Student #2 " + this.name+ " sends message back : \n\t"
				+ message);
		}

	}

	class ConcreteStudent3 : Student
	{
		// Constructor
		public ConcreteStudent3(Leader leader, string name)
			: base(leader)
		{
			this.name = name;
		}

		public override void AddToList(Group group)
		{
			group.addst (this);
		}

		public void Send(string message)
		{
			leader.SendToStudent(message, this);
		}
		public override void Notify(string message)
		{
			Console.WriteLine("\n Student #3 " + this.name+ " gets message: \n\t"
				+ message);
		}

		public override void Answer (string message)
		{
			this.answered = true;
			Console.WriteLine("\n Student #3 " + this.name+ " sends message back : \n\t"
				+ message);
		}

	}
	class ConcreteStudent4 : Student
	{
		// Constructor
		public ConcreteStudent4(Leader leader, string name)
			: base(leader)
		{
			this.name = name;
		}

		public override void AddToList(Group group)
		{
			group.addst (this);
		}

		public void Send(string message)
		{
			leader.SendToStudent(message, this);
		}
		public override void Notify(string message)
		{
			Console.WriteLine("\n Student #4 " + this.name+ " gets message: \n\t"
				+ message);
		}

		public override void Answer (string message)
		{
			this.answered = true;
			Console.WriteLine("\n Student #4 " + this.name+ " sends message back : \n\t"
				+ message);
		}

	}
	class ConcreteStudent5 : Student
	{
		// Constructor
		public ConcreteStudent5(Leader leader, string name)
			: base(leader)
		{
			this.name = name;
		}

		public override void AddToList(Group group)
		{
			group.addst (this);
		}

		public void Send(string message)
		{
			leader.SendToStudent(message, this);
		}
		public override void Notify(string message)
		{
			Console.WriteLine("\n Student #5 " + this.name+ " gets message: \n\t"
				+ message);
		}

		public override void Answer (string message)
		{
			this.answered = true;
			Console.WriteLine("\n Student #5 " + this.name+ " sends message back : \n\t"
				+ message);
		}

	}


}
