﻿// Decompiled with JetBrains decompiler
// Type: XDevkit.XBOX_PROCESS_INFO
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.InteropServices;

namespace XDevkit
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct XBOX_PROCESS_INFO
  {
    public uint ProcessId;
    [MarshalAs(UnmanagedType.BStr)]
    public string ProgramName;
  }
}
