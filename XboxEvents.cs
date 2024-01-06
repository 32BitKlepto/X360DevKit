// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxEvents
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [TypeLibType(4096)]
  [Guid("420208DF-C38C-4EFB-9FC3-ACD50350941E")]
  [InterfaceType(2)]
  [ComImport]
  public interface XboxEvents
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnStdNotify([In] XboxDebugEventType EventCode, [MarshalAs(UnmanagedType.Interface), In] IXboxEventInfo EventInfo);

    [DispId(2)]
    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnTextNotify([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.BStr), In] string Notification);
  }
}
