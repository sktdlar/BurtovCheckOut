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

namespace BurtovCheckOut.Components.Pages
{
	/// <summary>
	/// Логика взаимодействия для AuthPage.xaml
	/// </summary>
	public partial class AuthPage : Page
	{
		public AuthPage()
		{
			InitializeComponent();
		}

		private void AuthBtn_Click(object sender, RoutedEventArgs e)
		{
			
			if(App.db.User.ToList().Any(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Text))
			{
				MessageBox.Show("Успешно");
				App.CurrentUser = App.db.User.ToList().Where(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Text).First();
			}
        }
    }
}
