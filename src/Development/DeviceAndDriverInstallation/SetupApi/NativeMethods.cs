
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace iTin.Core.Interop.Shared.Windows.Development.DeviceAndDriverInstallation.SetupApi;

/// <summary>
/// Functions to develop Device and Driver Installation Reference.
/// </summary>
public static class NativeMethods
{
    /// <summary>
    /// Retrieves the class name associated with a class GUID. The function must be called repeatedly until the CR_NO_SUCH_VALUE value is returned.
    /// </summary>
    /// <remarks>
    /// For more information, please see http://msdn.microsoft.com/en-us/library/ff538021%28v=VS.85%29.aspx.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetupDiClassNameFromGuid(ref Guid classGuid, StringBuilder className, uint classNameSize, ref uint requiredSize);

    /// <summary>
    /// Deletes a set of information from the device and frees all associated memory.
    /// </summary>
    /// <remarks>
    /// For more information, please see http://msdn.microsoft.com/en-us/library/ff550996%28v=VS.85%29.aspx.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetupDiDestroyDeviceInfoList(IntPtr deviceInfoSet);

    /// <summary>
    /// Returns a <see cref="SP_DEVINFO_DATA"/> structure that specifies a device information element in a device information set.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/es-es/windows/win32/api/setupapi/nf-setupapi-setupdienumdeviceinfo
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    public static extern bool SetupDiEnumDeviceInfo(IntPtr hdevinfo, uint memberIndex, ref SP_DEVINFO_DATA deviceInfoData);

    /// <summary>
    /// Returns a handle to a device information set that contains requested device information elements for a local computer.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetclassdevsw.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    public static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, uint enumerator, IntPtr hwndParent, uint flags);

    /// <summary>
    /// Devuelve un identificador para un conjunto de información de dispositivo que contiene los elementos solicitados la información del dispositivo para un equipo local.
    /// Para más información, ver http://msdn.microsoft.com/en-us/library/ff551069%28VS.85%29.aspx.
    /// </summary>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    public static extern IntPtr SetupDiGetClassDevs(ref Guid classGuid, uint enumerator, IntPtr hwndParent, DiGetClassFlags flags);

    /// <summary>
    /// Returns a handle to a device information set that contains requested device information elements for a local or a remote computer.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetclassdevsexa
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr SetupDiGetClassDevsEx(ref Guid guidClass, uint enumerator, IntPtr hwndParent, DiGetClassFlags flags, IntPtr deviceInfoSet, [MarshalAs(UnmanagedType.LPWStr)] string machineName, IntPtr reserved);

    /// <summary>
    /// Returns a handle to a device information set that contains requested device information elements for a local or a remote computer.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetclassdevsexa.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true, CharSet = CharSet.Unicode)]
    public static extern IntPtr SetupDiGetClassDevsEx(ref Guid guidClass, [MarshalAs(UnmanagedType.LPWStr)] string enumerator, IntPtr hwndParent, DiGetClassFlags flags, IntPtr deviceInfoSet, [MarshalAs(UnmanagedType.LPWStr)] string machineName, IntPtr reserved);

    /// <summary>
    /// Retrieves the device instance ID that is associated with a device information element.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetdeviceinstanceida.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool SetupDiGetDeviceInstanceId(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, char[] deviceInstanceId, uint deviceInstanceIdSize, IntPtr requiredSize);

    /// <summary>
    /// Retrieves a specified Plug and Play device property.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetdeviceregistrypropertya
    /// </remarks>
    [DllImport(ExternDll.SetupApi, CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, DiGetDeviceRegistryProperty property, out uint propertyRegDataType, byte[] propertyBuffer, uint propertyBufferSize, out uint requiredSize);

    /// <summary>
    /// Open the device configuration from the registry, the device interface or subkey a specific class.
    /// This function opens the key specified on the local computer or on a remote computer.
    /// </summary>
    /// <remarks>
    /// For more information, please see http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid, uint samDesired, DiOpenClassFlags flags, IntPtr machineName, uint reserved);

    /// <summary>
    /// Open the device configuration from the registry, the device interface or subkey a specific class.
    /// This function opens the key specified on the local computer or on a remote computer.
    /// </summary>
    /// <remarks>
    /// For more information, please see http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid, uint samDesired, DiOpenClassFlags flags, IntPtr machineName, IntPtr reserved);

    /// <summary>
    /// Open the device configuration from the registry, the device interface or subkey a specific class.
    /// This function opens the key specified on the local computer or on a remote computer.
    /// </summary>
    /// <remarks>
    /// For more information, please see http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid, uint samDesired, DiOpenClassFlags flags, StringBuilder machineName, uint reserved);

    /// <summary>
    /// Open the device configuration from the registry, the device interface or subkey a specific class.
    /// This function opens the key specified on the local computer or on a remote computer.
    /// </summary>
    /// <remarks>
    /// For more information, please see http://msdn.microsoft.com/en-us/library/ff552067%28VS.85%29.aspx.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, SetLastError = true)]
    public static extern IntPtr SetupDiOpenClassRegKeyEx(ref Guid guid, uint samDesired, DiOpenClassFlags flags, StringBuilder machineName, IntPtr reserved);

    /// <summary>
    /// Open a registration key for device specific configuration information.
    /// </summary>
    /// <remarks>
    /// For more information, please see https://docs.microsoft.com/en-us/windows/win32/api/setupapi/nf-setupapi-setupdigetdeviceregistrypropertya.
    /// </remarks>
    [DllImport(ExternDll.SetupApi, CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr SetupDiOpenDevRegKey(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, uint scope, uint hwProfile, uint keyType, uint samDesired);
}
