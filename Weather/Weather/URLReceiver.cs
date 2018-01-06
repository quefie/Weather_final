
namespace Weather
{
    /*
     *  Klasa URLReceiver odpowiedzialna jest za 
     *  utworzenie i zwrocenie pelnego adresu strony
     *  z ktorej bedziemy pobierac informacje o pogodzie.
     *  
     */
    public class URLReceiver
    {
        //API key zdefiniowany stale i wyodrebniony poniewaz jest on unikalny 
        //dla kazdego uzytkownika. Umozliwi to latwe ewentualne zmienienie go w przyslosci
        private const string APIKEY = "3419d419c8c396970c50d73790095ce5";
        private string currentURL;
        
        //Funkcja przyjmujaca nazwe miasta i generujaca adres URL dla danego miasta
        public URLReceiver(string city)
        {
            currentURL = "http://api.openweathermap.org/data/2.5/weather?q="
                + city + "&mode=xml&units=metric&APPID=" + APIKEY;
        }

        public string GetURL
        {
            get { return currentURL; }
        }
    }
}
