using System;
using System.Linq;
using System.Collections.Generic;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;
using System.Globalization;
using System.Resources;

namespace AlignTag.Model
{
  using MainWindow;
  [Transaction(TransactionMode.Manual)]
  class AlignTag : IExternalEventHandler
  {
    public string GetName() => nameof(AlignTag);
    public void Execute(UIApplication uiapp)
    {
      var mainWindowViewModel = new MainWindowViewModel(uiapp, new RevitEvent());
      MainView mainWindow = new MainView(mainWindowViewModel);
      mainWindow.Show();
    }
  }
}
