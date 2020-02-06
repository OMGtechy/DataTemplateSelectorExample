using DataTemplateSelectorExample.ViewModels;
using System;
using System.Windows;

namespace DataTemplateSelectorExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var viewModel = new MainWindowViewModel();

            // Set up some unpredictable data to help show how a DataTemplate and DataTemplateSelector might be useful
            var rng = new Random();
            for (int i = 0; i < 42; ++i)
            {
                viewModel.TestData.Add(rng.Next(2) == 0 ? $"I am a string! {i}" : (object)new int?(i));
            }

            DataContext = viewModel;
        }
    }
}
