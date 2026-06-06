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
using System.Collections.Generic;

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

        }


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
                message.Text = "Nice to meet you " + name + "is there any cybersecurity topic that sparks your interest?";
                message.Foreground = Brushes.HotPink;
            }
        }


        public void FavTopic()
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
                fav.Foreground = Brushes.HotPink;
            }

        }


        Random rand = new Random();

        public void BotTopics()
        {
            string chats = pick.Text;
            string state = info.Text;
            string concern = detect.Text;

            if (!chats.Contains("password") && !chats.Contains("scam") && !chats.Contains("privacy"))
            {
                paragrapgh.Text = "I'm sorry your choice doesn't meet the bots topics";
                paragrapgh.Foreground = Brushes.Red;
            }

            if (chats.Contains("password"))
            {
                paragrapgh.Text = "As someone who's interested in " + chats + " aim for a password length of atleast 12 characters long.";
                paragrapgh.Foreground = Brushes.HotPink;

            }
            else if (state.Contains("another tip") || state.Contains(("explain more")) || state.Contains("tell me more"))
            {
                List<string> passwordTip = new List<string>();
                {
                    passwordTip.Add("Regularly change your password to minimize the risk of data breaches and unauthorised " +
                        "access especially for critical accounts like email and banking.");
                    passwordTip.Add("Implement two-factor authentication which adds an extra layer of security such as a temporary code sent to your phone.");
                    passwordTip.Add("Include a mix of characters such as uppercase and lowercase letters, numbers and special characters.");
                    passwordTip.Add("Avoid using easily discoverable information like your name, birthdate or your partners name, family members or pets");

                    foreach (var tips in passwordTip)
                    {

                        int index = rand.Next(passwordTip.Count);
                        information.Text = passwordTip[index];
                        information.Foreground = Brushes.HotPink;

                    }

                }
            }
            else if (!state.Contains("another tip") && !state.Contains("explain more") && !state.Contains("tell me more"))
            {
                information.Text = "Oh no looks like you missed something, try to re-phrase it again please.";
                information.Foreground = Brushes.Red;
            }
            else if (concern.Contains("worried") || concern.Contains("confused") || concern.Contains("frustrated"))
            {
                Dictionary<string, string> emotion = new Dictionary<string, string>();
                {
                    emotion.Add("worried", "I understand why that feels worrying but remember all you have to do is make them long.");
                    emotion.Add("confused", "I can help clarify that just stick to randomly mixed numbers, letters and symbols.");
                    emotion.Add("frustrated", "I understand your frustration simply make each password unique.");

                    foreach (var motion in emotion)
                    {
                        if (concern.Contains(motion.Key))
                        {
                            additionalTips.Text = motion.Value;
                            additionalTips.Foreground = Brushes.HotPink;
                            break;
                        }
                        else
                        {
                            additionalTips.Text = " I'm sorry i didn't quite get that.";
                            additionalTips.Foreground = Brushes.Red;
                        }
                    }
                }

            }


            if (chats.Contains("scam"))
            {
                paragrapgh.Text = "Since your enthusiastic about " + chats + " " +
                    "ensure the sites URL begins with https and that a closed lock icon is visible near the address bar.";
                paragrapgh.Foreground = Brushes.HotPink;
            }
            else if (state.Contains("give me another tip") || state.Contains("explain more") || state.Contains("tell me more"))
            {
                List<string> phishingTip = new List<string>();
                {
                    phishingTip.Add("Educate yourself by staying informed about common online threats and how to recognize them");
                    phishingTip.Add("Inspect strange emails by either performing a long press or hover your mouse over URL links to preview them.");
                    phishingTip.Add("Regularly update your operating system, browsers and apps. Updates include security patches.");
                    phishingTip.Add("Consider using password managers to generate and store passwords for you.");

                    foreach (var tips in phishingTip)
                    {
                        int index = rand.Next(phishingTip.Count);
                        information.Text = phishingTip[index];
                        information.Foreground = Brushes.HotPink;
                    }
                }

            }
            else if (!state.Contains("give me another tip") && !state.Contains("explain more") && !state.Contains("tell me more"))
            {
                information.Text = "Oh no looks like you missed something, mind rephrasing it please.";
                information.Foreground = Brushes.Red;
            }
            else if (concern.Contains("worried") || concern.Contains("confused") || concern.Contains("frustrated"))
            {
                Dictionary<string, string> emotion = new Dictionary<string, string>();
                {
                    emotion.Add("worried", "I hear your concern if you fall victim to an attempt report it at the ReportFraud.ftc.gov.");
                    emotion.Add("confused", "Here's a clearer way to look at it multi-factor authentication makes it harder for scammers to log into your accounts.");
                    emotion.Add("frustrated", "That sounds exhausting just beware of suspicious links that want you to " +
                        "make a payment its usually corrupted with malware.");

                    foreach (var motion in emotion)
                    {

                        if (concern.Contains(motion.Key))
                        {
                            additionalTips.Text = motion.Value;
                            additionalTips.Foreground = Brushes.HotPink;
                            break;
                        }
                        else
                        {
                            additionalTips.Text = " I'm sorry i didn't quite get that.";
                            additionalTips.Foreground = Brushes.Red;
                        }
                    }
                }
            }


            if (chats.Contains("privacy"))
            {
                paragrapgh.Text = "Since you're all about " + chats + " you need to limit the personal information you share online.";
                paragrapgh.Foreground = Brushes.HotPink;
            }
            else if (state.Contains("give me another tip") || state.Contains("explain more") || state.Contains("tell me more"))
            {
                List<string> browsingTip = new List<string>();
                {
                    browsingTip.Add("Use secure networks especially on public Wi-Fi like a VPN which adds an extra of protection by encrypting data in transit.");
                    browsingTip.Add("Review permissions and app access regularly.");
                    browsingTip.Add("Recognize emotional manipulation online.");
                    browsingTip.Add("Treat online safety as an ongoing habit because staying informed, revisiting basic practices and " +
                        "adjusting behavior overtime builds resilience.");

                    foreach (var tips in browsingTip)
                    {
                        int index = rand.Next(browsingTip.Count);
                        information.Text = browsingTip[index];
                        information.Foreground = Brushes.HotPink;
                    }
                }

            }
            else if (!state.Contains("give me another tip") && !state.Contains("explain more") && !state.Contains("tell me more"))
            {
                information.Text = "Oh no looks like you missed something mind rephrasing it please.";
                information.Foreground = Brushes.Red;
            }
            else if (concern.Contains("worried") || concern.Contains("confused") || concern.Contains("frustrated"))
            {
                Dictionary<string, string> emotion = new Dictionary<string, string>();
                {
                    emotion.Add("worried", "It's okay to feel uncertain" +
                        " about this certain sites request permissions from your browsers to access your cameras, microphones and geolocational data.");
                    emotion.Add("confused", "Let's simplify it step by step " +
                        "your browser can collect data about your browsing habits and share it with third parties to deliver targeted adverts to you.");
                    emotion.Add("frustrated", "It makes total sense that your " +
                        "frustrated your device can use your IP address and Wi-Fi to collect and share information about your location with websites.");

                    foreach (var motion in emotion)
                    {

                        if (concern.Contains(motion.Key))
                        {
                            additionalTips.Text = motion.Value;
                            additionalTips.Foreground = Brushes.HotPink;
                            break;
                        }
                        else
                        {
                            additionalTips.Text = " I'm sorry i didn't quite get that.";
                            additionalTips.Foreground = Brushes.Red;
                        }
                    }
                }
            }

        }

        public void topicQuestions() 
        { 
            List<Questions> questions = new List<Questions>();
            {
                questions.Add(new Questions
                { txtQuestion = "What is meant by the term phishing?" ,
                rb1 = "A)Online fraud that tricks people into providing sensitive information like passwords or card information.",
                rb2 = "B)Advising teenagers on how to properly catch a fish.",
                rb3 = "C)It's an expression used in culinary terms.",
                rb4 = "D)It's a form of spyware.",
                correct = "A"});

                questions.Add(new Questions
                { txtQuestion = "What are some red flags that an email you received is probably a scam?",
                rb1 = "A)The email is generic.",
                rb2 = "B)The email says your account is on hold because of a billing problem.",
                rb3 = "C)The email invites you to click on a link to update your payment details.",
                rb4 = "D)All of the above.",
                correct = "D"});

                questions.Add(new Questions
                {txtQuestion = "If you received a phishing email what authorities would you report it to?" ,
                rb1 = "A)SAPS",
                rb2 = "B)SABC",
                rb3 = "C)CIA",
                rb4 = "D)FTC",
                correct = "D"});

                questions.Add(new Questions
                { txtQuestion = "Why should you always strive for longer passwords?",
                rb1 = "A)Longer passwords make it harder for attackers to guess or crack it through brute force methods.",
                rb2 = "B)It's meant to look like that.",
                rb3 = "C)It reduces the risk of exploiting your personal information.",
                rb4 = "D)To be able to share it with unknown people online.",
                correct = "A"});

                questions.Add(new Questions
                { txtQuestion = "What potential risks am i going to face if i don't change my passwords regularly?",
                rb1 = "A)You might get a free voucher.",
                rb2 = "B)Risks related to data breaches and unauthorised access for critical accounts like email or banking.",
                rb3 = "C)Some random individual might have access to your work phone number.",
                rb4 = "D)Someone may have access to your Netflix account.",
                correct = "B"});

                questions.Add(new Questions
                {
                    txtQuestion = "What role do special characters play when creating passwords?",
                    rb1 = "A)They make the password more aesthetically appealing.",
                    rb2 = "B)They ensure that your password is as strong as possible.",
                    rb3 = "C)Hackers wont be able to gain access to your information.",
                    rb4 = "D)To safeguard my favorite clothing brand account information.",
                    correct = "B"
                });


                questions.Add(new Questions
                {
                    txtQuestion = "Choosing to not update my device means that my software will run efficiently.",
                    rb1 = "True.",
                    rb2 = "False.",
                    correct = "False"
                });

                questions.Add(new Questions
                {
                    txtQuestion = "Using HTTPS encrypts data exchanged between your web browser and the website your visiting making it difficult for hackers to intercept your information.",
                    rb1 = "True.",
                    rb2 = "False.",
                    correct = "True"
                });

                questions.Add(new Questions 
                {
                    txtQuestion = "Being aware of the latest online threats and how to protect yourself is crucial in maintaining your online security..",
                    rb1 = "True.",
                    rb2 = "False.",
                    correct = "True"
                });

                questions.Add(new Questions
                {
                    txtQuestion = "Social engineering is a harmless action whereby people unknowingly share sensitive information about themselves.",
                    rb1 = "True.",
                    rb2 = "False.",
                    correct = "False"
                });

                questions.Add(new Questions
                {
                    txtQuestion = "It's a must that you allow an unknown individual to physically follow you to a restricted area while claiming they have mislaid their pass.",
                    rb1 = "True.",
                    rb2 = "False.",
                    correct = "False"
                });

                questions.Add(new Questions
                {
                    txtQuestion = "Social engineering attacks are not always easy to detect and therefore organisations should never conduct proper training for their staff.",
                    rb1 = "True.",
                    rb2 = "False.",
                    correct = "False"
                });
            }
        }
        
 
        
       
    }
}