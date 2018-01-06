using System.Xml;

namespace Weather
{
    /*
    *  Interfejs ITypeTemperature zawiera metode 
    *  zwracajaca typ temperatury jaka chcemy obslugiwac.
    *  
    *  Wyodrebnienie interfejsu pozwala latwo i bez wiekszych 
    *  zmian w kodzie rozszerzyc ilosc informacji o temperaturze
    *  jakie chcemy oblugiwac po przed dodanie nowej klasy
    *  implementujacej ten interfejs.
    * 
    */
    public interface ITypeTemperature
    {
        string GetTypeTemperature();
    }
}
