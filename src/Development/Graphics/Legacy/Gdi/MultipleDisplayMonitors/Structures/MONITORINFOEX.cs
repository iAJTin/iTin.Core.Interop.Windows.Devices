
using System;
using System.Runtime.InteropServices;

using iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

namespace iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors;

/// <summary>
/// The <strongs>MONITORINFOEX</strongs> structure contains information about a monitor.<br/>
/// The <strongs>MONITORINFOEX</strongs> structure is a superset of the <see cref="MONITORINFO"/> structure.<br/>
/// For more information, see http://msdn.microsoft.com/es-es/library/dd145066.
/// </summary>
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
public struct MONITORINFOEX : IEquatable<MONITORINFOEX>
{
    #region public constants

    /// <summary>
    /// MONITORINFOF_PRIMARY
    /// </summary>
    public const uint MONITORINFOF_PRIMARY = 0x00000001;

    #endregion

    #region private constants

    private const int CCHDEVICENAME = 0x20;

    #endregion

    #region public members

    /// <summary>
    /// Specifies the size, in bytes, of the <b>MONITORINFOEX</b> structure.
    /// Must be initialized before calling a <b>Api</b> function.
    /// </summary>
    public int Size;

    /// <summary>
    /// A structure <see cref="RECT"/> that specifies the rectangle of the total area of the monitor.
    /// </summary>
    public RECT Monitor;

    /// <summary>
    /// A structure <see cref="RECT"/> that specifies the rectangle of the working area of the useful monitor that can be used by applications, expressed in virtual screen coordinates.
    /// Windows uses this rectangle to maximize an application on the monitor.
    /// Toolbars, status bars, etc. are excluded.
    /// </summary>
    public RECT WorkArea;

    /// <summary>
    /// Attributes of the monitor.
    /// </summary>
    public uint Flags;

    /// <summary>
    /// A string that specifies the name of the monitor.
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
    public string DeviceName;

    #endregion

    #region interfaces

    /// <summary>
    /// Indicates whether the current structure is the same as another structure of the same type.
    /// </summary>
    /// <param name="other"> Structure to be compared with this structure.</param>
    /// <returns>
    /// Returns <see langword="true"/> if the current structure is equal to the <c>other</c> parameter; otherwise <see langword="false"/>.
    /// </returns>
    public bool Equals(MONITORINFOEX other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Implement the equality operator (==).
    /// </summary>
    /// <param name="operator1">Operating 1.</param>
    /// <param name="operator2">Operating 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>operator1</c> is equal to <c>operator2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator ==(MONITORINFOEX operator1, MONITORINFOEX operator2) => operator1.Equals(operator2);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name = "operator1">Operating 1.</param>
    /// <param name = "operator2">Operating 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>operator1</c> is not equal to <c>operator2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(MONITORINFOEX operator1, MONITORINFOEX operator2) => !operator1.Equals(operator2);

    #endregion

    #region public static properties

    /// <summary>
    /// 
    /// </summary>
    public static readonly MONITORINFOEX Empty = new() { Size = Marshal.SizeOf(typeof(MONITORINFOEX)) };

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => ToString().GetHashCode();

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not MONITORINFOEX other)
        {
            return false;
        }

        return
            other.Monitor == Monitor &&
            other.WorkArea == WorkArea &&
            other.Flags == Flags &&
            other.DeviceName == DeviceName;
    }

    /// <inheritdoc/>
    public override string ToString() => $"DeviceName = \"{DeviceName}\"";

    #endregion
}
