namespace SelectAllSample
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnSelectAllExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Source is ListBox listBox)
            {
                listBox.SelectAll();
            }
        }
    }
}
