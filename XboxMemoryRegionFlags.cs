// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxMemoryRegionFlags
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

namespace XDevkit
{
  public enum XboxMemoryRegionFlags
  {
    NoAccess = 1,
    ReadOnly = 2,
    ReadWrite = 4,
    WriteCopy = 8,
    Execute = 16, // 0x00000010
    ExecuteRead = 32, // 0x00000020
    ExecuteReadWrite = 64, // 0x00000040
    ExecuteWriteCopy = 128, // 0x00000080
    Guard = 256, // 0x00000100
    NoCache = 512, // 0x00000200
    WriteCombine = 1024, // 0x00000400
    UserReadOnly = 4096, // 0x00001000
    UserReadWrite = 8192, // 0x00002000
  }
}
