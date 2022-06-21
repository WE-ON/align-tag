using System.Windows;
using System.Windows.Input;
using Autodesk.Revit.UI;

namespace AlignTag.MainWindow
{
  public partial class MainView : Window
  {
    MainWindowViewModel _mainWindowViewModel;
    public MainView(MainWindowViewModel mainWindowViewModel)
    {
        _mainWindowViewModel = mainWindowViewModel;
        InitializeComponent();
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
      if (e.ChangedButton == MouseButton.Left)
        this.DragMove();
    }
    private void ButtonClickExit(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

    private void alignLeftButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.AlignLeft();
    }
    private void alignRightButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.AlignRight();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Left);
    }
    private void alignTopButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.AlignTop();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Right);
    }
    private void alignBottomButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.AlignBottom();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Up);
    }
    private void alignCenterButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.AlignCenter();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Down);
    }
    private void alignMiddleButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.AlignMiddle();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Center);
    }
    private void distributeHorizontallyButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.DistributeHorizontally();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Middle);
    }
    private void distributeVerticallyButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.DistributeVertically();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Horizontally);
    }
    private void ArrangeButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.Arrange();
      //Align align = new Align();
      //align.AlignElements(uiapp, AlignType.Vertically);
    }
    private void UntangleVerticallyButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.UntangleVertically();
      //arrange.ArrangeElements(uiapp);
    }
    private void UntangleHorizontallyButton(object sender, RoutedEventArgs e)
    {
      _mainWindowViewModel.UntangleHorizontally();
      //arrange.ArrangeElements(uiapp);
    }
  }
}
