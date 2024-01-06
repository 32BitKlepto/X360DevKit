// Decompiled with JetBrains decompiler
// Type: XDevkit.XBOX_EVENT_INFO
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.InteropServices;

namespace XDevkit
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct XBOX_EVENT_INFO
  {
    public XboxDebugEventType Event;
    public short IsThreadStopped;
    [MarshalAs(UnmanagedType.Interface)]
    public IXboxThread Thread;
    [MarshalAs(UnmanagedType.Interface)]
    public IXboxModule Module;
    [MarshalAs(UnmanagedType.Interface)]
    public IXboxSection Section;
    public XboxExecutionState ExecState;
    [MarshalAs(UnmanagedType.BStr)]
    public string Message;
    public uint Code;
    public uint Address;
    public XboxExceptionFlags Flags;
    public uint ParameterCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = (UnmanagedType) 0)]
    public uint[] Parameters;
  }
}
