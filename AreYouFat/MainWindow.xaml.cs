using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AreYouFat;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Calculate_Click(object sender, RoutedEventArgs e)
    {
        // Retrieve the values from the text boxes
        string ageText = AgeTextBox.Text;
        string heightText = HeightTextBox.Text;
        string weightText = WeightTextBox.Text;

        // Convert the values to the appropriate data types
        int age = int.Parse(ageText);
        double height = double.Parse(heightText) / 100; // Convert height from cm to m
        double weight = double.Parse(weightText);

        // Calculate the BMI
        double bmi = weight / (height * height);
        
        if (bmi < 18.5)
        {
            MessageBox.Show("You are underweight. Go eat something will ya?", "BMI Calculator", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            MessageBox.Show("You are normal weight. Nothing special.", "BMI Calculator", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else if (bmi >= 25 && bmi < 30)
        {
            MessageBox.Show("You are fat. Sorry...", "BMI Calculator", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("You are obese. Next time eat a salad. Just kidding (it won't help)", "BMI Calculator", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
    
    private void About(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("This application was created by Joe Mama.", "About", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}

