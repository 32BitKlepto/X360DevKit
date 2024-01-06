// Decompiled with JetBrains decompiler
// Type: XDevkit.IXboxExecutable
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [Guid("4B103593-DB52-4E18-913D-B3B17824BD76")]
  [TypeLibType(4288)]
  [ComImport]
  public interface IXboxExecutable
  {
    [DispId(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.BStr)]
    string GetPEModuleName();
  }
}
