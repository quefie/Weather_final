namespace Weather
{
    /*
   *  Klasa implementujaca interfejs "ITypeTemperature" 
   *  przy jej pomocy identyfikujemy w klasie "TemperatureStrategy"
   *  typ temperatury, ktory chcemy pobrac
   *  w tym przypadku klasa odpowiada 
   *  za informacje dotyczace temperatury maxymalnej.    
   */
    public class MaxTemperature : ITypeTemperature
    {
        public string GetTypeTemperature()
        {
            return "max";
        }
    }
}
