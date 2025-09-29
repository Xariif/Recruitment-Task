# 3. Uzupełnij metodę w języku C# która wylicza ile jeszcze dni urlopowych ma do wykorzystania pracownik w bieżącym roku. (Struktura danych jak w zadaniu 2)

    public int CountFreeDaysForEmployee(Employee employee, List<Vacation> vacations,
    VacationPackage vacationPackage )
    {

        int freeDays = vacationPackage.grantedDays;
        
        foreach(var v in vacations)
        {
            int usedDays = (v.dateSince - v.dateUntil ).Days;
            freeDays -= usedDays;
        }

        return freeDays;
    }