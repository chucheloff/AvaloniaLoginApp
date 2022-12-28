using System;
using System.ComponentModel.DataAnnotations;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using LoginFormExample.Views;
using ReactiveUI;

namespace LoginFormExample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Huiting => "How in the hell do you think this bullsht works";
    public string StackPanelData => "this is some content okay";

    public double DesiredWindowHeight => 0;
    public double MinInputFieldWidth => 200;

    public void ApplyWithCredentialsCommand()
    {
        var textBox = new TextBox();
        Console.WriteLine("This bullshit actually works");
    }

    private string? _UserPassword;
    [Required]
    public string? UserPassword
    {
        get
        {
            return _UserPassword;
        }
        set
        {
            this.RaiseAndSetIfChanged(ref _UserPassword, value);
        }
    }
    
    private string? _UserLogin;
    [Required]
    public string? UserLogin
    {
        get
        {
            return _UserLogin;
        }
        set
        {
            this.RaiseAndSetIfChanged(ref _UserLogin, value);
        }
    }
}