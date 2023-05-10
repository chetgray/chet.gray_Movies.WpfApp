using System.Windows;
using System.Windows.Controls;

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
            foreach (UIElement child in FormLayout.Children)
            {
                if (
                    (child is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                    || (child is ComboBox comboBox && comboBox.SelectedIndex == -1)
                )
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }
            }

            MessageBox.Show(
                $"Entry for Movie {TitleInput.Text} from {ReleaseYearInput.Text} accepted."
            );
            foreach (UIElement child in FormLayout.Children)
            {
                switch (child)
                {
                    case TextBox textBox:
                        textBox.Text = string.Empty;
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        break;
                }
            }
        }
    }
}
