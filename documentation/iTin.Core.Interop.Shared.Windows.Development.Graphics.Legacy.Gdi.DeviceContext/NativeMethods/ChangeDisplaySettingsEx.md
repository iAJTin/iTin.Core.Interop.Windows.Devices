# NativeMethods.ChangeDisplaySettingsEx method

Change the specified screen settings for the specified graphics mode. For more information, please see http://msdn.microsoft.com/es-es/library/dd183411.aspx.

```csharp
public static DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, 
    IntPtr hwnd, int dwflags, IntPtr lParam)
```

## See Also

* enum [DISP_CHANGE](../NativeMethods.DISP_CHANGE.md)
* struct [DEVMODE](../../iTin.Core.Interop.Shared.Windows.Development.DocumentAndPrinting.Printing.GdiPrint/DEVMODE.md)
* class [NativeMethods](../NativeMethods.md)
* namespace [iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.DeviceContext](../../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->