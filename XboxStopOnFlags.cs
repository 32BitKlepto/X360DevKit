// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxStopOnFlags
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

namespace XDevkit
{
  public enum XboxStopOnFlags
  {
    OnThreadCreate = 1,
    OnFirstChanceException = 2,
    OnDebugString = 4,
    OnStackTrace = 8,
    OnModuleLoad = 16, // 0x00000010
    OnTitleLaunch = 32, // 0x00000020
    OnPgoModuleStartup = 64, // 0x00000040
  }
}
