// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxEvents_SinkHelper
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.InteropServices;

namespace XDevkit
{
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  public sealed class XboxEvents_SinkHelper : XboxEvents
  {
    public XboxEvents_OnStdNotifyEventHandler m_OnStdNotifyDelegate;
    public XboxEvents_OnTextNotifyEventHandler m_OnTextNotifyDelegate;
    public int m_dwCookie;

    public virtual void OnStdNotify([In] XboxDebugEventType obj0, [In] IXboxEventInfo obj1)
    {
      if (this.m_OnStdNotifyDelegate == null)
        return;
      this.m_OnStdNotifyDelegate(obj0, obj1);
    }

    public virtual void OnTextNotify([In] string obj0, [In] string obj1)
    {
      if (this.m_OnTextNotifyDelegate == null)
        return;
      this.m_OnTextNotifyDelegate(obj0, obj1);
    }

    internal XboxEvents_SinkHelper()
    {
      this.m_dwCookie = 0;
      this.m_OnStdNotifyDelegate = (XboxEvents_OnStdNotifyEventHandler) null;
      this.m_OnTextNotifyDelegate = (XboxEvents_OnTextNotifyEventHandler) null;
    }
  }
}
