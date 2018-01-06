namespace Weather
{
    /*
     *  Klasa implementujaca interfejs "ISunType" 
     *  przy jej pomocy identyfikujemy w klasie "SunStrategy"
     *  typ informacji, ktory chcemy pobrac
     *  w tym przypadku klasa odpowiada 
     *  za informacje dotyczace wschodu slonca.    
     */
    public class SunRise : ISunType
    {
        public SunRise()
        {
        }

        public string GetSunType()
        {
            return "rise";
        }
    }
}