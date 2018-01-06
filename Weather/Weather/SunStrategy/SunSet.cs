namespace Weather
{
    /*
     *  Klasa implementujaca interfejs "ISunType" 
     *  przy jej pomocy identyfikujemy w klasie "SunStrategy"
     *  typ informacji, ktory chcemy pobrac
     *  w tym przypadku klasa odpowiada 
     *  za informacje dotyczace zachodu slonca.    
     */

    public class SunSet : ISunType
    {
        public SunSet()
        {
        }

        public string GetSunType()
        {
            return "set";
        }
    }
}