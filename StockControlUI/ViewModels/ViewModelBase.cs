using System.ComponentModel;

namespace LihueDev.StockControl.UI.ViewModels
{
    public class ViewModelBase : IViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
