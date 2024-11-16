using System;
using System.Windows;

namespace BMICalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBMI_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get height and weight input
                double height = double.Parse(HeightTextBox.Text);
                double weight = double.Parse(WeightTextBox.Text);

                // Validate height and weight
                if (height <= 0 || weight <= 0)
                {
                    MessageBox.Show("Please enter positive values for height and weight.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Calculate BMI
                double bmi = weight / (height * height);

                // Display BMI result
                BMITextBox.Text = bmi.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for height and weight.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
