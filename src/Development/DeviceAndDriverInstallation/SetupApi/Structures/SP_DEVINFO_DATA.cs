
using System;
using System.Runtime.InteropServices;

namespace iTin.Core.Interop.Shared.Windows.Development.DeviceAndDriverInstallation.SetupApi;

/// <summary>
/// Defines a device instance that is a member of a device information set.
/// </summary>
/// <remarks>
/// For more information, please see https://docs.microsoft.com/es-es/windows/win32/api/setupapi/ns-setupapi-sp_devinfo_data
/// </remarks>
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct SP_DEVINFO_DATA : IEquatable<SP_DEVINFO_DATA>
{
    #region interface/s

    /// <summary>
    /// Indicates whether the current object is the same as another object of the same type.
    /// </summary>
    /// <param name="other">Object to be compared with this object.</param>
    /// <returns>
    /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
    /// </returns>
    public bool Equals(SP_DEVINFO_DATA other)
    {
        return other.Equals((object)this);
    }

    #endregion

    #region public static properties

    /// <summary>
    /// Nueva estructura vacía.
    /// </summary>
    public static readonly SP_DEVINFO_DATA Empty = new() { cbSize = (uint)Marshal.SizeOf(typeof(SP_DEVINFO_DATA)) };

    #endregion

    #region public members

    ///<summary>
    /// The size, in bytes, of the <see cref="SP_DEVINFO_DATA"/> structure.
    ///</summary>
    public uint cbSize;

    ///<summary>
    /// The GUID of the device's setup class.
    ///</summary>
    public Guid classGuid;

    ///<summary>
    /// An opaque handle to the device instance.
    ///</summary>
    public uint devInst;

    ///<summary>
    /// An opaque handle to the device instance.
    ///</summary>
    public IntPtr reserved;

    #endregion

    #region public operators

    /// <summary>
    /// Implement the equality operator (==).
    /// </summary>
    /// <param name="left">Operand 1.</param>
    /// <param name="right">Operand 2.</param>
    /// <returns>
    /// Returns <b>true</b> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
    /// </returns>
    public static bool operator ==(SP_DEVINFO_DATA left, SP_DEVINFO_DATA right) => left.Equals(right);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="left">Operand 1.</param>
    /// <param name="right">Operand 2.</param>
    /// <returns>
    /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
    /// </returns>
    public static bool operator !=(SP_DEVINFO_DATA left, SP_DEVINFO_DATA right) => left.Equals(right);

    #endregion

    #region public override methods

    /// <summary>
    /// Returns the hash code of the structure.
    /// </summary>
    /// <returns>
    /// Hash code.
    /// </returns>
    public override int GetHashCode() => cbSize.GetHashCode() ^ classGuid.GetHashCode() ^ devInst.GetHashCode() ^ reserved.GetHashCode();

    /// <summary>
    /// Returns a value that indicates whether this object is equal to another.
    /// </summary>
    /// <param name="obj">Object to compare.</param>
    /// <returns>
    /// Equality result.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (obj is not SP_DEVINFO_DATA other)
        {
            return false;
        }

        return
            other.cbSize == cbSize &&
            other.devInst == devInst &&
            other.classGuid == classGuid &&
            other.reserved == reserved;
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>
    /// Returns a string that represents the current object.
    /// </returns>
    public override string ToString() => $"ClassGuid = {classGuid}";        

    #endregion
}
