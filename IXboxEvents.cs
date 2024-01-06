// Decompiled with JetBrains decompiler
// Type: XDevkit.IXboxEvents
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [TypeLibType(256)]
  [Guid("E3C9D73F-9DF0-4B57-8CEE-05F9CA6823BE")]
  [InterfaceType(1)]
  [ComImport]
  public interface IXboxEvents
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnStdNotify([In] XboxDebugEventType EventCode, [MarshalAs(UnmanagedType.Interface), In] IXboxEventInfo EventInfo);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnTextNotify([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.BStr), In] string Notification);
  }
}
