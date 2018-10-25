using System.ComponentModel;

namespace Products
{
  public interface IFilterOption
  {
    string FilterTerm { get; }
  }

  public interface IFilteringSubViewModel
  {
    string FilterTerm { get; }
    bool FilterActive { get; }
    void Apply();
    void Clear();
  }

  public class FilteringSubViewModel : INotifyPropertyChanged, 
                IFilterOption, IFilteringSubViewModel
  {
    public event PropertyChangedEventHandler PropertyChanged;

    private bool _filterActive;
    private string _filterTerm = string.Empty;

    public string FilterTerm
    {
      get { return _filterTerm; }
      set
      {
        _filterTerm = value;
        NotifyPropertyChanged(nameof(FilterTerm));
      }
    }

    public bool FilterActive
    {
      get { return _filterActive; }
      set
      {
        _filterActive = value;
        NotifyPropertyChanged(nameof(FilterActive));
      }
    }

    public void Apply()
    {
      FilterActive = true;
    }

    public void Clear()
    {
      FilterTerm = string.Empty;
      FilterActive = false;
    }

    private void NotifyPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
