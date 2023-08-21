# MONITORINFO structure

The MONITORINFO structure contains information about a monitor. The MONITORINFO structure is a subset of the [`MONITORINFOEX`](./MONITORINFOEX.md) structure. The [`MONITORINFOEX`](./MONITORINFOEX.md) structure adds a member that contains the name for the monitor. For more information, please see http://msdn.microsoft.com/es-es/library/dd145065.

```csharp
public struct MONITORINFO : IEquatable<MONITORINFO>
```

## Public Members

| name | description |
| --- | --- |
| static [Create](MONITORINFO/Create.md) { get; } | Create a new instance of this structure. |
| [Flags](MONITORINFO/Flags.md) | Attributes of the monitor. |
| [Monitor](MONITORINFO/Monitor.md) | A structure [`RECT`](../iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Rectangles/RECT.md) that specifies the rectangle of the total area of the monitor. |
| [Size](MONITORINFO/Size.md) | Specifies the size, in bytes, of the MONITORINFO structure. Must be initialized before calling a Api function. |
| [WorkArea](MONITORINFO/WorkArea.md) | A structure [`RECT`](../iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Rectangles/RECT.md) that specifies the rectangle of the working area of the useful monitor that can be used by applications, expressed in virtual screen coordinates. Windows uses this rectangle to maximize an application on the monitor. Toolbars, status bars, etc. are excluded. |
| [Equals](MONITORINFO/Equals.md)(…) | Indicates whether the current object is the same as another object of the same type. |
| override [Equals](MONITORINFO/Equals.md)(…) | Returns a value that indicates whether this object is equal to another. |
| override [GetHashCode](MONITORINFO/GetHashCode.md)() | Returns the hash code of the object. |
| override [ToString](MONITORINFO/ToString.md)() | Returns a string that represents the current [`MONITORINFO`](./MONITORINFO.md) object. |
| [operator ==](MONITORINFO/op_Equality.md) | Implement the equality operator (==). |
| [operator !=](MONITORINFO/op_Inequality.md) | Implements the inequality operator (!=). |

## See Also

* namespace [iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors](../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->