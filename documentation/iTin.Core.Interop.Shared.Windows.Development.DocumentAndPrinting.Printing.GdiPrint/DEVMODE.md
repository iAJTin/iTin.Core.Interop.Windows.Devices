# DEVMODE structure

La estructura de datos DEVMODE contiene información para la inicialización de una impresora o un dispositivo de visualización.

```csharp
public struct DEVMODE : IEquatable<DEVMODE>
```

## Public Members

| name | description |
| --- | --- |
| static [Empty](DEVMODE/Empty.md) |  |
| [dmBitsPerPel](DEVMODE/dmBitsPerPel.md) | Especifica la resolución de color, en bits por píxel, de la pantalla (por ejemplo: 4 bits de 16 colores, 8 bits de 256 colores o 16 bits para 65.536 colores). Los controladores de pantalla utilizan este campo, por ejemplo, en la función ChangeDisplaySettings. Los controladores de impresora no deben utilizar este campo. |
| [dmCollate](DEVMODE/dmCollate.md) | Especifica si se debe utilizar intercalación al imprimir varias copias. (Este campo se omite a menos que el controlador de impresora establezca el campo DM_COLLATE). Este miembro puede ser uno de los siguientes valores. DMCOLLATE_TRUE, intercalar al imprimir varias copias. DMCOLLATE_FALSE. no intercalar al imprimir varias copias. |
| [dmColor](DEVMODE/dmColor.md) | Cambia entre color y monocromo en impresoras de color. Los valores posibles son las siguientes: DMCOLOR_COLOR . DMCOLOR_MONOCHROME . |
| [dmDeviceName](DEVMODE/dmDeviceName.md) | Una cadena que especifica el nombre "descriptivo" de la impresora o dispositivo de visualización; por ejemplo, "pcl/HP LaserJet" en el caso de PCL/HP LaserJet. Esta cadena es única entre los controladores de dispositivos. |
| [dmDisplayFixedOutput](DEVMODE/dmDisplayFixedOutput.md) | Para dispositivos de pantalla de resolución fija, cómo la pantalla presenta un modo de baja resolución en una pantalla de alta resolución. Por ejemplo, si la resolución de un dispositivo de visualización se fija en 1024 x 768 píxeles, pero su modo está establecido en 640 x 480 píxeles, el dispositivo puede mostrar una imagen de 640 x 480 en algún lugar en el interior del espacio de pantalla de 1024 x 768 o expandir la imagen de 640 x 480 para rellenar el espacio de pantalla más grande. Si DM_DISPLAYFIXEDOUTPUT no está configurado, este miembro debe ser cero. Si DM_DISPLAYFIXEDOUTPUT está configurado, este miembro debe ser uno de los siguientes valores: DMDFO_DEFAULT, configuración predeterminada de la pantalla. DMDFO_CENTER, la imagen de baja resolución se centra en el mayor espacio en la pantalla. DMDFO_STRETCH, la imagen de baja resolución se estira para rellenar el espacio de pantalla más grande |
| [dmDisplayFlags](DEVMODE/dmDisplayFlags.md) | Especifica el modo de visualización del dispositivo. Este miembro puede ser una combinación de los siguientes valores. DM_GRAYSCALE, especifica que la pantalla es un dispositivo monocromo. Si no se establece este indicador, se asume que es de color. DM_INTERLACED, especifica que el modo de visualización es entrelazado. Si no se establece este indicador, se asume que es no entrelazado. |
| [dmDisplayFrequency](DEVMODE/dmDisplayFrequency.md) | Especifica la frecuencia, en hertz (ciclos por segundo), de la pantalla en un modo especial. Este valor se conoce como tasa de refresco vertical del dispositivo de pantalla. Los controladores de pantalla utilizan a este miembro. Por ejemplo, se utiliza en la función ChangeDisplaySettings. Los controladores de impresora no deben utilizar este campo. Cuando se llama a la función EnumDisplaySettings, puede devolver el campo dmDisplayFrequency con el valor 0 ó 1, estos valores representan la frecuencia de actualización del hardware de visualización por defecto. Esta tasa predeterminada se establece mediante conmutadores en una motherboard de equipo o la tarjeta de presentación, o por un programa de configuración que no utilizan funciones de visualización como ChangeDisplaySettings. |
| [dmDisplayOrientation](DEVMODE/dmDisplayOrientation.md) | Para dispositivos de pantalla, la orientación a que se presenten imágenes. Si DM_DISPLAYORIENTATION no está configurado, este miembro debe ser cero. Si DM_DISPLAYORIENTATION está configurado, este miembro debe ser uno de los siguientes valores: DMDO_DEFAULT, la orientación de la pantalla es la orientación normal del dispositivo (opción por defecto). DMDO_90, la orientación de la pantalla se rota 90 grados. (en sentido de las agujas del reloj) desde su posición natural. DMDO_180, la orientación de la pantalla se rota 180 grados. (en sentido de las agujas del reloj) desde su posición natural. DMDO_270, la orientación de la pantalla se rota 270 grados. (en sentido de las agujas del reloj) desde su posición natural. |
| [dmDriverExtra](DEVMODE/dmDriverExtra.md) | Contiene el número de bytes de datos de controlador privados que siguen esta estructura. Si un controlador de dispositivo no utiliza información específica del dispositivo, este campo ha de ser 0. |
| [dmDriverVersion](DEVMODE/dmDriverVersion.md) | Número de versión del controlador establecido por el fabricante del mismo. |
| [dmDuplex](DEVMODE/dmDuplex.md) | Selecciona la impresión dúplex o caras para impresoras capaces de impresión a doble cara. Los siguientes son los valores posibles DMDUP_SIMPLEX, Impresión normal (noduplex). DMDUP_HORIZONTAL, el lado largo de la página es horizontal. DMDUP_VERTICAL, el lado largo de la página es vertical. |
| [dmFields](DEVMODE/dmFields.md) | Especifica si algunos miembros de la estructura DEVMODE se ha inicializado. Si un miembro se ha inicializado, su correspondiente bit está establecido a '1', de lo contrario el bit es '0'. Un controlador admite sólo a los miembros DEVMODE que son adecuados para la impresora o dispositivo de visualización. Para más información ver [`DM`](./DEVMODE.DM.md). |
| [dmFormName](DEVMODE/dmFormName.md) | Una cadena que especifica el nombre del formulario para utilizar; por ejemplo, "Carta" o "Legal". Un conjunto completo de nombres se puede obtener mediante la función EnumForms. |
| [dmLogPixels](DEVMODE/dmLogPixels.md) | Número de píxeles por pulgada. Los controladores de impresora no deben utilizar este campo. |
| [dmNup](DEVMODE/dmNup.md) | Especifica dónde se realiza el NUP. Puede ser uno de los siguientes. DMNUP_SYSTEM, la cola de impresión hace NUP. DMNUP_ONEUP, la aplicación hace NUP. |
| [dmPelsHeight](DEVMODE/dmPelsHeight.md) | Especifica el alto, en píxeles, de la superficie visible del dispositivo. Los controladores de pantalla utilizan este campo, por ejemplo, en la función ChangeDisplaySettings. Los controladores de impresora no deben utilizar este campo. |
| [dmPelsWidth](DEVMODE/dmPelsWidth.md) | Especifica la anchura, en píxeles, de la superficie visible del dispositivo. Los controladores de pantalla utilizan este campo, por ejemplo, en la función ChangeDisplaySettings. Los controladores de impresora no deben utilizar este campo. |
| [dmPosition](DEVMODE/dmPosition.md) | Para dispositivos de pantalla sólo, una estructura [`POINTL`](../iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.Metafiles/POINTL.md) que indica las coordenadas posicionales de la pantalla en referencia a la zona de escritorio. El dispositivo de pantalla principal siempre está situado en las coordenadas (0,0). |
| [dmSize](DEVMODE/dmSize.md) | Especifica el tamaño, en bytes, de la estructura DEVMODE, sin incluir los datos específicos del controlador privados que podrían seguir a los miembros públicos de la estructura. |
| [dmSpecVersion](DEVMODE/dmSpecVersion.md) | Número de versión de la especificación de datos de inicialización en que se basa la estructura. Para asegurarse de que utiliza la versión correcta para cualquier sistema operativo, utilice DM_SPECVERSION. |
| [dmTTOption](DEVMODE/dmTTOption.md) | Especifica cómo se deben imprimir fuentes TrueType. Este miembro puede ser uno de los siguientes valores. DMTT_BITMAP, imprime las fuentes TrueType como gráficos. Se trata de la acción predeterminada para impresoras matriciales. DMTT_DOWNLOAD, fuentes TrueType como transferibles. Se trata de la acción predeterminada para las impresoras Hewlett-Packard que utilizan el lenguaje de Control de impresoras (PCL). DMTT_DOWNLOAD_OUTLINE, como esquema transferible. DMTT_SUBDEV, sustituto para fuentes TrueType. Se trata de la acción predeterminada para las impresoras PostScript. |
| [dmYResolution](DEVMODE/dmYResolution.md) | Especifica la resolución, en puntos por pulgada, de la impresora. Si la impresora inicializa este miembro, el campo dmPrintQuality especifica la resolución x, en puntos por pulgada, de la impresora. |
| [Equals](DEVMODE/Equals.md)(…) | Indica si la estructura actual es igual a otra estructura del mismo tipo. |
| override [Equals](DEVMODE/Equals.md)(…) | Devuelve un valor que indica si esta estructutra es igual a otra. |
| override [GetHashCode](DEVMODE/GetHashCode.md)() | Devuelve un valor que repesenta al código hash de esta estructura. |
| override [ToString](DEVMODE/ToString.md)() | Devuelve una cadena que representa la estructura [`DEVMODE`](./DEVMODE.md) actual. |
| const [ENUM_CURRENT_SETTINGS](DEVMODE/ENUM_CURRENT_SETTINGS.md) | Indica que se va a recuperar la configuración actual para el dispositivo de pantalla. |
| const [ENUM_REGISTRY_SETTINGS](DEVMODE/ENUM_REGISTRY_SETTINGS.md) | Indica que se va a recuperar la configuración del dispositivo de visualización que está almacenada en el registro. |
| [operator ==](DEVMODE/op_Equality.md) | Implementa el operador de igualdad (==). |
| [operator !=](DEVMODE/op_Inequality.md) | Implementa el operador de desigualdad (!=). |
| [Flags] enum [DisplayFlags](DEVMODE.DisplayFlags.md) | Enumeración de atributos de estado de una estructura [`DEVMODE`](./DEVMODE.md). |
| [Flags] enum [DM](DEVMODE.DM.md) | Enumeración de miembros de una estructura de tipo [`DEVMODE`](./DEVMODE.md). |

## Remarks

Para más información, ver http://msdn.microsoft.com/es-es/library/dd183565.aspx.

## See Also

* namespace [iTin.Core.Interop.Shared.Windows.Development.DocumentAndPrinting.Printing.GdiPrint](../iTin.Core.Interop.Windows.Devices.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Core.Interop.Windows.Devices.dll -->
