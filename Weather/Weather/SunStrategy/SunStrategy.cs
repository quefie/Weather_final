using System.Xml;

namespace Weather
{
    /*  
     *  Do obslugi i przetwarzania informacji dotyczacych 
     *  slonca zostal wyodrebniony folder "SunStrategy"
     *  a w nim zawarte wszystkie klasy i interfejsy obslugujace informacje 
     *  dotyczace slonca.
     *  
     *  Klasa SunStrategy to glowna funkcja obslugujaca 
     *  i przetwarzajaca informacje 
     *  dotyczacych slonca (wschod/zachod).
     * 
     */
    public class SunStrategy
    {
        // obiekt interfejsu umozliwiajacy dzialanie na danej klasie
        // inplementujacej interfejs. 
        private ISunType _sunType;

        public SunStrategy()
        {
        }

        
        public void SetType(ISunType sunType)
        {
            _sunType = sunType;
        }

        //Funkcja pobierajaca dana (wschod/zachod) informacje o sloncu
        public string GetTypeSun(XmlDocument xmlDocument)
        {
            // Dzialanie na fragmencie dokumentu dotyczacego slonca
            XmlNode tempNode = xmlDocument.SelectSingleNode("//sun");
            // Pobieranie wartosci atrybutu (wschod/zachod) w zaleznosci 
            // ktorej klasy konstruktor zostal wywolany w "SetType"
            XmlAttribute tempAttribute = tempNode.Attributes[_sunType.GetSunType()];
            // Formatowanie danych wyjsciowych (wyodrebnienie godziny)
            return tempAttribute.Value.Remove(0, 11);
        }
    }
}