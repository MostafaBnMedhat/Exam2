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

namespace Exam
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        ProfileEntities Profile = new ProfileEntities();
        userInfo user = new userInfo();
        public Page3( string name)
        {
            InitializeComponent();
            nmaeLa.Content = name;
            datauser.ItemsSource = Profile.userInfoes.Where(x=>x.Username == name).ToList();
        }
    }
}
