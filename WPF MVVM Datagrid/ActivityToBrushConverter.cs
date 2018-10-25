using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Products
{
  public class ActivityToBrushConverter : IValueConverter
  {
    private readonly Brush _activeBrush = new SolidColorBrush(Color.FromArgb(255, 255, 191, 191));
    private readonly Brush _inactiveBrush = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return (bool) value ? _activeBrush : _inactiveBrush;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotSupportedException();
    }
  }
}
