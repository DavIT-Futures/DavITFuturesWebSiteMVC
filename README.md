# 🌐 DavIT Futures – Strona Firmowa

<div align="center">

[![Deploy Status](https://github.com/DavIT-Futures/DavITFuturesWebSiteMVC/actions/workflows/deploy.yml/badge.svg)](https://github.com/DavIT-Futures/DavITFuturesWebSiteMVC/actions/workflows/deploy.yml)
[![GitHub Pages](https://img.shields.io/badge/Live%20Demo-GitHub%20Pages-2ea44f?style=for-the-badge&logo=github&logoColor=white)](https://davit-futures.github.io/DavITFuturesWebSiteMVC/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5.3-0078D7?style=for-the-badge&logo=windows&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![jQuery](https://img.shields.io/badge/jQuery-3.7.1-0769AD?style=for-the-badge&logo=jquery&logoColor=white)](https://jquery.com/)

<br />

**Oficjalna witryna internetowa firmy DavIT Futures (Dawid Domagała).**  
Dedykowane oprogramowanie na zamówienie: aplikacje mobilne, webowe, desktopowe oraz systemy serwerowe/backendowe.

[🚀 Zobacz wersję online](https://davit-futures.github.io/DavITFuturesWebSiteMVC/) • [✉️ Kontakt](#-kontakt) • [🛠️ Technologie](#%EF%B8%8F-stack-technologiczny)

---

</div>

## 📌 O Projekcie

Repozytorium zawiera kod źródłowy strony internetowej **DavIT Futures**:
* **Część backendowa (klasyczna):** Aplikacja internetowa stworzona w oparciu o wzorzec **MVC (Model-View-Controller)** w technologii **ASP.NET MVC 5.3** i **.NET Framework 4.8**.
* **Wdrożenie statyczne (GitHub Pages):** Automatyczny eksport i publikacja plików HTML, CSS i JS w ramach potoku CI/CD **GitHub Actions**, zintegrowany z bezserwerową obsługą formularza kontaktowego (**FormSubmit**).

---

## 🚀 Live Demo

Strona jest hostowana na platformie **GitHub Pages** pod adresem:
👉 **[https://davit-futures.github.io/DavITFuturesWebSiteMVC/](https://davit-futures.github.io/DavITFuturesWebSiteMVC/)**

---

## 🛠️ Stack Technologiczny

| Warstwa | Technologia / Narzędzie | Wersja |
| :--- | :--- | :--- |
| **Backend / Środowisko** | C#, .NET Framework | `4.8` |
| **Framework Web** | ASP.NET MVC | `5.3.0` |
| **Silnik Widoków** | Razor (`.cshtml`) | `3.3.0` |
| **Optymalizacja zasobów** | Microsoft.AspNet.Web.Optimization (WebGrease, Antlr) | `1.1.3` |
| **Frontend / Biblioteki** | jQuery, Modernizr | `3.7.1` / `2.8.3` |
| **Styling** | Klasyczny CSS3 (własny arkusz stylów) | `Site.css` |
| **Formularz kontaktowy** | FormSubmit (AJAX + fallback POST) | Bezserwerowy |
| **CI/CD & Hosting** | GitHub Actions + GitHub Pages | Automatyczny deploy |

---

## 📂 Struktura Projektu

```text
DavITFuturesWebSiteMVC/
├── .github/
│   └── workflows/
│       └── deploy.yml          # Workflow GitHub Actions publikujący stronę na Pages
├── davIT/                      # Kompletny projekt ASP.NET MVC (.NET Framework 4.8)
│   ├── App_Start/              # Konfiguracja routingu, bundli i filtrów
│   ├── Content/                # Arkusze stylów CSS (Site.css)
│   ├── Controllers/            # Kontroler HomeController (Index, Contact, About, Futures)
│   ├── Images/                 # Ikony, tła i elementy graficzne
│   ├── Models/                 # Modele danych (CompanyTexts, EmailMessage)
│   ├── Scripts/                # Skrypty klienckie (jQuery, Modernizr)
│   ├── Views/                  # Widoki Razor (.cshtml) i layouty (_Layout.cshtml)
│   ├── davIT.csproj            # Plik projektu MSBuild
│   └── Web.config              # Konfiguracja aplikacji IIS/ASP.NET
├── public/                     # Wygenerowana zoptymalizowana wersja statyczna
│   ├── index.html              # Strona główna
│   ├── contact.html            # Strona kontaktu z formularzem
│   ├── about.html              # O firmie
│   ├── futures.html            # Sekcja Futures
│   ├── 404.html                # Dedykowana strona błędu 404
│   ├── Content/                # Style produkcyjne
│   ├── Images/                 # Zasoby graficzne
│   ├── Scripts/                # Skrypty produkcyjne
│   └── .nojekyll               # Flaga dla GitHub Pages
├── davIT.sln                   # Plik rozwiązania Visual Studio
└── README.md                   # Niniejsza dokumentacja
```

---

## ✉️ Obsługa Formularza Kontaktowego

W wersji statycznej na GitHub Pages formularz kontaktowy zintegrowany jest z serwisem **FormSubmit**:
* **Asynchroniczna wysyłka (AJAX):** Użytkownik otrzymuje informację o wysłaniu wiadomości bez przeładowania strony.
* **Ochrona antyspamowa:** Wbudowane pole honeypot (`_honey`) chroniące przed botami.
* **Adres docelowy:** Wiadomości trafiają bezpośrednio na skrzynkę: `davit.futures@gmail.com`.

---

## ⚙️ Uruchomienie Lokalne

### Opcja 1: Pełna aplikacja w Visual Studio (ASP.NET MVC)
1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/DavIT-Futures/DavITFuturesWebSiteMVC.git
   ```
2. Otwórz plik `davIT.sln` w **Visual Studio 2022** (lub nowszym).
3. Przywróć pakiety NuGet (`Restore NuGet Packages`).
4. Uruchom projekt klawiszem `F5` (IIS Express).

### Opcja 2: Podgląd wersji statycznej
1. Przejdź do katalogu `public/`.
2. Uruchom dowolny lokalny serwer HTTP, np.:
   ```bash
   npx serve public
   # lub Python:
   python -m http.server -d public 8080
   ```
3. Otwórz w przeglądarce: `http://localhost:8080`.

---

## 🔄 CI/CD (GitHub Actions)

Każdy `git push` do gałęzi `main`:
1. Uruchamia workflow z pliku [`.github/workflows/deploy.yml`](.github/workflows/deploy.yml).
2. Pakuje zawartość katalogu `public/`.
3. Automatycznie publikuje najnowszą wersję na **GitHub Pages**.

---

<div align="center">

© 2026 **DavIT Futures** • Dawid Domagała  
Wrocław, Polska

</div>
