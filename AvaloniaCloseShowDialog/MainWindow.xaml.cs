using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaCloseShowDialog
{
    public class MainWindow : Window
    {
        Button btnShow;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            btnShow = this.FindControl<Button>("btnShow");
            btnShow.Click += ShowDialog_Click;
        }

        private void ShowDialog_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Dialog dialog = new Dialog();
            dialog.ShowDialog();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
