// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxDumpFlags
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

namespace XDevkit
{
  public enum XboxDumpFlags
  {
    Normal = 0,
    WithDataSegs = 1,
    WithFullMemory = 2,
    WithHandleData = 4,
    FilterMemory = 8,
    ScanMemory = 16, // 0x00000010
    WithUnloadedModules = 32, // 0x00000020
    WithIndirectlyReferencedMemory = 64, // 0x00000040
    FilterModulePaths = 128, // 0x00000080
    WithProcessThreadData = 256, // 0x00000100
    WithPrivateReadWriteMemory = 512, // 0x00000200
  }
}
