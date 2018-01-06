namespace Weather
{
    /*
     *  Interfejs ISunType zawiera metode 
     *  zwracajaca typ informacji jaka chcemy obsluzyc.
     *  
     *  Wyodrebnienie interfejsu pozwala latwo i bez wiekszych 
     *  zmian w kodzie rozszerzyc ilosc informacji o sloncu
     *  jakie chcemy oblugiwac po przed dodanie nowej klasy
     *  implementujacej ten interfejs.
     * 
     */
    public interface ISunType
    {
        string GetSunType();
    }
}