using System.Collections.Specialized;
using System.

namespace WpfApp4.ViewModels
{
    internal class MainViewModel : INotifyCollectionChanged
    {
        private string _upperString;

        public string UpperString
        {
            get { return this._upperString; }
            private set
            {
                SetProperty(ref this._upperString, value);
            }
        }

        private string _inputString;

        public string InputString
        {
            get { return this._inputString; }
            set
            {
                if (SetProperty(ref this._inputString, value))
                {
                    this.UpperString = this._inputString.ToUpper();
                    System.Diagnostics.Debug.WriteLine("UpperString=" + this.UpperString);
                }
            }
        }

        #region INotifyPropertyChanged の実装
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            var h = this.PropertyChanged;
            if (h != null)
            {
                h(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool SetProperty<T>(ref T target, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(target, value))
            {
                return false;
            }
            target = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
        #endregion INotifyPropertyChanged の実装

    }
}