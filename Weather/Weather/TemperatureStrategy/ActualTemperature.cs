namespace Weather
{
    /*
   *  Klasa implementujaca interfejs "ITypeTemperature" 
   *  przy jej pomocy identyfikujemy w klasie "TemperatureStrategy"
   *  typ temperatury, ktory chcemy pobrac
   *  w tym przypadku klasa odpowiada 
   *  za informacje dotyczace temperatury aktualnej.    
   */
    public class ActualTemperature : ITypeTemperature
    {
        public string GetTypeTemperature()
        {
            return "value";
        }
    }
}
