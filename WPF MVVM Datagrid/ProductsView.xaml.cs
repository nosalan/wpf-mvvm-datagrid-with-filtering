using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace Products
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class ProductsView : Window
  {
    public ProductsView()
    {
      InitializeComponent();

      #region Composition Root
      var products = new ObservableCollection<Product>(ProductsStaticSource());
      var productsView = new CollectionViewSource { Source = products }.View;
      var filteringVm = new FilteringSubViewModel();
      DataContext = new ProductsViewModel(productsView, filteringVm,
        new ProductNameContainsFilter(filteringVm));
      #endregion
    }

    private static IEnumerable<Product> ProductsStaticSource()
    {
      return new List<Product>
                       {
                         new Product
                           {
                             Id = 51,
                             Name = "Canned pork",
                             Category = "Food",
                             Description = "For quick and easy meals in minutes",
                             EuropeanArticleNumber = "0000488424432"
                           },
                         new Product
                           {
                             Id = 53,
                             Name = "Oatmeal",
                             Category = "Food",
                             Description = "Oatmeal from oat of European crops",
                             EuropeanArticleNumber = "0000553754320"
                           },

                         new Product
                           {
                             Id = 122,
                             Name = "Camembert",
                             Category = "Food",
                             Description = "Cheese",
                             EuropeanArticleNumber = "0000658850910"
                           },
                         new Product
                           {
                             Id = 177,
                             Name = "Maple syrup",
                             Category = "Food",
                             Description = "Syrup made from the xylem sap of sugar maple",
                             EuropeanArticleNumber = "0000437230074"
                           },
                         new Product
                           {
                             Id = 178,
                             Name = "Honey",
                             Category = "Food",
                             Description = "N/A",
                             EuropeanArticleNumber = "0000485566664"
                           },
                         new Product
                           {
                             Id = 190,
                             Name = "Blackcurrant juice",
                             Category = "Food",
                             Description = "Blackcurrant (Ribes nigrum) juice",
                             EuropeanArticleNumber = "0000546334569"
                           },
                         new Product
                           {
                             Id = 199,
                             Name = "Picture frame",
                             Category = "Decorative",
                             Description = "Wall decor & art",
                             EuropeanArticleNumber = "0000553655311"
                           },

                         new Product
                           {
                             Id = 210,
                             Name = "Vase",
                             Category = "Decorative",
                             Description = "Wall decor & art",
                             EuropeanArticleNumber = "0000734531171"
                           },
                         new Product
                           {
                             Id = 218,
                             Name = "Lantern",
                             Category = "Decorative",
                             Description = "Wall decor & art",
                             EuropeanArticleNumber = "0000600390222"
                           },
                         new Product
                           {
                             Id = 244,
                             Name = "Candle",
                             Category = "Decorative",
                             Description = "Wall decor & art",
                             EuropeanArticleNumber = "0000489996675"
                           }
                         ,
                       };
    }
  }
}
