public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? SuperiorId { get; set; }
    // Za pierwszym razem chciałem zmenić pole poniżej na nullable, lecz po chwili zagłębienia się w zadanie stwierdziłem wyrzucenie, że wyrzucanie wyjątku jest bardziej poprawne
    public virtual Employee Superior { get; set; }

    public Employee(int id, string name, int? superiorId, Employee superior)
    {
        Id = id;
        Name = name;
        SuperiorId = superiorId;
        Superior = superior;
    }
}