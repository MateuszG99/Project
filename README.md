# Wypożyczalnia samochodów
Projekt zaliczeniowy na laboratoria z ASP.NET zbudowany zgodnie ze wzorcem MVC.

## Opis funkcjonalności:
Projekt symuluje uproszczony model zarządzania wypożyczalnią samochodów. Główną tabelą w projekcie jest Car, reprezentująca konkretny egzemplarz samochodu. 

Każdy Samochód poza numerem rejestracyjnym posiada 3 własności powiązane z innych tabel: Model samochodu, Lokalizację oraz klienta. 
Każda z podrzędnych własności jest osobną encją zawierającą dodatkowe informacje o powiązanym obiekcie (na przykład dla klienta jest to imię, nazwisko oraz PESEL).

- Aplikacja posiada po cztery formularze dla każdej z encji odpowiadające za:
  - Dodawanie nowego obiektu
  - Podgląd szczegółów istniejącego obiektu
  - Edycję istniejącego obiektu
  - Usunięcie obiektu z bazy danych
- Domyślna walidacj wprowadzonych wartości (zaimplementowana przy pomocy DataAnnotations)
- System indywidualnych kont użytkowników zbudowany na podstawie ASP.NET Identity z opcjonalną rolą Administratora

## Zastosowane technologie:
* .NET 6.0
* C# 10
* EntityFrameworkCore 6.0.25
* AspNetCore.Identity 6.0.25

## Opis instalacji:
* Pobrać projekt oraz uruchomić przy użyciu Visual Studio 2022
* Otworzyć Package Manage Console i poleceniem 'Update-database' utworzyć szkielet bazy danych.
* Uruchomić w programie Microsoft SQL Server Management Studio 18 załączoną w projekcie kwerendę wypełniającą bazę przykładowymi danymi.
* Uruchomić aplikację

#### Baza danych o nazwie "Project_CarRental" zostanie utworzona na lokalnym serwerze, zastosowany w aplikacji connection string to:
```
Server=(localdb)\\mssqllocaldb;Database=Project_CarRental;Trusted_Connection=True;MultipleActiveResultSets=true
```

## Pierwsze kroki:
Po uruchomieniu aplikacji wyświetli się strona główna informująca o konieczności zalogowania się.

Początkowo zostały utworzone dwa konta z różnymi opcjami dostępu:
- Użytkownik mający uprawnienia do podglądu i edycji jedynie nadrzędnej encji (Samochodu), dane logowania:
  - Login: user@car2go.pl
  - Hasło: Hasł0Usera
- Administrator mający uprawnienia do edytowania encji podrzędnych (Klientów, Modeli samochodów oraz Lokalizacji), dane logowania:
  - Login: admin@car2go.pl
  - Hasło: Hasł0Admina
 
Po zalogowaniu, w zależności od posiadanej rangi, można przeglądać, modyfikować, usuwać oraz dodawać poszczególne obiekty przy użyciu zbudowanego interfejsu.
