namespace XamGMaps.ViewModel
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using XamGMaps.Model;

    public class MapPageViewModel
    {
        public MapPageViewModel()
        {
        }

        internal async Task<List<Vehicle>> Vehicles()
        {
            await Task.Delay(5000);

            return new List<Vehicle>()
            {
                new Vehicle { Latitude = 10.394704, Longitud = -75.479973, Desc = "T101" },
                new Vehicle { Latitude = 10.393744, Longitud = -75.483934, Desc = "T102" },
                new Vehicle { Latitude = 10.394384, Longitud = -75.487398, Desc = "T103" },
                new Vehicle { Latitude = 10.379385, Longitud = -75.462902, Desc = "X106"},
            };
        }
    }
}
