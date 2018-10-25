using System;

namespace Products
{
  public interface IFilter
  {
    bool Apply(object parameter);
  }

  public class ProductNameContainsFilter : IFilter
  {
    private readonly IFilterOption _filterOption;

    public ProductNameContainsFilter(IFilterOption filterOption)
    {
      _filterOption = filterOption;
    }

    public bool Apply(object parameter)
    {
      return ((Product)parameter).Name.IndexOf
               (_filterOption.FilterTerm, 
                StringComparison.InvariantCultureIgnoreCase)
               >= 0;
    }
  }
}