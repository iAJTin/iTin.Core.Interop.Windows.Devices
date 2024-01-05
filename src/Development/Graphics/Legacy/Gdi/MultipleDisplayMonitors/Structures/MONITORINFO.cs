
using System;
using System.Runtime.InteropServices;

using iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

namespace iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors;

/// <summary>
/// The <strongs>MONITORINFO</strongs> structure contains information about a monitor.<br/>
/// The <strongs>MONITORINFO</strongs> structure is a subset of the <see cref="MONITORINFOEX"/> structure. The <see cref="MONITORINFOEX"/> structure adds a member that contains the name for the monitor.<br/>
/// For more information, please see http://msdn.microsoft.com/es-es/library/dd145065.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct MONITORINFO : IEquatable<MONITORINFO>
{
    #region public members

    /// <summary>
    /// Specifies the size, in bytes, of the <b>MONITORINFO</b> structure.
    /// Must be initialized before calling a <b>Api</b> function.
    /// </summary>
    public int Size;

    /// <summary>
    /// A structure <see cref="RECT"/> that specifies the rectangle of the total area of the monitor.
    /// </summary>
    public RECT Monitor;

    /// <summary>
    /// A structure <see cref="RECT"/> that specifies the rectangle of the working area of the useful monitor
    /// that can be used by applications, expressed in virtual screen coordinates.
    /// Windows uses this rectangle to maximize an application on the monitor.
    /// Toolbars, status bars, etc. are excluded.
    /// </summary>
    public RECT WorkArea;

    /// <summary>
    /// Attributes of the monitor.
    /// </summary>
    public uint Flags;

    #endregion

    #region interfaces

    /// <summary>
    /// Indicates whether the current object is the same as another object of the same type.
    /// </summary>
    /// <param name="other">Object to be compared with this object.</param>
    /// <returns>
    /// Returns <see langword="true"/> if the current object is equal to the <c>other</c> parameter; otherwise <see langword="false"/>.
    /// </returns>
    public bool Equals(MONITORINFO other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Implement the equality operator (==).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1.</param>
    /// <param name="deviceInfo2">Operand 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator ==(MONITORINFO deviceInfo1, MONITORINFO deviceInfo2) => deviceInfo1.Equals(deviceInfo2);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1.</param>
    /// <param name="deviceInfo2">Operand 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(MONITORINFO deviceInfo1, MONITORINFO deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);

    #endregion

    #region public static properties

    /// <summary>
    /// Create a new instance of this structure.
    /// </summary>
    /// <value>
    /// New instance of the structure.
    /// </value>
    public static MONITORINFO Create
    {
        get
        {
            var instance = new MONITORINFO();
            instance.Init();

            return instance;
        }
    }

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => WorkArea.GetHashCode() ^ (int)Flags;

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not MONITORINFO other)
        {
            return false;
        }

        return 
            other.WorkArea == WorkArea && 
            other.Monitor == Monitor && 
            other.Flags == Flags;
    }

    /// <inheritdoc/>
    public override string ToString() => WorkArea.ToString();

    #endregion

    #region private members

    /// <summary>
    /// Initialize the structure internally, call <strong>always</strong> before using in an API call.
    /// </summary>
    private void Init()
    {
        Size = Marshal.SizeOf(this);
    }

    #endregion    
}
