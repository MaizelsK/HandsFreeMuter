using System.Windows;

namespace HFM.Desktop
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void ButtonAddName_Click(object sender, RoutedEventArgs e)
    {
      if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstDevices.Items.Contains(txtName.Text))
      {
        lstDevices.Items.Add(txtName.Text);
        txtName.Clear();
      }
    }
  }
}
