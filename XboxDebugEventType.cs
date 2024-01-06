// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxDebugEventType
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

namespace XDevkit
{
  public enum XboxDebugEventType
  {
    NoEvent,
    ExecutionBreak,
    DebugString,
    ExecStateChange,
    SingleStep,
    ModuleLoad,
    ModuleUnload,
    ThreadCreate,
    ThreadDestroy,
    Exception,
    AssertionFailed,
    AssertionFailedEx,
    DataBreak,
    RIP,
    SectionLoad,
    SectionUnload,
    StackTrace,
    FiberCreate,
    FiberDestroy,
    BugCheck,
    PgoModuleStartup,
  }
}
