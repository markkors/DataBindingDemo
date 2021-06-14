using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DataBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 

    {
    
        private DataBindingDemo.Viewmodels.MainViewModel _VM = new Viewmodels.MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _VM;

            // binding the controls
            btnAddJan.Click += BtnAddJan_Click;
        }
        
        private void BtnAddJan_Click(object sender, RoutedEventArgs e)
        {
            _VM.Persons.Add(new Models.cPerson("a", "b"));
        }
    }
}
