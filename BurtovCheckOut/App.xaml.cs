using BurtovCheckOut.Components.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BurtovCheckOut
{
	/// <summary>
	/// Логика взаимодействия для App.xaml
	/// </summary>
	public partial class App : System.Windows.Application
	{
		public static User CurrentUser;
		public static BurtovCheckOutEntities db = new BurtovCheckOutEntities();
	}
}
