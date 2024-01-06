// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxEvents_OnTextNotifyEventHandler
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.InteropServices;

namespace XDevkit
{
  [TypeLibType(16)]
  [ComVisible(false)]
  public delegate void XboxEvents_OnTextNotifyEventHandler([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.BStr), In] string Notification);
}
