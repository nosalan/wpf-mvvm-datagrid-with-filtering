using System.ComponentModel;
using System.Windows.Input;

namespace Products
{
  public class ProductsViewModel
  {
    private readonly IFilter _filter;
    public ICommand FilterApply { get; }
    public ICommand FilterRemove { get; }

    public IFilteringSubViewModel FilteringVm
    {
      get;
    }

    public ICollectionView Products
    {
      get;
    }

    public ProductsViewModel(ICollectionView products,
      IFilteringSubViewModel filteringSubViewModel, IFilter filter)
    {
      Products = products;
      FilteringVm = filteringSubViewModel;
      _filter = filter;
      FilterApply = new DelegateCommand(OnFilterApply);
      FilterRemove = new DelegateCommand(OnFilterRemove);
    }

    public void OnFilterApply()
    {
      FilteringVm.Apply();
      Products.Filter = _filter.Apply;
    }

    public void OnFilterRemove()
    {
      FilteringVm.Clear();
      Products.Filter = null;
    }
  }
}
