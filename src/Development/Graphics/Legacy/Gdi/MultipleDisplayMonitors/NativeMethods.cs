﻿
using System;
using System.Runtime.InteropServices;

using iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

namespace iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors;

/// <summary>
/// Functions that can be used to control the configuration of system parameters and various system attributes, such as double click time, the screen saver timeout, the width of the window border.
/// </summary>
public static class NativeMethods
{
    #region public enumerations

    /// <summary>
    /// Determine the value returned by the function if the point is not within any system monitor.<br/>
    /// For more information, please see section <b>dwFlags</b> of http://msdn.microsoft.com/es-es/library/dd145062.
    /// </summary>
    public enum MonitorOptions : uint
    {
        /// <summary>
        /// 
        /// </summary>
        MONITOR_DEFAULTTONULL = 0x00000000,

        /// <summary>
        /// 
        /// </summary>
        MONITOR_DEFAULTTOPRIMARY = 0x00000001,

        /// <summary>
        /// 
        /// </summary>
        MONITOR_DEFAULTTONEAREST = 0x00000002
    }

    #endregion

    #region public delegates

    /// <summary>
    /// Callback of the <see cref="EnumDisplayMonitors"/> function.
    /// </summary>
    public delegate bool MonitorEnumCallBack(IntPtr hMonitor, IntPtr hdcMonitor, ref RECT lprcMonitor, IntPtr dwData);

    #endregion

    #region P/Invoke

    /// <summary>
    /// List the monitors (including invisible pseudo-monitors). Call a callback function (MonitorEnumCallBack).<br/>
    /// For more information, see http://msdn.microsoft.com/en-us/library/dd162610%28v=VS.85%29.aspx
    /// </summary>
    [DllImport(ExternDll.User32, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MonitorEnumCallBack lpfnEnum, IntPtr dwData);

    /// <summary>
    /// Get information from a monitor. For more information, please see http://msdn.microsoft.com/es-es/library/dd144901.
    /// </summary>
    [return: MarshalAs(UnmanagedType.Bool)]
    [DllImport(ExternDll.User32, CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFO lpmi);

    /// <summary>
    /// Get information from a monitor. For more information, please see http://msdn.microsoft.com/es-es/library/dd144901.
    /// </summary>
    [DllImport(ExternDll.User32, CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFOEX lpmi);

    /// <summary>
    /// Get the monitor ID that contains the specified point. For more information, please see http://msdn.microsoft.com/es-es/library/dd145062.
    /// </summary>
    [DllImport(ExternDll.User32, SetLastError = true)]
    public static extern IntPtr MonitorFromPoint(POINT pt, MonitorOptions dwFlags);

    /// <summary>
    /// Get the identifier of the monitor that has the largest area of intersection with the specified rectangle. For more information, please see http://msdn.microsoft.com/es-es/library/dd145062.
    /// </summary>
    [DllImport(ExternDll.User32, SetLastError = true)]
    public static extern IntPtr MonitorFromRect([In]ref RECT lprc, [In]MonitorOptions dwFlags);

    /// <summary>
    /// Get the identifier of the monitor that has the largest area of intersection with the rectangle of the specified window.
    /// For more information, please see http://msdn.microsoft.com/es-es/library/dd145064.
    /// </summary>
    [DllImport(ExternDll.User32, SetLastError = true)]
    public static extern IntPtr MonitorFromWindow([In]IntPtr hwnd, [In]MonitorOptions dwFlags);

    #endregion
}
