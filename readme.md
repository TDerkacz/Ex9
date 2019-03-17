# Zad 9. ASP.NET Core IoC
Treść zadania od Macieja:
Celem zadania jest stworzenie prostej listy TODO, dostępnej przez przeglądarkę internetową. Chcemy udostępnić użytkownikowi następujące możliwości:

1. Wyświetlenie listy istniejących TODO.

2. Dodanie nowego TODO do listy.
 
Wymagania techniczne:

1. Aplikacja powinna wykorzystać ASP.NET Core z MVC. (tworzymy nowy projekt)

2. Implementujemy serwis (klasę), który będzie realizował 2 funkcjonalności. Po pierwsze będzie przechowywał i umożliwiał pobranie wszystkich elementów TODO. Dodatkowo pozwoli na dodanie nowego elementu TODO do już istniejących.

3. Serwis powinien być wstrzykiwany do kontrolera przez konstruktor (constructor injection). (wskazówka: konfiguracja kontenera IoC możliwa jest z poziomu klasy Startup)

4. Lista z dodanymi TODO powinna być dostępna przez cały czas działania aplikacji, czyli po odświeżeniu strony nadal widzimy to co dodaliśmy wcześniej (wskazówka: jaki object lifetime za to odpowiada?)

5. Nie przejmujemy się wyglądem/interfejsem graficznym aplikacji. Robimy minimalny działający interfejs np. wykorzystując elementy html <form> i <input> (https://www.w3schools.com/html/html_forms.asp)

 

Przydatne materiały:

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2

https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-2.2

W razie pytań, dawajcie znać :)

Powodzenia! :)

# Forma oddania zadania
Zadanie powinno być oddane w PullRequesta z oddzielnego brancha o nazwie w konwecji `nrZadania_ImięNazwisko` (np: `9_PatrykSzwermer`), jako target ustaw branch `master`. (*Pamiętaj żeby tworzyć nowego brancha z mastera!*)

[Ściągawka z tworzenia Pull Requestów w GitHubie](https://help.github.com/articles/creating-a-pull-request/)

---

# :clock3: Termin
## 20.03.2019, godz 23:59
