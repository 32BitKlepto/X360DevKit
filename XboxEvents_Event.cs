// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxEvents_Event
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [ComEventInterface(typeof (XboxEvents), typeof (XboxEvents_EventProvider))]
  [TypeLibType(16)]
  [ComVisible(false)]
  public interface XboxEvents_Event
  {
    event XboxEvents_OnStdNotifyEventHandler OnStdNotify;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnStdNotify([In] XboxEvents_OnStdNotifyEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnStdNotify([In] XboxEvents_OnStdNotifyEventHandler obj0);

    event XboxEvents_OnTextNotifyEventHandler OnTextNotify;

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_OnTextNotify([In] XboxEvents_OnTextNotifyEventHandler obj0);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_OnTextNotify([In] XboxEvents_OnTextNotifyEventHandler obj0);
  }
}
