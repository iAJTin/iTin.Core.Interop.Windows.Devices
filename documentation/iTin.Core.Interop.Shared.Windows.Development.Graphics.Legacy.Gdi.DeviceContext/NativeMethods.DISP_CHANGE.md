# NativeMethods.DISP_CHANGE enumeration

Return values for the [`ChangeDisplaySettings`](./NativeMethods/ChangeDisplaySettings.md) and [`ChangeDisplaySettingsEx`](./NativeMethods/ChangeDisplaySettingsEx.md) functions. For more information, please see http://msdn.microsoft.com/es-es/library/dd183411.aspx.

```csharp
public enum DISP_CHANGE
```

## Values

| name | value | description |
| --- | --- | --- |
| DISP_CHANGE_SUCCESSFUL | `0` | The configuration change was successful. |
| DISP_CHANGE_RESTART | `1` | You must restart the computer for the chart mode to work. |
| DISP_CHANGE_FAILED | `-1` | The driver generated an error for the specified video mode. |
| DISP_CHANGE_BADMODE | `-2` | Graphic mode not supported. |
| DISP_CHANGE_NOTUPDATED | `-3` | The configuration cannot be written to the registry. |
| DISP_CHANGE_BADFLAGS | `-4` | Flag or set of invalid Flags. |
| DISP_CHANGE_BADPARAM | `-5` | An invalid parameter was passed in the Flags field. This may include an invalid flag or a combination of invalid flags. |
| DISP_CHANGE_BADDUALVIEW | `-6` | The configuration change was unsuccessful because the system is capable of DualView. |

## See Also

* class [NativeMethods](./NativeMethods.md)
* namespace [iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.DeviceContext](../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->
