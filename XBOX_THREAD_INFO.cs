// Decompiled with JetBrains decompiler
// Type: XDevkit.XBOX_THREAD_INFO
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.InteropServices;

namespace XDevkit
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct XBOX_THREAD_INFO
  {
    public uint ThreadId;
    public uint SuspendCount;
    public uint Priority;
    public uint TlsBase;
    public uint StartAddress;
    public uint StackBase;
    public uint StackLimit;
    public uint StackSlackSpace;
    [MarshalAs(UnmanagedType.Struct)]
    public object CreateTime;
    [MarshalAs(UnmanagedType.BStr)]
    public string Name;
  }
}
