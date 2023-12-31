# DISPLAY_DEVICE.KnownDisplayDeviceStates enumeration

Enumeration of status attributes of a [`DISPLAY_DEVICE`](./DISPLAY_DEVICE.md) structure. For more information, please see http://msdn.microsoft.com/es-es/library/dd183569.aspx.

```csharp
[Flags]
public enum KnownDisplayDeviceStates
```

## Values

| name | value | description |
| --- | --- | --- |
| AttachedToDesktop | `0x1` | Indicates that the device shows the desktop. |
| MultiDriver | `0x2` |  |
| PrimaryDevice | `0x4` | Indicates that it is the main desktop. For a system with a video adapter, it is always set. For a system with several video cards, only one can have this flag active. |
| MirroringDriver | `0x8` | It represents a pseudo device to reflect the drawing application for remote interaction or for other purposes. A pseudo invisible monitor is associated with this device. For example, NetMeeting uses it. |
| VgaCompatible | `0x10` | The device is compatible with VGA. |
| Removable | `0x20` | The device is removable; It cannot be the main screen. |
| UnSafeModesOn | `0x80000` |  |
| TsCompatible | `0x200000` |  |
| Disconnect | `0x2000000` |  |
| Remote | `0x4000000` |  |
| ModesPruned | `0x8000000` | The device has more video modes. |

## See Also

* struct [DISPLAY_DEVICE](./DISPLAY_DEVICE.md)
* namespace [iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.DeviceContext](../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->
