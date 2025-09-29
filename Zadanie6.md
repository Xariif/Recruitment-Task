# 6. Zakładając, że parametry metody z zadania 3 pobieramy bezpośrednio z bazy danych. Czy znasz jakieś sposoby na optymalizację liczby zapytań SQL w tego typu przypadkach? Wymień i opisz krótko każdy z nich.

- Napisanie i wykorzystanie procedury zwracajej jedynie ilość wolnych dni po id usera
- Dodanie tabeli pomocniczej która była by aktualizowana np w godzinach nocnych (celem oszczędzania zasobów). Zawierała by ona id usera, rok którego dotyczy zestawienie, oraz wolne dni
- Zapewne dało by również przechować niektóre dane w cache, lecz nie miałem z tym do tej pory styczności w C# i .NET