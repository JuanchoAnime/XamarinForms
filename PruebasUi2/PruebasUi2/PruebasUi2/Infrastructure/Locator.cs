namespace PruebasUi2.Infrastructure
{
    public class Locator
    {
        public ViewModel.MainViewModel Main { get; }

        public Locator()
        {
            this.Main = new ViewModel.MainViewModel();
        }
    }
}
