using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
      //  public int AppValue { get; set; }

        public int AppValue
        {
            get { return (int)GetValue(AppValueProperty); }
            set { SetValue(AppValueProperty, value); }
        }
        public static readonly DependencyProperty AppValueProperty =
            DependencyProperty.Register("AppValue", typeof(int),
            typeof(MainWindow), new PropertyMetadata(null)

        );




        public MainWindow()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
            AppValue = 500;
           object sd = tb03.DataContext;
        }

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DatePicker_CalendarClosed");
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("TextBox_TextChanged");
        }

        private void DatePicker_CalendarClosed(object sender, SelectionChangedEventArgs e)
        {
            text01.Text = dataPiker.SelectedDate.ToString();
            (tb03.DataContext as MainWindow).AppValue = 20;
            tb03.Text= AppValue.ToString();


        }
    }



    public class WidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double val = (double)value;
            if (val < 30) val = 100;
            else val = val + 100;
            
            
           
            return val;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
           
            return value;
        }
    }
}