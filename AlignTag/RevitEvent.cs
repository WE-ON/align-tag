﻿using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlignTag
{
  public class RevitEvent : IExternalEventHandler
  {
    private Action<UIApplication> _action;
    private readonly ExternalEvent _externalEvent;
    public RevitEvent()
    {
      _externalEvent = ExternalEvent.Create(this);
    }
    public void Run(Action<UIApplication> action)
    {
      _action = action;
      _externalEvent.Raise();
    }
    public void Execute(UIApplication app)
    {
      try
      {
        _action?.Invoke(app);
      }
      catch (Exception ex)
      {
        var message = ex.Message;
        var td = new TaskDialog("AlignTag Exception");
        td.MainInstruction = message;
        td.Show();
      }
    }
    public string GetName() => nameof(RevitEvent);
  }
}
