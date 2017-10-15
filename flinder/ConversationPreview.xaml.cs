using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace flinder
{
    /// <summary>
    /// Logique d'interaction pour ConversationPreview.xaml
    /// </summary>
    public partial class ConversationPreview : UserControl
    {
        public ConversationPreview(string name,string message,string since,string avatar)
        {
            
            InitializeComponent();
            this.name.Content = name;
            this.message.Content = message;
            this.since.Content = since;
            //this.avatar.ImageSource = new BitmapImage(new Uri(@"/images/"+avatar, UriKind.Relative));
        }
    }
}
