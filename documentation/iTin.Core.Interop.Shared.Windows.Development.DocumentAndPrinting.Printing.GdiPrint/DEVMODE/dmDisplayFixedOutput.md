# DEVMODE.dmDisplayFixedOutput field

Para dispositivos de pantalla de resolución fija, cómo la pantalla presenta un modo de baja resolución en una pantalla de alta resolución. Por ejemplo, si la resolución de un dispositivo de visualización se fija en 1024 x 768 píxeles, pero su modo está establecido en 640 x 480 píxeles, el dispositivo puede mostrar una imagen de 640 x 480 en algún lugar en el interior del espacio de pantalla de 1024 x 768 o expandir la imagen de 640 x 480 para rellenar el espacio de pantalla más grande. Si DM_DISPLAYFIXEDOUTPUT no está configurado, este miembro debe ser cero. Si DM_DISPLAYFIXEDOUTPUT está configurado, este miembro debe ser uno de los siguientes valores: DMDFO_DEFAULT, configuración predeterminada de la pantalla. DMDFO_CENTER, la imagen de baja resolución se centra en el mayor espacio en la pantalla. DMDFO_STRETCH, la imagen de baja resolución se estira para rellenar el espacio de pantalla más grande

```csharp
public int dmDisplayFixedOutput;
```

## See Also

* struct [DEVMODE](../DEVMODE.md)
* namespace [iTin.Core.Interop.Shared.Windows.Development.DocumentAndPrinting.Printing.GdiPrint](../../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->
