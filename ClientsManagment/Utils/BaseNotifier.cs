using System.ComponentModel;
using System.Reflection;

namespace ClientsManagment.Utils
{
    public class BaseNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NotifyPropertiesChanged()
        {
            var typeInfo = this.GetType();
            var properties = typeInfo.GetRuntimeProperties();

            foreach (var property in properties)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property.Name));
            }
        }
    }
}