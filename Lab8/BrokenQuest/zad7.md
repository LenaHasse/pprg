| Objaw lub komunikat | Przyczyna | Warstwa | Naprawa|
|:---:|:--:|:--:|:---:|
|`error CS0234: Typ lub przestrzeń nazw „Core” nie występuje w przestrzeni nazw „RogueArena”`| Brak w ProjectReference odwołania do `RogueArena.Core | projekt | dodanie referencji do projektu |
|`error CS0234: Typ lub przestrzeń nazw „Reward” nie występuje w przestrzeni nazw „RogueArena.Core”`| błędna nazwa | using | dodanie s na końcu |
|` error CS0246: Nie można znaleźć nazwy typu lub przestrzeni nazw „Companion”`| Companion była w przestrzeni Character zamiast Characters | namespace | dopisanie s w `Companion.cs` | 
| `error CS0122: 'Element „Companion” jest niedostępny z powodu swojego poziomu ochrony.`| Companion była domyślnie internal | dostępność | zrobienie klasy publiczną |