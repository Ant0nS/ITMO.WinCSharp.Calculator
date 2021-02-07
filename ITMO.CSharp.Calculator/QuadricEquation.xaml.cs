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
using System.Windows.Shapes;

namespace ITMO.CSharp.Calculator
{
    /// <summary>
    /// Interaction logic for QuadricEquation.xaml
    /// </summary>
    public partial class QuadricEquation : Window
    {
        public QuadricEquation()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Solve_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            try
            {
                double a = Convert.ToDouble(textBoxValueA.Text);
                double b = Convert.ToDouble(textBoxValueB.Text);
                double c = Convert.ToDouble(textBoxValueC.Text);
                double x1;
                double x2;
                double d = b * b - 4 * a * c;
                if (d >= 0)
                {
                    if (d > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        MessageBox.Show("The discriminant is " + d + ". First root is " + x1 + ". Second root is " + x2 + ".");
                    }
                    else
                    {
                        x1 = (-b + Math.Abs(d)) / (2 * a);
                        x2 = x1;
                        MessageBox.Show("The discriminant is zero. The root is " + x1 + ".");
                    }

                }
                else
                {
                    MessageBox.Show("The discriminant is less than zero. No roots.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
