// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxDumpReportFlags
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

namespace XDevkit
{
  public enum XboxDumpReportFlags
  {
    FormatFullHeap = 0,
    LocalDestination = 0,
    PromptToReport = 0,
    AlwaysReport = 1,
    NeverReport = 2,
    DestinationGroup = 15, // 0x0000000F
    ReportGroup = 15, // 0x0000000F
    RemoteDestination = 16, // 0x00000010
    FormatPartialHeap = 256, // 0x00000100
    FormatNoHeap = 512, // 0x00000200
    FormatRetail = 1024, // 0x00000400
    FormatGroup = 3840, // 0x00000F00
  }
}
