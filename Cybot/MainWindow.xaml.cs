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
          
            //PressClick();
         
        }
        /*
        private void chatBotGreeting()
        {
            string greeting = "/audio/cybotgreeting (online-audio-converter.com).wav";
            SoundPlayer player = new SoundPlayer(greeting);
            player.Play();
        }
        */

        private void PressClick(object sender, RoutedEventArgs e)
        {
          
            Username();
            FavTopic();
            BotTopics();
        }

        private void Username()
        {
            string name = username.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.Text = "I need your name please";
                message.Foreground = Brushes.Red;
            }
            else
            {
                message.Text= "Nice to meet you " + name + "is there any cybersecurity topic that sparks your interest?";
                message.Foreground = Brushes.Blue;
            }
        }

        private void FavTopic() 
        { 
            string topic = favTopic.Text;
            if (string.IsNullOrWhiteSpace(topic))
            {
                fav.Text = "I'm sorry i didn't get that please re-enter your topic";
                fav.Foreground = Brushes.Red;
            }
            else 
            {
                fav.Text = "Great! I'll be sure to remember that you're interested in " + topic + ". It's a crucial part of staying safe online.";
                fav.Foreground = Brushes.Blue;
            }

        }

        private void BotTopics()
        {
            string chats = choice.Text;
           if(!chats.Contains("password") && !chats.Contains("scam") && !chats.Contains("privacy"))
            {
                paragrapgh.Text = "I'm sorry your choice doesn't meet the bots topics";
                paragrapgh.Foreground = Brushes.Red;
            }
           
           if(chats.Contains("password"))
            {
                paragrapgh.Text = "Aim for a password length of atleast 12 characters long";
            }

           if(chats.Contains("scam"))
            {
                paragrapgh.Text = "Ensure the sites URL begins with https and that  a closed lock icon is visibile near the address bar";
            }

           if(chats.Contains("privacy"))
            {
                paragrapgh.Text = "Limit the personal information  you share online";
            }
        }
        

    }
}