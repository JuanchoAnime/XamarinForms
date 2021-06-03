namespace PruebaUI.ViewModels
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;
    using Xamarin.Forms;

    public class BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetProperty<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value)) return;

            backingField = value;
            this.OnPropertyChanged(propertyName);
        }

        protected void MostrarMensaje(string msg, string titulo = "Error", string botonAceptar = "OK", string botonCancelar = null)
        {
            if (botonCancelar == null)
                Application.Current.MainPage.DisplayAlert(titulo, msg, botonAceptar);
            else
                Application.Current.MainPage.DisplayAlert(titulo, msg, botonAceptar, botonCancelar);
        }

        protected string GetStringForDistionary(string key)
            => Application.Current.Resources[key].ToString();

    }
}
