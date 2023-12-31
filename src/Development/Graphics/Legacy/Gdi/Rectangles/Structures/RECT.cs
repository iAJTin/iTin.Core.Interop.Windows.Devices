﻿
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Rectangles;

/// <summary>
/// The <b>RECT</b> structure defines the coordinates of the upper left and lower right corners of a rectangle.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct RECT : IEquatable<RECT>
{
    #region public members

    /// <summary>
    /// X coordinate of the upper left corner of the rectangle.
    /// </summary>
    public int Left;

    /// <summary>
    /// Y coordinate of the upper left corner of the rectangle.
    /// </summary>
    public int Top;

    /// <summary>
    /// X coordinate of the lower right corner of the rectangle.
    /// </summary>
    public int Right;

    /// <summary>
    /// Y coordinate of the lower right corner of the rectangle.
    /// </summary>
    public int Bottom;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="RECT"/> structure.
    /// </summary>
    /// <param name="left">X coordinate of the upper left corner of the rectangle.</param>
    /// <param name="top">Y coordinate of the upper left corner of the rectangle.</param>
    /// <param name="right">X coordinate of the lower right corner of the rectangle.</param>
    /// <param name="bottom">Y coordinate of the lower right corner of the rectangle.</param>
    public RECT(int left, int top, int right, int bottom)
    {
        Left = left;
        Top = top;
        Right = right;
        Bottom = bottom;
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
    public bool Equals(RECT other) => other.Equals((object)this);

    #endregion

    #region public operators

    #region implicit

    /// <summary>
    /// Perform an implicit conversion of type <see cref="RECT"/> to type <see cref="T:System.Drawing.Rectangle" />.
    /// </summary>
    /// <param name="rect">Structure to convert.</param>
    /// <returns>
    /// Converted structure.
    /// </returns>
    public static implicit operator Rectangle(RECT rect) => new(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);

    /// <summary>
    /// Perform an implicit conversion from type <see cref="T:System.Drawing.Rectangle"/> to type <see cref="RECT"/>.
    /// </summary>
    /// <param name="rect">Structure to convert.</param>
    /// <returns>
    /// Converted structure.
    /// </returns>
    public static implicit operator RECT(Rectangle rect) => new(rect.X, rect.Y, rect.Right - rect.Left, rect.Bottom - rect.Top);

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
    public static bool operator ==(RECT deviceInfo1, RECT deviceInfo2) => deviceInfo1.Equals(deviceInfo2);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1.</param>
    /// <param name="deviceInfo2">Operand 2.</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(RECT deviceInfo1, RECT deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);

    #endregion

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => Left ^ Top ^ Right ^ Bottom;

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not RECT other)
        {
            return false;
        }

        return 
            other.Left == Left && 
            other.Top == Top &&
            other.Right == Right && 
            other.Bottom == Bottom;
    }

    /// <inheritdoc/>
    public override string ToString() => $"Left = {Left}, Top = {Top}, Right = {Right}, Bottom = {Bottom}";

    #endregion
}
