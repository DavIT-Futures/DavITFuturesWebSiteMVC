# 🌐 DavIT Futures – Website / Strona Firmowa

<div align="center">

[![Deploy Status](https://github.com/DavIT-Futures/DavITFuturesWebSiteMVC/actions/workflows/deploy.yml/badge.svg)](https://github.com/DavIT-Futures/DavITFuturesWebSiteMVC/actions/workflows/deploy.yml)
[![GitHub Pages](https://img.shields.io/badge/Live%20Demo-GitHub%20Pages-2ea44f?style=for-the-badge&logo=github&logoColor=white)](https://davit-futures.github.io/DavITFuturesWebSiteMVC/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5.3-0078D7?style=for-the-badge&logo=windows&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![jQuery](https://img.shields.io/badge/jQuery-3.7.1-0769AD?style=for-the-badge&logo=jquery&logoColor=white)](https://jquery.com/)

<br />

### 🌐 Select Language / Wybierz Język
**[🇬🇧 English Version](#-english-version)** • **[🇵🇱 Wersja Polska](#-wersja-polska)**

---

</div>

<a id="english-version"></a>
## 🇬🇧 English Version

### 📌 About The Project
Official corporate website for **DavIT Futures** (Dawid Domagała).  
DavIT Futures delivers custom software solutions: mobile applications, web platforms, desktop software, and high-performance server/backend APIs.

* **Backend (.NET Framework 4.8):** Built using the classic **ASP.NET MVC 5.3** architectural pattern (Model-View-Controller) with Razor views.
* **Static Deployment (GitHub Pages):** Automated CI/CD pipeline using **GitHub Actions** that builds and deploys static production assets, integrated with serverless contact form delivery via **FormSubmit**.

### 🚀 Live Demo
The site is hosted and available online at:  
👉 **[https://davit-futures.github.io/DavITFuturesWebSiteMVC/](https://davit-futures.github.io/DavITFuturesWebSiteMVC/)**

### 🛠️ Tech Stack
| Component | Technology | Version |
| :--- | :--- | :--- |
| **Backend Runtime** | C#, .NET Framework | `4.8` |
| **Web Framework** | ASP.NET MVC | `5.3.0` |
| **View Engine** | Razor (`.cshtml`) | `3.3.0` |
| **Asset Optimization** | Microsoft.AspNet.Web.Optimization (WebGrease, Antlr) | `1.1.3` |
| **Frontend Libraries** | jQuery, Modernizr | `3.7.1` / `2.8.3` |
| **Styles** | Custom CSS3 stylesheet | `Site.css` |
| **Contact Form** | FormSubmit (AJAX + fallback POST) | Serverless |
| **CI/CD & Hosting** | GitHub Actions + GitHub Pages | Automated |

### 📂 Repository Structure
```text
DavITFuturesWebSiteMVC/
├── .github/workflows/deploy.yml # GitHub Actions deployment workflow
├── davIT/                      # Full ASP.NET MVC project (.NET 4.8)
│   ├── App_Start/              # Bundles, filters, and routing configuration
│   ├── Content/                # Stylesheets (Site.css)
│   ├── Controllers/            # HomeController (Index, Contact, About, Futures)
│   ├── Images/                 # Icons, backgrounds, and graphical assets
│   ├── Models/                 # Data models (CompanyTexts, EmailMessage)
│   ├── Scripts/                # Client-side scripts (jQuery, Modernizr)
│   ├── Views/                  # Razor views (.cshtml) and layout templates
│   ├── davIT.csproj            # MSBuild project file
│   └── Web.config              # IIS / ASP.NET application configuration
├── public/                     # Pre-rendered static assets deployed to Pages
│   ├── index.html              # Home page
│   ├── contact.html            # Contact page with serverless form
│   ├── about.html              # About page
│   ├── futures.html            # Futures trading & algorithms page
│   ├── 404.html                # Custom 404 error page
│   ├── Content/                # Production stylesheets
│   ├── Images/                 # Production images
│   ├── Scripts/                # Production JavaScript libraries
│   └── .nojekyll               # Disables Jekyll processing on GitHub Pages
├── davIT.sln                   # Visual Studio Solution file
└── README.md                   # Project documentation (Bilingual)
```

### ✉️ Contact Form
The static version on GitHub Pages uses **FormSubmit** for serverless message delivery:
* **Asynchronous Submission (AJAX):** Feedback is shown in-page without reloading.
* **Anti-Spam:** Integrated honeypot field (`_honey`).
* **Recipient:** Delivered directly to `davit.futures@gmail.com`.

### ⚙️ How to Run Locally
#### Option 1: Visual Studio (ASP.NET MVC)
1. Clone the repository:
   ```bash
   git clone https://github.com/DavIT-Futures/DavITFuturesWebSiteMVC.git
   ```
2. Open `davIT.sln` in **Visual Studio 2022** (or later).
3. Restore NuGet Packages (`Restore NuGet Packages`).
4. Press `F5` to run with IIS Express.

#### Option 2: Static Site Preview
1. Navigate to the `public/` directory.
2. Run any static HTTP server, for example:
   ```bash
   npx serve public
   # or with Python:
   python -m http.server -d public 8080
   ```
3. Open `http://localhost:8080` in your browser.

---

<a id="wersja-polska"></a>
## 🇵🇱 Wersja Polska

### 📌 O Projekcie
Oficjalna witryna internetowa firmy **DavIT Futures** (Dawid Domagała).  
Dedykowane oprogramowanie na zamówienie: aplikacje mobilne, webowe, desktopowe oraz systemy serwerowe/backendowe.

* **Część backendowa (.NET Framework 4.8):** Aplikacja internetowa stworzona w oparciu o wzorzec **MVC (Model-View-Controller)** w technologii **ASP.NET MVC 5.3**.
* **Wdrożenie statyczne (GitHub Pages):** Automatyczny eksport i publikacja plików HTML, CSS i JS w ramach potoku CI/CD **GitHub Actions**, zintegrowany z bezserwerową obsługą formularza kontaktowego (**FormSubmit**).

### 🚀 Live Demo
Strona jest hostowana na platformie **GitHub Pages** pod adresem:  
👉 **[https://davit-futures.github.io/DavITFuturesWebSiteMVC/](https://davit-futures.github.io/DavITFuturesWebSiteMVC/)**

### 🛠️ Stack Technologiczny
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

### ✉️ Obsługa Formularza Kontaktowego
W wersji statycznej na GitHub Pages formularz kontaktowy zintegrowany jest z serwisem **FormSubmit**:
* **Asynchroniczna wysyłka (AJAX):** Informacja o wysłaniu wiadomości bez przeładowania strony.
* **Ochrona antyspamowa:** Wbudowane pole honeypot (`_honey`) chroniące przed botami.
* **Adres docelowy:** Wiadomości trafiają bezpośrednio na skrzynkę: `davit.futures@gmail.com`.

### ⚙️ Uruchomienie Lokalne
#### Opcja 1: Pełna aplikacja w Visual Studio (ASP.NET MVC)
1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/DavIT-Futures/DavITFuturesWebSiteMVC.git
   ```
2. Otwórz plik `davIT.sln` w **Visual Studio 2022** (lub nowszym).
3. Przywróć pakiety NuGet (`Restore NuGet Packages`).
4. Uruchom projekt klawiszem `F5` (IIS Express).

#### Opcja 2: Podgląd wersji statycznej
1. Przejdź do katalogu `public/`.
2. Uruchom serwer HTTP:
   ```bash
   npx serve public
   # lub Python:
   python -m http.server -d public 8080
   ```
3. Otwórz w przeglądarce: `http://localhost:8080`.

---

<div align="center">

© 2026 **DavIT Futures** • Dawid Domagała  
Wrocław, Poland / Polska

</div>
