using System.Net;
using System.Xml;

namespace Weather
{
    /*  
     *  Klasa XMLReceive odpowiedzialna jest za pobranie 
     *  dany ze strony openweathermap.org.     *  
     *   
     *  Jest w nej zawarta tylko jedna funkcja odpowiedzialna
     *  za pobranie ze strony danych i zapisanie w programie 
     *  danych w formacie dokumentu xml do dalszego dzialania z danymi.
     *  
     *  Finalnie zwraca dokument xml.   
     */

    public class XMLReceive
    {
        public XmlDocument GetXML(string CurrentURL)
        {
            // lączenie sie ze strona openweathermap.org
            using (WebClient client = new WebClient())
            {
                //pobranie danych ze strony i zapisanie ich w zmiennej typu string
                string xmlContent = client.DownloadString(CurrentURL);
                //Utworzenie nowej zmiennej typu xmldocument i przypisanie jej wartosci pobranej ze strony
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);
                return xmlDocument;
            }
        }
    }
}
