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
using System.Media;
namespace Cybot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // chatBotGreeting();
            Username();
     
        }
        /*
        private void chatBotGreeting()
        {
            string greeting = "/audio/cybotgreeting (online-audio-converter.com).wav";
            SoundPlayer player = new SoundPlayer(greeting);
            player.Play();
        }
        */

        private void Press_Click(object sender, RoutedEventArgs e)
        {
            string name = username.Text;
            Username();
        }

        private void Username()
        {
            string name = username.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                username.Foreground = Brushes.Red;
                username.Text = "Please enter your name";
            }
            else
            {
                username.Foreground = Brushes.Blue;
                username.Text = "Nice to meet you " + name + "is there any cybersecurity topic that sparks your interest?";
            }
        }

        private void FavTopic() 
        { 


        }

    }
}