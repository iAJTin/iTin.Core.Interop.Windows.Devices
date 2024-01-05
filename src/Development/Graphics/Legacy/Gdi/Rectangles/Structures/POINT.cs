
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

/// <summary>
/// The <strong>POINT</strong> structure contains the coordinates of a point.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct POINT : IEquatable<POINT>
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
    /// Initializes a new instance of the <see cref="POINT"/> structure.
    /// </summary>
    /// <param name="x">X coordinate of the point.</param>
    /// <param name="y">y coordinate of the point.</param>
    public POINT(int x, int y)
    {
        X = x;
        Y = y;
    }

    #endregion

    #region interfaces

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">Object to be compared with this object.</param>
    /// <returns>
    /// Returns <see langword="true"/> if the current object is equal to the <c>other</c> parameter; otherwise <see langword="false"/>.
    /// </returns>
    public bool Equals(POINT other) => other.Equals((object)this);

    #endregion

    #region public operators

    #region implicit

    /// <summary>
    /// Perform an implicit conversion from type <see cref="POINT"/> to type <see cref="T:System.Drawing.Point"/>.
    /// </summary>
    /// <param name = "point"> Structure to convert. </param>
    /// <returns>
    /// Converted structure.
    /// </returns>
    public static implicit operator Point(POINT point) => new(point.X, point.Y);

    /// <summary>
    /// Perform an implicit conversion of type <see cref="T:System.Drawing.Point"/> to type <see cref="POINT"/>.
    /// </summary>
    /// <param name="point">Structure to convert.</param>
    /// <returns>
    /// Converted structure.
    /// </returns>
    public static implicit operator POINT(Point point) => new(point.X, point.Y);

    #endregion

    #region comparison

    /// <summary>
    /// Implement the equality operator (==).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1.</param>
    /// <param name="deviceInfo2">Operand 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator ==(POINT deviceInfo1, POINT deviceInfo2) => deviceInfo1.Equals(deviceInfo2);

    /// <summary>
    /// Implement the inequality operator (!=).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1.</param>
    /// <param name="deviceInfo2">Operand 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(POINT deviceInfo1, POINT deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);

    #endregion

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => X ^ Y;

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not POINT other)
        {
            return false;
        }

        return
            other.X == X && 
            other.Y == Y;
    }

    /// <inheritdoc/>
    public override string ToString() => $"X = {X}, Y = {Y}";

    #endregion
}
