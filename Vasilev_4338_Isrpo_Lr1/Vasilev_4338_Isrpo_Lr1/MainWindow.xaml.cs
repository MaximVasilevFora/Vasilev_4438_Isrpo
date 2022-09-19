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

namespace Vasilev_4338_Isrpo_Lr1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static WelcomeWindow welcomeWindow;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Next_Click(object sender, RoutedEventArgs e)
		{
			if (welcomeWindow == null)
			{
				welcomeWindow = new WelcomeWindow();
				welcomeWindow.Show();
			}
		}

		private void WelcomeText_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			MessageBox.Show("Еще раз привет!)");
		}
	}
}
