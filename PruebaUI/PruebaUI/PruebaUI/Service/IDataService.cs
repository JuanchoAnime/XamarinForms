namespace PruebaUI.Service
{
    using PruebaUI.ItemViewModel;
    using PruebaUI.Models;
    using System.Collections.Generic;

    public interface IDataService
    {
        List<Burgue> GetAllBurgues();
    }
}
