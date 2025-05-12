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

namespace UserComponent.Views
{
    public partial class Card : UserControl
    {

        private string _buttontext = string.Empty;

        public string MyButtonText
        {
            get { return _buttontext; }
            set
            {
                _buttontext = value;
                EventButton.Content = value;
            }
        }


        public Card()
        {
            InitializeComponent();



        }
    }
}
