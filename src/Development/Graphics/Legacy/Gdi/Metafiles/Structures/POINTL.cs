
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Metafiles;

/// <summary>
/// The <strong>POINTL</strong> structure contains the coordinates of a point.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct POINTL : IEquatable<POINTL>
{
    #region public members

    /// <summary>
    /// X coordinate of the point.
    /// </summary>
    public int X;

    /// <summary>
    /// Y coordinate of the point.
    /// </summary>
    public int Y;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="POINTL"/> structure.
    /// </summary>
    /// <param name="x">X coordinate of the point.</param>
    /// <param name="y">Y coordinate of the point.</param>
    public POINTL(int x, int y)
    {
        X = x;
        Y = y;
    }

    #endregion

    #region interfaces

    /// <summary>
    /// Indicates whether the current object is the same as another object of the same type.
    /// </summary>
    /// <param name="other">Object to be compared with this object.</param>
    /// <returns>
    /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
    /// </returns>
    public bool Equals(POINTL other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Make an implicit conversion from type <see cref="POINTL"/> to type <see cref="T:System.Drawing.Point"/>.
    /// </summary>
    /// <param name="point">Structure to convert.</param>
    /// <returns>
    /// Converted structure.
    /// </returns>
    public static implicit operator Point(POINTL point) => new(point.X, point.Y);

    /// <summary>
    /// Perform an implicit conversion of type <see cref="T:System.Drawing.Point"/> to type <see cref="POINTL"/>.
    /// </summary>
    /// <param name="point">Structure to convert.</param>
    /// <returns>
    /// Converted structure.
    /// </returns>
    public static implicit operator POINTL(Point point) => new(point.X, point.Y);

    /// <summary>
    /// Implement the equality operator (==).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1.</param>
    /// <param name="deviceInfo2">Operand 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator ==(POINTL deviceInfo1, POINTL deviceInfo2) => deviceInfo1.Equals(deviceInfo2);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1.</param>
    /// <param name="deviceInfo2">Operand 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(POINTL deviceInfo1, POINTL deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);

    #endregion

    #region public overrides methods

    /// <inheritdoc/>
    public override int GetHashCode() => X ^ Y;

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not POINTL other)
        {
            return false;
        }

        return other.X == X && other.Y == Y;
    }

    /// <inheritdoc/>
    public override string ToString() => $"X = {X}, Y = {Y}";

    #endregion
}
