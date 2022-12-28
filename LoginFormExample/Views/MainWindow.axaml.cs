using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;

namespace LoginFormExample.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private static async Task<string> Authenticate()
    {
        string status = "";
        //check credentials
        
        //get token
        
        //validate token
        status = "success";
        //test code
        
        // Do some work
        return status;
    }
    
    private async void Button_OnClick(object sender, RoutedEventArgs e)
    {
        // Start the job and return immediately
        var result = await Dispatcher.UIThread.InvokeAsync(Authenticate, DispatcherPriority.Background);
    }

}