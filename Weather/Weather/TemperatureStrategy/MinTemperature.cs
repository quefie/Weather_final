namespace Weather
{
    /*
     *  Klasa implementujaca interfejs "ITypeTemperature" 
     *  przy jej pomocy identyfikujemy w klasie "TemperatureStrategy"
     *  typ temperatury, ktory chcemy pobrac
     *  w tym przypadku klasa odpowiada 
     *  za informacje dotyczace temperatury minimalnej.    
     */
    public class MinTemperature : ITypeTemperature
    {
        public string GetTypeTemperature()
        {
            return "min";
        }
    }
}
