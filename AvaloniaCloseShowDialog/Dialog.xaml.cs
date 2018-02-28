using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaCloseShowDialog
{
    public class Dialog : Window
    {
        Button btnClose;

        public Dialog()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            btnClose = this.FindControl<Button>("btnClose");
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Close();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
