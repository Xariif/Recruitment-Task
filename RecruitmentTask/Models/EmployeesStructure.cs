public class EmployeesStructure
{
    // Zastosowanie Dictionary pozowoli nam uniknać potwarzania idków - Key jest unikalne
    public Dictionary<int, Employee> Employees { get; set; } = new Dictionary<int, Employee>();

    public Employee? GetEmployeeById(int employeeId)
    {
        return Employees.FirstOrDefault(x => x.Key == employeeId).Value;
    }

    public void Fill(List<NewEmployee> newEmployees)
    {
        foreach (var e in newEmployees)
        {
            var superior = Employees.FirstOrDefault(x => x.Key == e.SuperiorId);

            // W przypadku braku zachowania odpowiedniej kolejności dodawania pracowników (przypisanie pracownika do nieistniejącego przełożonego) zostaniemy o tym poinformowani poprzez wyrzucenie błędu
            if (e.SuperiorId != null && superior.Value == null)
                throw new Exception("Superior not found");

            Employees[e.Id] = new Employee(
               e.Id,
               e.Name,
               e.SuperiorId,
               superior.Value
           );
        }
    }

    // Miałem wątpliwości co do liczenia rzędów - zakładam że chodzi o rząd względem relacji z przełożonym a nie liczenie od góry hierarchi np.
    // 1 - bezpośredni
    // 2 - przełożony przełożonego itd.
    public int? GetSuperiorRowOfEmployee(int employeeId, int superiorId)
    {
        if (!Employees.TryGetValue(employeeId, out var currentEmployee))
            return null;

        int currentRow = 1;
        while (currentEmployee?.Superior != null)
        {
            if (currentEmployee.Superior.Id == superiorId)
            {
                return currentRow;
            }

            currentEmployee = currentEmployee.Superior;
            currentRow++;
        }

        return null;
    }


    public Employee? GetSuperior(int employeeId)
    {
        return Employees.FirstOrDefault(x => x.Key == employeeId).Value.Superior;
    }
}