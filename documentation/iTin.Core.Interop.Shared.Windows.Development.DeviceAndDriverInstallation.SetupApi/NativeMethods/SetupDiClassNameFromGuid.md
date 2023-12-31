# NativeMethods.SetupDiClassNameFromGuid method

Retrieves the class name associated with a class GUID. The function must be called repeatedly until the CR_NO_SUCH_VALUE value is returned.

```csharp
public static bool SetupDiClassNameFromGuid(ref Guid classGuid, StringBuilder className, 
    uint classNameSize, ref uint requiredSize)
```

## Remarks

For more information, please see http://msdn.microsoft.com/en-us/library/ff538021%28v=VS.85%29.aspx.

## See Also

* class [NativeMethods](../NativeMethods.md)
* namespace [iTin.Core.Interop.Shared.Windows.Development.DeviceAndDriverInstallation.SetupApi](../../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->
