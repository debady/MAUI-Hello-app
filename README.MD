#  APP POUR SE FAMILIARISER AVEC .NET

> dotnet workload install maui-android

### COMMANDE D'EXECUTION WINDOWS 
> dotnet clean
> dotnet build -f net8.0-windows10.0.19041.0
> dotnet run -f net8.0-windows10.0.19041.0


### COMMANDE TEST ANDROID PHYSIQUE

> dotnet build -t:Run -f net10.0-android -c Debug
> dotnet watch run -f net8.0-android
> dotnet build -t:Run -f net8.0-android -c Debug


```markdown
 MyFirstMauiApp

Ma première application mobile développée avec **.NET MAUI**.  
Ce projet m’a permis de découvrir pas à pas comment créer, exécuter et tester une application multiplateforme (Windows + Android) avec l’écosystème .NET.

---

 Objectifs du projet

- Découvrir la structure d’un projet **.NET MAUI**
- Comprendre le rôle de chaque fichier (XAML, C#, projet)
- Construire et tester l’application sur **Windows**
- Configurer le **mode développeur Android**
- Tester l’application sur un **téléphone physique Android**
- (Optionnel) Préparer la génération d’un **APK pour distribution**

---

 Structure du projet

```

MyFirstMauiApp/
├── App.xaml                 → Définition globale des ressources et styles
├── App.xaml.cs              → Logique d’initialisation de l’application
├── MainPage.xaml            → Interface utilisateur (XAML)
├── MainPage.xaml.cs         → Code-behind de la page principale (C#)
├── MauiProgram.cs           → Point d’entrée .NET (configuration et services)
├── Platforms/               → Code spécifique à chaque plateforme
│   ├── Android/             → Permissions, MainActivity, etc.
│   ├── Windows/             → Config spécifique Windows
│   ├── iOS/                 → Config spécifique iOS (si besoin)
├── Resources/               → Images, polices, styles
├── MyFirstMauiApp.csproj    → Fichier de configuration du projet
└── README.md              

````

---

Pré-requis

- **.NET 8 SDK** ou supérieur  
- **Workloads MAUI installés :**
  ```bash
  dotnet workload install maui
  dotnet workload install maui-android
  dotnet workload install maui-windows
````

* **Visual Studio 2022/2025** avec :

  * .NET MAUI
  * Windows SDK (≥ 10.0.19041)
  * MSIX Packaging Tools
* (Pour Android) SDK Platform Tools (`adb`)

---

##  Étapes de développement

###  Créer le projet

```bash
dotnet new maui -n MyFirstMauiApp
cd MyFirstMauiApp
```

###  Construire et tester sur Windows

```bash
dotnet build -t:Run -f net8.0-windows10.0.19041.0
```

💡 Une fenêtre s’ouvre avec l’interface de ton application.

###  Activer le Hot Reload

Pour un rechargement automatique comme Flutter :

```bash
dotnet watch run -f net8.0-windows10.0.19041.0
```

###  Préparer le téléphone Android

Sur ton téléphone :

* Active le **mode développeur**
* Active le **débogage USB**
* Branche ton téléphone et autorise le PC

Vérifie la détection :

```bash
adb devices
```

###  Exécuter sur Android

```bash
dotnet build -t:Run -f net8.0-android -c Debug
```

###  (Optionnel) Générer un APK

```bash
dotnet publish -f net8.0-android -c Release -o ./publish /p:AndroidPackageFormat=apk
```

L’APK sera disponible dans le dossier `./publish`.

---

## 🪄 Exemple de code principal

**MainPage.xaml**

```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyFirstMauiApp.MainPage">
    <VerticalStackLayout Padding="30">
        <Label Text="Welcome to .NET MAUI!" FontSize="32" HorizontalOptions="Center" />
        <Entry x:Name="NameEntry" Placeholder="Enter your name" />
        <Button Text="Say Hello" Clicked="OnCounterClicked" />
        <Label x:Name="GreetingLabel" />
    </VerticalStackLayout>
</ContentPage>
```

**MainPage.xaml.cs**

```csharp
namespace MyFirstMauiApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        GreetingLabel.Text = $"Hello {NameEntry.Text}! You've clicked {count} times.";
    }
}
```

---

## 🧩 Commandes utiles

| Action                                 | Commande                                         |
| -------------------------------------- | ------------------------------------------------ |
| Nettoyer le projet                     | `dotnet clean`                                   |
| Construire pour Windows                | `dotnet build -f net8.0-windows10.0.19041.0`     |
| Construire pour Android                | `dotnet build -f net8.0-android`                 |
| Lancer avec hot reload                 | `dotnet watch run -f net8.0-windows10.0.19041.0` |
| Lister les workloads installés         | `dotnet workload list`                           |
| Lister les appareils Android connectés | `adb devices`                                    |

---

##  Licence

Ce projet est développé à des fins d’apprentissage.
Libre à toi de le modifier et l’améliorer.

---

##  Auteur

**Mr Nguessan**
Créé avec ❤️ en découvrant .NET MAUI et C#.
