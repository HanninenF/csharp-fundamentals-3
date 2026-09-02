# Setup av Exercise-template

## 1. Skapa mappstrukturen

```text
src/ProjectName/
└── Exercises/
```

## 2. Skapa templaten

```text
templates/Exercise/
├── .template.config/
│   └── template.json
└── Exercise1.cs
```

## 3. Skapa `template.json`

```json
{
  "identity": "Exercise",
  "name": "Exercise",
  "shortName": "exercise",
  "sourceName": "Exercise1",
  "classifications": ["C#", "Exercise"]
}
```

## 4. Skapa boilerplaten

I `Exercise1.cs`:

```csharp
namespace ProjectName.Exercises;

public static class Exercise1
{
    public static void Run()
    {
    }
}
```

## 5. Installera templaten

Kör från projektroten:

```powershell
dotnet new install .\templates\Exercise --force
```

## 6. Skapa en ny övning

```powershell
cd .\src\ProjectName\Exercises
dotnet new exercise -n Exercise2 --no-update-check
```

Det skapar `Exercise2.cs` med samma boilerplate.

Installera om templaten efter ändringar i `template.json` eller boilerplaten.
