
// Zadanie 1.

EmployeesStructure employeesStructure = new EmployeesStructure();
var employees = new List<NewEmployee>
{
    new NewEmployee(1, "Jan Kowalski", null),
    new NewEmployee(2,"Kamil Nowak", 1),
    new NewEmployee(4,"Andrzej Abacki", 2),
    new NewEmployee(3, "Anna Mariacka", 1)
};

employeesStructure.Fill(employees);

var row1 = employeesStructure.GetSuperiorRowOfEmployee(2,1); // row1 = 1
var row2 = employeesStructure.GetSuperiorRowOfEmployee(4,3); // row2 = null
var row3 = employeesStructure.GetSuperiorRowOfEmployee(4,1); // row3 = 2

System.Console.WriteLine(row1);
System.Console.WriteLine(row2);
System.Console.WriteLine(row3);
