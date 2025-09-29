# 4. Na podstawie zadania 3 napisz metodę która sprawdza czy pracownik może zgłosić wniosek urlopowy. (Struktura danych jak w zadaniu 2)

    public bool IfEmployeeCanRequestVacation(Employee employee, List<Vacation> vacations,
    VacationPackage vacationPackage)
    {
        int freeDays = CountFreeDaysForEmployee(employee,vacations,vacationPackage);

        if(freeDays <= 0 ) return false;
        else return true;
    }