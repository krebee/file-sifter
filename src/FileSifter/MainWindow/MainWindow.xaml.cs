using FileSifter.Presentation.Main;
using System.Windows;
<<<<<<<< HEAD:src/FileSifter/Presentation/Main/MainWindow.xaml.cs
namespace FileSifter.Presentation;
========

namespace FileSifter.MainWindow;
>>>>>>>> レイヤード構成への全面リファクタリング:src/FileSifter/MainWindow/MainWindow.xaml.cs

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}