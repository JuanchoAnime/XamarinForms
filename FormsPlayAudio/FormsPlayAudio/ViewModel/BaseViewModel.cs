namespace FormsPlayAudio.ViewModel
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;

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

    }
}
