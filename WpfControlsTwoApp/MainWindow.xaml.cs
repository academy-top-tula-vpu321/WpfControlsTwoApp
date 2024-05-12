using System.Diagnostics.Eventing.Reader;
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

namespace WpfControlsTwoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox login;
        PasswordBox password;

        public MainWindow()
        {
            InitializeComponent();

            //GroupBox grpBox = new GroupBox();
            //grpBox.Header = "Group for person";
            //grpBox.FontSize = 30;
            //grpBox.Padding = new Thickness(20);

            //StackPanel stackGroup = new();
            //grpBox.Content = stackGroup;

            //login = new TextBox();
            //login.FontSize = 30;
            //password = new PasswordBox();
            //password.FontSize = 30;
            //TextBlock loginLabel = new TextBlock();
            //loginLabel.FontSize = 30;
            //loginLabel.Text = "Login";
            //TextBlock passwLabel = new TextBlock();
            //passwLabel.FontSize = 30;
            //passwLabel.Text = "Password";

            //Button btnPerson = new Button();
            //btnPerson.FontSize = 30;
            //btnPerson.Content = "Click me";
            //btnPerson.Click += BtnPerson_Click;

            //stackGroup.Children.Add(loginLabel);
            //stackGroup.Children.Add(login);
            //stackGroup.Children.Add(passwLabel);
            //stackGroup.Children.Add(password);
            //stackGroup.Children.Add(btnPerson);


            //stack.Children.Add(grpBox);
        }

        private void BtnPerson_Click(object sender, RoutedEventArgs e)
        {
            string message = $"Login: {login.Text}, Password: {password.Password}";

            MessageBox.Show(message);
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineUp();
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineDown();
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineLeft();
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineRight();
        }

        private void btnTop_Click(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToTop();
        }

        private void btnBottom_Click(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToBottom();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void txtBox_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    popup.IsOpen = true;
        //}
    }
}