using System.Windows;
using System.Windows.Media.Animation;

namespace WpfSlidingMenu
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

        private void OpenMenuIconButton_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuIconButton.Visibility = Visibility.Collapsed;
            CloseMenuIconButton.Visibility = Visibility.Visible;
            (Resources["CloseMenuRotationStoryBoard"] as Storyboard)?.Begin(this);
        }

        private void CloseMenuIconButton_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuIconButton.Visibility = Visibility.Visible;
            CloseMenuIconButton.Visibility = Visibility.Collapsed;
            (Resources["OpenMenuRotationStoryBoard"] as Storyboard)?.Begin(this);
        }

        private void ExitIconButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
