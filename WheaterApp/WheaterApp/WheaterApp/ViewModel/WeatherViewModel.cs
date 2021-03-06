namespace WheaterApp.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using WheaterApp.Model;
    using WheaterApp.Service;
    using Xamarin.Forms;

    public class WeatherViewModel: BaseViewModel
    {
        public static WeatherViewModel INSTANCE { get; set; }

        public  async Task<Wheater> GetCity()
        {
            try
            {
                
                Wheater data = await DependencyService.Get<IDataService>().GetWheater("Turbaco");
                data.Temperatures.ForEach(temp =>
                {
                    temp.DateOfDtTxt = $"Dia: {temp.DtTxt.ToString("yyyy-MM-dd")}, Hora: {temp.DtTxt.ToString("hh:mm:ss tt")}";
                    temp.Main.TemperatureGlobal = $"Temperatura {temp.Main.TempMin}(Min) - {temp.Main.TempMax}(Max)";
                });
                string[] moths = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                data.DayNow = $"{moths[DateTime.Now.Month]} {DateTime.Now.Day}, {DateTime.Now.ToString("hh:mm tt")}";
                return data;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Oops", ex.Message, "Ok");
                return null;
            }
        }
    }
}