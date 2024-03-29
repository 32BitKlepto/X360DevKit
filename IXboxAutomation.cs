﻿// Decompiled with JetBrains decompiler
// Type: XDevkit.IXboxAutomation
// Assembly: XDevkit, Version=2.0.21076.0, Culture=neutral, PublicKeyToken=null
// MVID: 69081036-3741-48A7-A926-4BDD03F049B2
// Assembly location: C:\Users\19189\Desktop\Project Revive\Libraries\X360DevKit.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace XDevkit
{
  [TypeLibType(4288)]
  [Guid("D81F3E2E-8304-4024-8997-BB1C893516B0")]
  [ComImport]
  public interface IXboxAutomation
  {
    [DispId(100)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetInputProcess([In] uint UserIndex, out bool SystemProcess);

    [DispId(101)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void BindController([In] uint UserIndex, [In] uint QueueLength);

    [DispId(102)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void UnbindController([In] uint UserIndex);

    [DispId(103)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ConnectController([In] uint UserIndex);

    [DispId(104)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DisconnectController([In] uint UserIndex);

    [DispId(105)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetGamepadState([In] uint UserIndex, [In] ref XBOX_AUTOMATION_GAMEPAD Gamepad);

    [DispId(106)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void QueueGamepadState_cpp(
      [In] uint UserIndex,
      [In] ref XBOX_AUTOMATION_GAMEPAD GamepadArray,
      [In] ref uint TimedDurationArray,
      [In] ref uint CountDurationArray,
      [In] uint ItemCount,
      out uint ItemsAddedToQueue);

    [DispId(107)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool QueueGamepadState(
      [In] uint UserIndex,
      [In] ref XBOX_AUTOMATION_GAMEPAD Gamepad,
      [In] uint TimedDuration,
      [In] uint CountDuration);

    [DispId(108)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearGamepadQueue([In] uint UserIndex);

    [DispId(109)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void QueryGamepadQueue(
      [In] uint UserIndex,
      out uint QueueLength,
      out uint ItemsInQueue,
      out uint TimedDurationRemaining,
      out uint CountDurationRemaining);

    [DispId(110)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetUserDefaultProfile(out long Xuid);

    [DispId(111)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetUserDefaultProfile([In] long Xuid);
  }
}
