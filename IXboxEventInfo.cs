// Decompiled with JetBrains decompiler
// Type: XDevkit.IXboxEventInfo
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [TypeLibType(4160)]
  [DefaultMember("Info")]
  [Guid("85C9127A-11ED-47F2-9E87-A83058FC264A")]
  [ComImport]
  public interface IXboxEventInfo
  {
    [DispId(0)]
    XBOX_EVENT_INFO Info { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
