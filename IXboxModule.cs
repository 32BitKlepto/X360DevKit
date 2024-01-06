// Decompiled with JetBrains decompiler
// Type: XDevkit.IXboxModule
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [Guid("0EEE2AA0-60F0-4C18-B4ED-E3933E659847")]
  [DefaultMember("ModuleInfo")]
  [TypeLibType(4288)]
  [ComImport]
  public interface IXboxModule
  {
    [DispId(0)]
    XBOX_MODULE_INFO ModuleInfo { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1)]
    IXboxSections Sections { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(2)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetFunctionInfo([In] uint Address, out XBOX_FUNCTION_INFO FunctionInfo);

    [DispId(3)]
    uint OriginalSize { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(4)]
    IXboxExecutable Executable { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(5)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    uint GetEntryPointAddress();
  }
}
