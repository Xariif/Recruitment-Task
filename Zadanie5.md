# 5. Napisz dwa proste testy jednostkowe które sprawdzą działanie zaimplementowanej metody z zadania numer 4.

Na codzień nie tworzę testów, ale miałem z nimi styczność podczas staży, studiów oraz w pracy przy kilku narzędziach wewnętrznych. Pracowałem jedynie na xunit, poniższe podejście jest prawidłowe, lecz można było by oczywiście użyć bardziej zaawansowanego podjeścia poprzez wykorzystanie bibliotek do generowania danych testowych i sprawdzania corner case'ów. 

    [Fact]
    public void employee_can_request_vacation()
    {
        //Arrange
        var service = new Service();
        var testEmployee = new Employee(1, "Maciek");
        var testVacations = new List<Vacation>(); 
        var testPackage = new VacationPackage(26); // jako parametr przyjmuje liczbę dni

        //Act

        var res = service.IfEmployeeCanRequestVacation(testEmployee,testVacations,testPackage)

        //Assert
        Assert.True(res);
    }

    [Fact]
    public void employee_cant_request_vacation()
    {
        //Arrange
        var service = new Service();
        var testEmployee = new Employee(1, "Maciek");
        var testVacations = new List<Vacation>(); 
        var testPackage = new VacationPackage(0); 

        //Act

        var res = service.IfEmployeeCanRequestVacation(testEmployee,testVacations,testPackage)

        //Assert
        Assert.False(res);
    }
