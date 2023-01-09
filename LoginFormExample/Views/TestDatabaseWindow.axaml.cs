using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LoginFormExample.Views
{
    public partial class TestDatabaseWindow : Window
    {
        public TestDatabaseWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}