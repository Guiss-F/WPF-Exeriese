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

namespace GS.Music
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext= new MusicViewModel();
            Initialize();
        }

        void Initialize()
        {
            var vm= DataContext as MusicViewModel;
            if (null == vm)
            {
                return;
            }
            if (vm.LoginTypes.Count != 0)
            {
                LoginType.SelectedItem = vm.LoginTypes.ElementAt(0);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = TxtAccount.Text;
            string p = TxtPassWard.Text;

            if (a == "Admin" && p == "123456")
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("登陆失败");
            }

        }
    }
}
