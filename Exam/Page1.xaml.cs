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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        ProfileEntities Profile = new ProfileEntities();
        userInfo user = new userInfo();
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var password = passbox.Password;
            var username = txtbox.Text;
            var GetName = Profile.userInfoes.Select(x=>x.Username).FirstOrDefault();
            var GetPassword = Profile.userInfoes.Where(x=>x.Password == password).FirstOrDefault();
            var GetUsername = Profile.userInfoes.Where(x => x.Username == username).FirstOrDefault();
            if(GetPassword != null && GetUsername != null)
            {
                Page3 page3 = new Page3(GetName);
                this.NavigationService.Navigate(page3);
            }
            else
            {
                MessageBox.Show("Fill all Data");
            }

        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Page2 page2 = new Page2();
            this.NavigationService.Navigate(page2);
        }
    }
}
