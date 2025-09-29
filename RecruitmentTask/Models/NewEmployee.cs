// Klasa pomocnicza do łatwiejszego wprowadzania pracowników
public class NewEmployee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? SuperiorId { get; set; }

    public NewEmployee(int id, string name, int? superiorId)
    {
        Id = id;
        Name = name;
        SuperiorId = superiorId;
    }
}