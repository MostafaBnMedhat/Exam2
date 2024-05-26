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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        ProfileEntities profileEntities = new ProfileEntities(); 
        userInfo user = new userInfo();
        public Page2()
        {
            InitializeComponent();
            ComCity.Items.Add("Giza");
            ComCity.Items.Add("Ciro");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user.Username = txt_username.Text;
            user.Password = passwordbox.Password;
            user.Age = int.Parse(txt_age.Text);
            user.Phone = txt_phoneNumber.Text;
            if(Radio_Male .IsChecked == true) 
            {
                user.Gender = "Male";
            }
            else if(Radio_female .IsChecked == true) 
            {
                user.Gender = "Female";
            }
            user.City = ComCity.Text;
            profileEntities.userInfoes.Add(user);
            profileEntities.SaveChanges();
            MessageBox.Show("data Saved");
            Page1 page = new Page1();
            this.NavigationService.Navigate(page);
        }
    }
}
