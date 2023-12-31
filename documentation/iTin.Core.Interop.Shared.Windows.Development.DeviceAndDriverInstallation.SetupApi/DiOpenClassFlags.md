# DiOpenClassFlags enumeration

Defines the type of registry key that will be opened.

```csharp
[Flags]
public enum DiOpenClassFlags : uint
```

## Values

| name | value | description |
| --- | --- | --- |
| DIOCR_INSTALLER | `0x1` | Open a configuration class key. If ClassGuid is `null`, open the root key of the class installer's branch. |
| DIOCR_INTERFACE | `0x2` | Open an interface class key. If ClassGuid is `null`, open the root key of the interface class branch. |

## See Also

* namespace [iTin.Core.Interop.Shared.Windows.Development.DeviceAndDriverInstallation.SetupApi](../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->
