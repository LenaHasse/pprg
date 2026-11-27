# Rogue Semester

## Opis

Rogue Semester to konsolowa gra o krótkiej wyprawie bohatera. Gracz podaje imię, wybiera przeciwników do walki, zdobywa złoto i może wyświetlić raport bohatera. Wyprawa kończy się po śmierci bohatera, pokonaniu wszystkich przeciwników albo wyborze zakończenia gry.

## Budowanie i uruchamianie

Otwórz terminal VS Code w folderze `RogueSemester`, w którym znajduje się plik `RogueSemester.sln`, i wykonaj:

```powershell
dotnet build .\RogueSemester.sln
dotnet run --project .\RogueSemester.App\RogueSemester.App.csproj
```

## Struktura projektu

```text
RogueSemester/
├── RogueSemester.sln
├── RogueSemester.App/
│   ├── GlobalUsings.cs
│   ├── Program.cs
│   └── UI/
│       └── GameController.cs
├── RogueSemester.Core/
│   ├── Characters/
│   │   ├── Player.cs
│   │   ├── Enemy.cs
│   │   └── Companion.cs
│   ├── Combat/
│   │   └── CombatRules.cs
│   └── Items/
│       ├── Item.cs
│       ├── Weapon.cs
│       └── Inventory.cs
└── RogueSemester.Reporting/
    ├── GlobalUsings.cs
    └── Reports/
        ├── PlayerReport.cs
        └── ExpeditionReport.cs
```

## Zależności projektów

```text
RogueSemester.App ------> RogueSemester.Core
        |
        +---------------> RogueSemester.Reporting ------> RogueSemester.Core
```

`RogueSemester.Core` nie zależy od pozostałych projektów.

## Ważne typy

| Typ | Pełna nazwa |
|---|---|
| Gracz | `RogueSemester.Core.Characters.Player` |
| Przeciwnik | `RogueSemester.Core.Characters.Enemy` |
| Przedmiot | `RogueSemester.Core.Items.Item` |
| Broń | `RogueSemester.Core.Items.Weapon` |
| Ekwipunek | `RogueSemester.Core.Items.Inventory` |
| Reguły walki | `RogueSemester.Core.Combat.CombatRules` |
| Raport bohatera | `RogueSemester.Reporting.Reports.PlayerReport` |
| Raport wyprawy | `RogueSemester.Reporting.Reports.ExpeditionReport` |

## Namespace i importy

Każdy własny typ ma jawny namespace rozpoczynający się od nazwy projektu.

Pliki `GlobalUsings.cs` znajdują się osobno w projektach `App` i `Reporting`. Import globalny działa tylko w projekcie, w którym został zadeklarowany.

W `GameController.cs` alias `GameWeapon` wskazuje na `RogueSemester.Core.Items.Weapon`. Alias odróżnia modelową broń gry od ewentualnego typu prezentacyjnego o tej samej krótkiej nazwie.

Przy tworzeniu mikstury użyto pełnej nazwy `RogueSemester.Core.Items.Item`. Komentarz przy tym miejscu wyjaśnia, że wskazuje ono typ modelu z projektu `Core`.

## Problemy napotkane podczas pracy

1. **Nieznany typ `Inventory`.** Typ znajdował się w namespace `RogueSemester.Core.Items`; poprawiono import.
2. **Błędy w wyborze przeciwnika.** Metoda początkowo nie otrzymywała listy przeciwników i miała niezgodny typ zwracany. Przekazywana jest jej lista, a zwracanym typem jest `Enemy`.
3. **Miecz pojawiał się wielokrotnie w raporcie.** Ten sam miecz dodano do ekwipunku więcej niż raz, a raport wypisywał broń dwukrotnie. Usunięto powtórne dodawanie i poprawiono wypisywanie kolekcji.