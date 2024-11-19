public interface IQuittable

{ 

void Quit();

}

The next step is implementation

public class Employee : IQuittabe

{

public int Id {get; set; }

public string FirstName { get; set; }

public string LastName { get; set; }

public void quit()

{

Console.WriteLine ($" { FirstName} {LastName} has quit their job.");

}

public static bool operator ==( Employee emp1, Employee emp2)

{

if (ReferenceEquals (emp1, emp2)) return true;

if (emp1 is null || emp2 is null ) return false;

return emp1.Id == emp2.Id;

}

public static bool operator !=(Employee emp1, Employee emp2)

{

return ! (emp1 == emp2);

}

public override bool Equals(object obj )

{

if (obj is Employee emp)

{

return this.Id == emp.Id;

}

return false;

}

public override int GetHashCode()

[

return Id.GetHashCode();

}

}

Then polymorphism

using System;

class program

{

static void Main()

{

Employee emp1 = new Employee

{

Id = 1,

FirstName = "John,

LastName ="Doe"

};

IQuittable quittableEmp = emp1;

quittableEmp.Quit();

Console.ReadLine();

}

 

 

 

 