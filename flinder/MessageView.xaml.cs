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
    /// Logique d'interaction pour MessageView.xaml
    /// </summary>
    public partial class MessageView : UserControl
    {
        public MessageView(string messagetext, string messagesince)
        {
            InitializeComponent();
            this.message_since.Content = messagesince;
            this.message_text.Content = message_text;
        }
    }
}
