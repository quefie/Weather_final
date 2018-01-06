using Weather;
using System;
using System.Windows;
using System.Windows.Input;
using System.Xml;

namespace Weather
{
    /*
     *  Glowna klasa programu obslugujaca aplikacje.
     *  Zawarta jest w niej obsluga wyjatkow i wywolywane
     *  sa dzialania i metody warunkujace poprawne dzialanie programu.  
     */
    public partial class MainWindow : Window
    {
        private XmlDocument xmlDocument = new XmlDocument();
        private XMLReceive xmlGetter = new XMLReceive();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Metoda wywolywana przy kliknieciu okna /ENTER/ w programie
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Pobieramy i zapisujemy miasto podane przez uzytkownika
            string enteredCityName = txtEnteredCityName.Text;
            //Przed wywolaniem glownej metody obslugujacej program "CheckActuallyWeather"
            //Przy pomocy metody "CityNameIsProperly" sprawdzamy poprawnosc wpisanej nazwy miasta
            if (CityNameIsProperly(enteredCityName))
                CheckActuallyWeather();
        }

        //Metoda wywolywana przy kliknieciu przycisku fizycznego /ENTER/ zamiast ikony w programie
        private void TextBlock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //Pobieramy i zapisujemy miasto podane przez uzytkownika
                string enteredCityName = txtEnteredCityName.Text;
                //Przed wywolaniem glownej metody obslugujacej program "CheckActuallyWeather"
                //Przy pomocy metody "CityNameIsProperly" sprawdzamy poprawnosc wpisanej nazwy miasta
                if (CityNameIsProperly(enteredCityName))
                    CheckActuallyWeather();
            }
        }

        //Metoda sprawdzajaca czy uzytkownik poprawnie podal miasto
        private bool CityNameIsProperly(string enteredCityName)
        {
            //Wywolana zostaje metoda sprawdzajaca czy uzytkownik podal wartosc
            if (NotEnternedCityName(enteredCityName))
                return false;
            //Wywolana zostaje metoda sprawdzajaca czy wartosc jest poprawna
            if (EnternedWrongCityName(enteredCityName))
                return false;
            return true;
        }

        //Metoda sprawdzajaca czy uzytkownik podal jakakolwiek wartosc 
        private bool NotEnternedCityName(string enteredCityName)
        {
            if (String.IsNullOrWhiteSpace(enteredCityName))
            {
                lblWeatherDescription.Content = "Nie podales miasta";
                return true;
            }

            return false;
        }

        //Metoda sprawdzajaca czy miasto podane przez uzytkownika istnieje 
        private bool EnternedWrongCityName(string enteredCityName)
        {
            if (int.TryParse(enteredCityName, out int result))
            {
                lblWeatherDescription.Content = "Nie ma takiego miasta";
                return true;
            }

            return false;
        }


        /*
         * Glowna metoda programu. Odpowiada za pobranie i obsluge
         * informacji i wyswietlenie ich na ekranie.     
         * 
         * Wywolywana po sprawdzeniu poprawnosci nazwy miasta
         */
        private void CheckActuallyWeather()
        {
            string enteredCityName = txtEnteredCityName.Text;

            //Dodatkowa obsluga wyjatkow w formie try{} catch{}
            try
            {
                //Pobieramy adres strony przy pomocy obiektu klasy URLRceiver i zdefiniowanej w niej metody
                var currentUrl = new URLReceiver(enteredCityName).GetURL;

                //Zostaje przypisana wartosc dla dokumentu zdefiniowanego na poczatku programu
                xmlDocument = xmlGetter.GetXML(currentUrl);

                //Uzyta zmienna /var/ zamiast string dla czystoci i przejzystosci kodu.
                //Tworzymy obiekt klasy obslugujacej informacje o temperaturze
                var temperature = new TemperatureStrategy();

                /*
                 *   Operowanie na typie interfejsu w klasie "TemperatureStrategy" pozwala w prosty sposob 
                 *   pobrac typ (aktualny/min/max) temperatury, ktory nas interesuje
                 *   Przypisujemy zmiennej wartosc maxymalna/minimalna/aktualna temperatury
                 */
                temperature.SetTypeTemperature(new MaxTemperature());                
                var maxTemperature = temperature.GetTemperature(xmlDocument);            
                temperature.SetTypeTemperature(new MinTemperature());
                var minTemperature = temperature.GetTemperature(xmlDocument);
                temperature.SetTypeTemperature(new ActualTemperature());
                var actualTemperature = temperature.GetTemperature(xmlDocument);

                // W podobny sposob jak temperature obslugujemy informacje o sloncu
                var sun = new SunStrategy();
                sun.SetType(new SunRise());
                var sunRise = sun.GetTypeSun(xmlDocument);
                sun.SetType(new SunSet());
                var sunSet = sun.GetTypeSun(xmlDocument);


                //Wypisywanie danych wyjsciowych
                lblWeatherDescription.Content =
                    "\nMiasto:  " + enteredCityName +
                    "\nTemperatura: " + actualTemperature + "C" +
                    "\nTemperatura maksymalna:  " + maxTemperature + "C" +
                    "\nTemperatura minimalna:   " + minTemperature + "C" +
                    "\nWschod slonca:   " + sunRise +
                    "\nZachod slonca:   " + sunSet + "\n\n\n" +
                    enteredCityName.GetTypeCode();
            }
            catch (Exception ex)
            {
                lblWeatherDescription.Content = "Nie ma takiego miasta";
            }
        }
    }
}
