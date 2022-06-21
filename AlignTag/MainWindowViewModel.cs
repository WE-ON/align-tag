using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace AlignTag
{
  public class MainWindowViewModel
  {
    private UIApplication _uiapp;
    private RevitEvent _revitEvent;
    public MainWindowViewModel(UIApplication uiapp, RevitEvent revitEvent)
    {
      _uiapp = uiapp;
      _revitEvent = revitEvent;
    }

    public void AlignLeft()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Left));
    }

    public void AlignRight()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Right));
    }

    public void AlignTop()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Up));
    }

    public void AlignBottom()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Down));
    }


    public void AlignCenter()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Center));
    }

    public void AlignMiddle()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Middle));
    }

    public void DistributeHorizontally()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Horizontally));
    }


    public void DistributeVertically()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.Vertically));
    }


    public void UntangleVertically()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.UntangleVertically));
    }

    public void UntangleHorizontally()
    {
      Align align = new Align();
      _revitEvent.Run(app => align.AlignElements(_uiapp, AlignType.UntangleHorizontally));
    }

    public void Arrange()
    {
      Arrange arrange = new Arrange();
      _revitEvent.Run(app => arrange.ArrangeElements(_uiapp));
    }
  }
}
