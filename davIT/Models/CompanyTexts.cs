using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace davIT.Models
{
    public static class CompanyTexts
    {
        #region setup
        public static string Controller = "Home";
        public static string IndexAction = "Index";
        public static string FuturesAction = "Futures";
        public static string AboutAction = "About";
        public static string ContactAction = "Contact";
        public static string NameConst = "DavIT Futures";
        public static string Name = string.Empty; //different for different pages
        public static string Footer = DateTime.Now.Year + " - " + NameConst;
        public static string ErrorH1 = "Error.";
        public static string ErrorH2 = "An error occurred while processing your request.";
        #endregion setup

        #region index
        public static string IndexTitle = "DavIT";
        public static string IndexMessage = "Custom software development";
        public static string IndexParagraph1 = "Mobile, web and desktop applications. Server side, backend and data access innovative solitions.";
        //public static string IndexLink1Href = @"http://asp.net/mvc";
        //public static string IndexLink1Title = "ASP.NET_MVC_4";
        //public static string IndexLink1bHref = @"http://www.windowsphone.com";
        //public static string IndexLink1bTitle = "WINDOWS_PHONE_7.5_oraz_8.0";
        //public static string IndexParagraph2 = "Ale przede wszystkim aplikacje desktopowe (WinForms, WPF), architektura klient-serwer (WebServices, WCF, WebApi)";
        //public static string IndexLink2Href = @"http://www.microsoft.com/pl-pl/download/details.aspx?id=17851";
        //public static string IndexLink2Title = ".NET Framework 4.0";
        public static string IndexH3 = "Tech solutions: ";
        public static string IndexH5a = "Mobile applications";
        public static string IndexH5aDesc = "Xamarin cross platform development";
        public static string IndexH5b = "Web applications";
        public static string IndexH5bDesc = "MVC 5.0, JS, CSS";
        public static string IndexH5c = "Desktop applications";
        public static string IndexH5cDesc = "WPF";
        public static string IndexH5d = "Server backend APIs";
        public static string IndexH5dDesc = "WCF";
        #endregion index
        #region futures
        public static string FuturesTitle = "Futures";
        public static string FutureParagraph1 = "Kontrakty terminowe to nasza pasja. Opracowujemy oprogramowanie wspierające podejmowanie decyzji inwestycyjnych w oparciu o metody analizy technicznej. Wypracowaną metodologię opakowujemy w automaty składające zlecenia także pod naszą nieobecność.";
        #endregion futures
        #region about
        public static string AboutTitle = "O nas";
        public static string AboutMessage = "Nawet nasza konkurencja chce pracować u nas";
        public static string AboutTitleAside = "Najnowsze technologie:";
        public static string AboutParagraph0 = "Mamy kilkuletnie doświadczenie w tworzeniu oprogramowania dla sektora finansowego. Posiadamy gruntowną wiedzę biznesową na temat funkcjonowania rynku bankowego oraz inwestycyjnego. Towarzystwa funduszy inwestycyjnych TFI, akcje, obligacje, kontrakty terminowe nie stanowią dla nas tajemnic.";
        public static string AboutParagraph1 = "Szybkość";
        public static string AboutParagraph2 = "Niezawodność";
        public static string AboutParagraph3 = "Bezpieczeństwo";   
        public static string AboutParagraph4 = "Na nas możesz polegać";
        #endregion about
        #region contact
        private static string mailTo = "mailto:";
        public static string ContactTitle = "Contact";
        public static string ContactMessage = "";
        public static string ContactFullName = "Dawid Domagała";
        public static string ContactPhoneLabel = "Mobile: ";
        public static string ContactPhoneValue = "";
        public static string ContactEmailLabel = "E-mail: ";
        public static string ContactEmailValue = "dd@davit.com.pl";
        public static string ContactEmailHref = mailTo + ContactEmailValue;
        #endregion contact

        internal static string GetIndexName()
        {
            return string.Format("{0}", NameConst);
        }

        internal static string GetFuturesName()
        {
            return string.Format("{0}", NameConst);
        }

        internal static string GetAboutName()
        {
            return string.Format("{0} - {1}", NameConst, AboutTitle);
        }

        internal static string GetContactName()
        {
            return string.Format("{0} - {1}", NameConst, ContactTitle);
        }
    }
}