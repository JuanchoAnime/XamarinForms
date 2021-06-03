namespace PruebaUI.Infrastructure
{
    public class Locator
    {
        public ViewModels.MainViewModel Main { get; set; }   

        public Locator()
        {
            this.Main = new ViewModels.MainViewModel();
        }
    }
}
