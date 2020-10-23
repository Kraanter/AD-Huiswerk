# AD
Code base voor QSD - Algoritmen & Datastructuren

## Indeling

- `[Algorithms]` : codebase voor algoritmen
  - `[Sorters]` : sorteeralgoritmen
    - `InsertionSort.cs`
    - `MergeSort.cs`
    - ...
- `[Datastructures]` : codebase voor datastructuren
  - `[MyArrayList]`
    - `IMyArrayList.cs` : het interface waar een `MyArrayList` aan
       moet voldoen.
    - `MyArrayList.cs` : de implementatie van `MyArrayList` (alle
      methods geven initieel een `NotImplemented` exception) 
    - `MyArrayListBuilder.cs` : de Builder van de datastructuur. Deze
        bevat vaak methods voor het creëren van instantiaties van de
        datastructuur. In dit geval wordt een `MyArrayList` aangemaakt
        en als `IMyArrayList` geretourneerd. De Builder wordt gebruikt
        door de unittesten
    - `MyArrayListTests.cs` : de testen behorend bij `MyArrayList`
  - `[MyLinkedList]`
  - ...
- `[Exam]` : de practica. Deze folder is leeg op GIT, maar dien je 
  tijdens het practicum te vullen met de uitgangssituatie van het
  practicum (te vinden op de ELO).
  
  Denk eraan dat je bij het
  inleveren je gehele codebase oplevert (i.v.m. links naar de al
  gemaakte datastructuren).
  - `[ad-20-21-vt-1]` : Eerste kans 20/21 voltijd : uitgangssituatie
  - `[proeftentamen-ad-19-20-vt-1]` : proefpracticum. Initieel leeg,
    maar moet gevuld worden met proeftentamen van ELO.
    - `[MIBTree]`
    - `[MIBTreeTests]`
    - `[RegioGraaf]`
    - `[RegioGraafTests]`
    - `ad-19-20-vt-1.sln`
- `[Homework]`
  - `[Les 2 - Basis datastructuren]`
    - `Huiswerk2.sln` : solution file met hierin de projecten
       `Huiswerk2/Huiswerk2.csproj` en `Tests/Tests.csproj`
    - `[Huiswerk2]`
      - `BracketChecker.cs` : losse huiswerkopdracht (geen invloed op
        de codebase)
      - `Huiswerk2.csproj` : projectfile met links  naar codebase
        (folder `~/src/Datastructures/MyArrayList`, de bestanden
        `IMyArrayList.cs`, `MyArrayList.cs`, `MyArrayListBuilder.cs`)
      - `Program.cs`
      - `[MyArrayList]` : deze folder is technisch leeg, maar vanuit
        Visual Studio zie je wel bestanden staan, Zie de uitleg bij
        `Huiswerk2.csproj`
      - `[MyLinkedList]`
      - ...
    - `[Tests]`
      - `BracketCheckerTests.cs` : tests voor losse huiswerkopdracht
        (geen tests op de codebase) 
      - `Tests.csproj` : projectfile met links naar de unittesten in
        de codebase (`MyArrayListTests`, `MyLinkedListTests`, etc.)
  - `[Les 3 - Recursie en sorteren]`
  - ...
- `[Utils]` : utilities (voor bijvoorbeeld testen)

## Richtlijnen
- Maak geen aanpassingen in interfaces
- Maak geen aanpassingen / toevoegingen in de gegeven unittest files
  - Je kunt altijd een extra file met unittests aanmaken (bijvoorbeeld
    `~/src/Homework/Les 2 - Basis datastructuren/Tests/MijnTests.cs`)
- Wil je toevoegingen aan je klasse maken die niet bij het huiswerk horen?
  - Schrijf de extra methods / properties in de al bestaande klasse
  - Omdat alle klassen als `partial class` zijn gedefinieerd, kun je ook
    kiezen voor:
    - Een nieuw bestand toevoegen aan je huiswerk (bijvoorbeeld
      `~/src/Homework/Les 2 - Basis datastructuren/MyArrayList/CoolerArrayList.cs`)
      met hierin een uitbreiding van de `partial class`
    - Een nieuw bestand toevoegen aan je codebase (bijvoorbeeld
      `~/src/Datastructures/MyArrayList/CoolerArrayList.cs`). Je moet dan
      wel in `Huiswerk2.csproj` een link leggen naar dit nieuwe bestand
