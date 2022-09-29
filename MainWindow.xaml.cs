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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person objectPerson;
        public MainWindow()
        {
            InitializeComponent();
            textFname.Focus();
            
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            //Person objectPerson=new Person();
            objectPerson = new Person();
            objectPerson.Fname=textFname.Text;
            objectPerson.Lname=textLname.Text;
            
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            if(objectPerson == null)
            {
                MessageBox.Show("You have to click Set-button first");
            }
            else
            {
                MessageBox.Show("Hello " + objectPerson.Fname + " " + objectPerson.Lname);
                //textFname.Text = "";
                //textLname.Text = "";
                textFname.Clear();
                textLname.Clear();
            }
            
        }
    }
}
