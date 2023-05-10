using System.Windows;

namespace Movies.WpfApp
{
    /// <summary>
    /// Interaction logic for MovieEntryWindow.xaml
    /// </summary>
    public partial class MovieEntryWindow : Window
    {
        public MovieEntryWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                $"Entry for Movie {TitleInput.Text} from {ReleaseYearInput.Text} accepted."
            );
        }
    }
}
