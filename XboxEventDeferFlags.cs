// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxEventDeferFlags
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

namespace XDevkit
{
  public enum XboxEventDeferFlags
  {
    CanDeferExecutionBreak = 1,
    CanDeferDebugString = 2,
    CanDeferSingleStep = 4,
    CanDeferAssertionFailed = 8,
    CanDeferAssertionFailedEx = 16, // 0x00000010
    CanDeferDataBreak = 32, // 0x00000020
    CanDeferRIP = 64, // 0x00000040
  }
}
