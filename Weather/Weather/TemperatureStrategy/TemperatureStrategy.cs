using System.Xml;

namespace Weather
{
    /*  
    *  Do obslugi i przetwarzania informacji dotyczacych 
    *  temperatury zostal wyodrebniony folder "TemperatureStrategy"
    *  a w nim zawarte wszystkie klasy i interfejsy obslugujace informacje 
    *  dotyczace slonca.
    *  
    *  Klasa TemperatureStrategy to glowna funkcja obslugujaca 
    *  i przetwarzajaca informacje 
    *  dotyczacych temperatury (aktualna/min/max).
    * 
    */
    public class TemperatureStrategy
    {
        // obiekt interfejsu umozliwiajacy dzialanie na danej klasie
        // inplementujacej interfejs. 
        private ITypeTemperature _typeTemperature;

        public TemperatureStrategy()
        {
        }

        public void SetTypeTemperature(ITypeTemperature typeTemperature)
        {
            _typeTemperature = typeTemperature;
        }

        //Funkcja pobierajaca dana (aktualna/min/max) temperature 
        public string GetTemperature(XmlDocument xmlDocument)
        {
            // Dzialanie na fragmencie dokumentu dotyczacego temperatury
            XmlNode tempNode = xmlDocument.SelectSingleNode("//temperature");
            // Pobieranie wartosci temperatury (aktualna/min/max) w zaleznosci 
            // ktorej klasy konstruktor zostal wywolany w "SetTypeTemperature"
            XmlAttribute tempAttribute = tempNode.Attributes[_typeTemperature.GetTypeTemperature()];
            return tempAttribute.Value;
        }
    }
}
