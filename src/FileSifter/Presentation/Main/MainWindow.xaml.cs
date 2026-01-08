using FileSifter.Presentation.Main;
using System.Windows;
namespace FileSifter.Presentation;


namespace FileSifter.MainWindow;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
