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

namespace CrazyText
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

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            string UserEnter = UserBox.Text;
            char[] sp = new char[20];
            for (int i = 0; i < UserEnter.Length; i++)
            {
                sp[i] = Convert.ToChar(UserEnter[i]);
            }

            for (int i = 1; i < sp.Length; i = i+2)
            {
                sp[i] = char.ToUpper(sp[i]);
            }
            string crazy;
            crazy = new string(sp);
            lbl.Content = crazy;

        }
    }
}
