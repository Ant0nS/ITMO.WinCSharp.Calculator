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
using Calculator;

namespace ITMO.CSharp.Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(oneOut);
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(twoOut);
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(threeOut);
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(fourOut);
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(fiveOut);
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(sixOut);
        }

        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(sevenOut);
        }

        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(eightOut);
        }

        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(nineOut);
        }

        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcNumber(zeroOut);
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcDecimal();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            CalcEngine.CalcReset();
            
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubstract);
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSum);
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcSign();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcDelete();
        }
   
        private void Square_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcSquare();
            CalcEngine.CalcReset();
        }

        private void Cube_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcCube();
            CalcEngine.CalcReset();
        }

        private void Factorial_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcFactorial();
            CalcEngine.CalcReset();
        }

        private void SqrRoot_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcSqrRoot();
            CalcEngine.CalcReset();
        }

        private void CubeRoot_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcCubeRoot();
            CalcEngine.CalcReset();
        }

        private void InverseValue_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = CalcEngine.CalcInverseValue();
            CalcEngine.CalcReset();
        }

        private void Degree_Click(object sender, RoutedEventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDegree);
        }

        private void QuadricEquation_Click(object sender, RoutedEventArgs e)
        {
            QuadricEquation quadricEquation= new QuadricEquation();
            if (quadricEquation.ShowDialog() == true)
                MessageBox.Show("To start new equation solving, please press the Quadric Equation button.");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Delete.Visibility = Visibility.Visible;
            Factorial.Visibility = Visibility.Visible;
            Square.Visibility = Visibility.Visible;
            Cube.Visibility = Visibility.Visible;
            InverseValue.Visibility = Visibility.Visible;
            Degree.Visibility = Visibility.Visible;
            SqrRoot.Visibility = Visibility.Visible;
            CubeRoot.Visibility = Visibility.Visible;
            QuadricEquation.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Delete.Visibility = Visibility.Hidden;
            Factorial.Visibility = Visibility.Hidden;
            Square.Visibility = Visibility.Hidden;
            Cube.Visibility = Visibility.Hidden;
            InverseValue.Visibility = Visibility.Hidden;
            Degree.Visibility = Visibility.Hidden;
            SqrRoot.Visibility = Visibility.Hidden;
            CubeRoot.Visibility = Visibility.Hidden;
            QuadricEquation.Visibility = Visibility.Hidden;
        }
    }
}
