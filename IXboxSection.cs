// Decompiled with JetBrains decompiler
// Type: XDevkit.IXboxSection
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [Guid("D6DF8112-0326-4D29-A6B8-CFB0D89C358A")]
  [TypeLibType(4160)]
  [ComImport]
  public interface IXboxSection
  {
    [DispId(100)]
    XBOX_SECTION_INFO SectionInfo { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
