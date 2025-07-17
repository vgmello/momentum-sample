# <a id="Billing_Api_Cashiers_CashiersController"></a> Class CashiersController

Namespace: [Billing.Api.Cashiers](Billing.Api.Cashiers.md)  
Assembly: Billing.Api.dll  

Manages cashier operations such as retrieval, creation, updating, and deletion.

```csharp
[ApiController]
[Route("[controller]")]
public class CashiersController : ControllerBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ControllerBase](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase) ← 
[CashiersController](Billing.Api.Cashiers.CashiersController.md)

#### Inherited Members

[ControllerBase.StatusCode\(int\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.statuscode\#microsoft\-aspnetcore\-mvc\-controllerbase\-statuscode\(system\-int32\)), 
[ControllerBase.StatusCode\(int, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.statuscode\#microsoft\-aspnetcore\-mvc\-controllerbase\-statuscode\(system\-int32\-system\-object\)), 
[ControllerBase.Content\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content\#microsoft\-aspnetcore\-mvc\-controllerbase\-content\(system\-string\)), 
[ControllerBase.Content\(string, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content\#microsoft\-aspnetcore\-mvc\-controllerbase\-content\(system\-string\-system\-string\)), 
[ControllerBase.Content\(string, string, Encoding\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content\#microsoft\-aspnetcore\-mvc\-controllerbase\-content\(system\-string\-system\-string\-system\-text\-encoding\)), 
[ControllerBase.Content\(string, MediaTypeHeaderValue?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.content\#microsoft\-aspnetcore\-mvc\-controllerbase\-content\(system\-string\-microsoft\-net\-http\-headers\-mediatypeheadervalue\)), 
[ControllerBase.NoContent\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.nocontent), 
[ControllerBase.Ok\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.ok\#microsoft\-aspnetcore\-mvc\-controllerbase\-ok), 
[ControllerBase.Ok\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.ok\#microsoft\-aspnetcore\-mvc\-controllerbase\-ok\(system\-object\)), 
[ControllerBase.Redirect\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirect), 
[ControllerBase.RedirectPermanent\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirectpermanent), 
[ControllerBase.RedirectPreserveMethod\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirectpreservemethod), 
[ControllerBase.RedirectPermanentPreserveMethod\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirectpermanentpreservemethod), 
[ControllerBase.LocalRedirect\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirect), 
[ControllerBase.LocalRedirectPermanent\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirectpermanent), 
[ControllerBase.LocalRedirectPreserveMethod\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirectpreservemethod), 
[ControllerBase.LocalRedirectPermanentPreserveMethod\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.localredirectpermanentpreservemethod), 
[ControllerBase.RedirectToAction\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoaction), 
[ControllerBase.RedirectToAction\(string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoaction\(system\-string\)), 
[ControllerBase.RedirectToAction\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoaction\(system\-string\-system\-object\)), 
[ControllerBase.RedirectToAction\(string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoaction\(system\-string\-system\-string\)), 
[ControllerBase.RedirectToAction\(string?, string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoaction\(system\-string\-system\-string\-system\-object\)), 
[ControllerBase.RedirectToAction\(string?, string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoaction\(system\-string\-system\-string\-system\-string\)), 
[ControllerBase.RedirectToAction\(string?, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoaction\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoaction\(system\-string\-system\-string\-system\-object\-system\-string\)), 
[ControllerBase.RedirectToActionPreserveMethod\(string?, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpreservemethod), 
[ControllerBase.RedirectToActionPermanent\(string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoactionpermanent\(system\-string\)), 
[ControllerBase.RedirectToActionPermanent\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoactionpermanent\(system\-string\-system\-object\)), 
[ControllerBase.RedirectToActionPermanent\(string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoactionpermanent\(system\-string\-system\-string\)), 
[ControllerBase.RedirectToActionPermanent\(string?, string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoactionpermanent\(system\-string\-system\-string\-system\-string\)), 
[ControllerBase.RedirectToActionPermanent\(string?, string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoactionpermanent\(system\-string\-system\-string\-system\-object\)), 
[ControllerBase.RedirectToActionPermanent\(string?, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoactionpermanent\(system\-string\-system\-string\-system\-object\-system\-string\)), 
[ControllerBase.RedirectToActionPermanentPreserveMethod\(string?, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoactionpermanentpreservemethod), 
[ControllerBase.RedirectToRoute\(string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroute\(system\-string\)), 
[ControllerBase.RedirectToRoute\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroute\(system\-object\)), 
[ControllerBase.RedirectToRoute\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroute\(system\-string\-system\-object\)), 
[ControllerBase.RedirectToRoute\(string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroute\(system\-string\-system\-string\)), 
[ControllerBase.RedirectToRoute\(string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroute\(system\-string\-system\-object\-system\-string\)), 
[ControllerBase.RedirectToRoutePreserveMethod\(string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepreservemethod), 
[ControllerBase.RedirectToRoutePermanent\(string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroutepermanent\(system\-string\)), 
[ControllerBase.RedirectToRoutePermanent\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroutepermanent\(system\-object\)), 
[ControllerBase.RedirectToRoutePermanent\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroutepermanent\(system\-string\-system\-object\)), 
[ControllerBase.RedirectToRoutePermanent\(string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroutepermanent\(system\-string\-system\-string\)), 
[ControllerBase.RedirectToRoutePermanent\(string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttoroutepermanent\(system\-string\-system\-object\-system\-string\)), 
[ControllerBase.RedirectToRoutePermanentPreserveMethod\(string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttoroutepermanentpreservemethod), 
[ControllerBase.RedirectToPage\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopage\(system\-string\)), 
[ControllerBase.RedirectToPage\(string, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopage\(system\-string\-system\-object\)), 
[ControllerBase.RedirectToPage\(string, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopage\(system\-string\-system\-string\)), 
[ControllerBase.RedirectToPage\(string, string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopage\(system\-string\-system\-string\-system\-object\)), 
[ControllerBase.RedirectToPage\(string, string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopage\(system\-string\-system\-string\-system\-string\)), 
[ControllerBase.RedirectToPage\(string, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopage\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopage\(system\-string\-system\-string\-system\-object\-system\-string\)), 
[ControllerBase.RedirectToPagePermanent\(string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopagepermanent\(system\-string\)), 
[ControllerBase.RedirectToPagePermanent\(string, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopagepermanent\(system\-string\-system\-object\)), 
[ControllerBase.RedirectToPagePermanent\(string, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopagepermanent\(system\-string\-system\-string\)), 
[ControllerBase.RedirectToPagePermanent\(string, string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopagepermanent\(system\-string\-system\-string\-system\-string\)), 
[ControllerBase.RedirectToPagePermanent\(string, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanent\#microsoft\-aspnetcore\-mvc\-controllerbase\-redirecttopagepermanent\(system\-string\-system\-string\-system\-object\-system\-string\)), 
[ControllerBase.RedirectToPagePreserveMethod\(string, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepreservemethod), 
[ControllerBase.RedirectToPagePermanentPreserveMethod\(string, string?, object?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.redirecttopagepermanentpreservemethod), 
[ControllerBase.File\(byte\[\], string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\)), 
[ControllerBase.File\(byte\[\], string, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\-system\-boolean\)), 
[ControllerBase.File\(byte\[\], string, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\-system\-string\)), 
[ControllerBase.File\(byte\[\], string, string?, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\-system\-string\-system\-boolean\)), 
[ControllerBase.File\(byte\[\], string, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.File\(byte\[\], string, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.File\(byte\[\], string, string?, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.File\(byte\[\], string, string?, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-byte\(\)\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.File\(Stream, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\)), 
[ControllerBase.File\(Stream, string, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\-system\-boolean\)), 
[ControllerBase.File\(Stream, string, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\-system\-string\)), 
[ControllerBase.File\(Stream, string, string?, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\-system\-string\-system\-boolean\)), 
[ControllerBase.File\(Stream, string, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.File\(Stream, string, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.File\(Stream, string, string?, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.File\(Stream, string, string?, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-io\-stream\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.File\(string, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\)), 
[ControllerBase.File\(string, string, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\-system\-boolean\)), 
[ControllerBase.File\(string, string, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\-system\-string\)), 
[ControllerBase.File\(string, string, string?, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\-system\-string\-system\-boolean\)), 
[ControllerBase.File\(string, string, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.File\(string, string, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.File\(string, string, string?, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.File\(string, string, string?, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.file\#microsoft\-aspnetcore\-mvc\-controllerbase\-file\(system\-string\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.PhysicalFile\(string, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\)), 
[ControllerBase.PhysicalFile\(string, string, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\-system\-boolean\)), 
[ControllerBase.PhysicalFile\(string, string, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\-system\-string\)), 
[ControllerBase.PhysicalFile\(string, string, string?, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\-system\-string\-system\-boolean\)), 
[ControllerBase.PhysicalFile\(string, string, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.PhysicalFile\(string, string, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.PhysicalFile\(string, string, string?, DateTimeOffset?, EntityTagHeaderValue\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\)), 
[ControllerBase.PhysicalFile\(string, string, string?, DateTimeOffset?, EntityTagHeaderValue, bool\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.physicalfile\#microsoft\-aspnetcore\-mvc\-controllerbase\-physicalfile\(system\-string\-system\-string\-system\-string\-system\-nullable\(\(system\-datetimeoffset\)\)\-microsoft\-net\-http\-headers\-entitytagheadervalue\-system\-boolean\)), 
[ControllerBase.Unauthorized\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unauthorized\#microsoft\-aspnetcore\-mvc\-controllerbase\-unauthorized), 
[ControllerBase.Unauthorized\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unauthorized\#microsoft\-aspnetcore\-mvc\-controllerbase\-unauthorized\(system\-object\)), 
[ControllerBase.NotFound\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.notfound\#microsoft\-aspnetcore\-mvc\-controllerbase\-notfound), 
[ControllerBase.NotFound\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.notfound\#microsoft\-aspnetcore\-mvc\-controllerbase\-notfound\(system\-object\)), 
[ControllerBase.BadRequest\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.badrequest\#microsoft\-aspnetcore\-mvc\-controllerbase\-badrequest), 
[ControllerBase.BadRequest\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.badrequest\#microsoft\-aspnetcore\-mvc\-controllerbase\-badrequest\(system\-object\)), 
[ControllerBase.BadRequest\(ModelStateDictionary\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.badrequest\#microsoft\-aspnetcore\-mvc\-controllerbase\-badrequest\(microsoft\-aspnetcore\-mvc\-modelbinding\-modelstatedictionary\)), 
[ControllerBase.UnprocessableEntity\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unprocessableentity\#microsoft\-aspnetcore\-mvc\-controllerbase\-unprocessableentity), 
[ControllerBase.UnprocessableEntity\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unprocessableentity\#microsoft\-aspnetcore\-mvc\-controllerbase\-unprocessableentity\(system\-object\)), 
[ControllerBase.UnprocessableEntity\(ModelStateDictionary\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.unprocessableentity\#microsoft\-aspnetcore\-mvc\-controllerbase\-unprocessableentity\(microsoft\-aspnetcore\-mvc\-modelbinding\-modelstatedictionary\)), 
[ControllerBase.Conflict\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.conflict\#microsoft\-aspnetcore\-mvc\-controllerbase\-conflict), 
[ControllerBase.Conflict\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.conflict\#microsoft\-aspnetcore\-mvc\-controllerbase\-conflict\(system\-object\)), 
[ControllerBase.Conflict\(ModelStateDictionary\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.conflict\#microsoft\-aspnetcore\-mvc\-controllerbase\-conflict\(microsoft\-aspnetcore\-mvc\-modelbinding\-modelstatedictionary\)), 
[ControllerBase.Problem\(string?, string?, int?, string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.problem\#microsoft\-aspnetcore\-mvc\-controllerbase\-problem\(system\-string\-system\-string\-system\-nullable\(\(system\-int32\)\)\-system\-string\-system\-string\)), 
[ControllerBase.Problem\(string?, string?, int?, string?, string?, IDictionary<string, object?\>?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.problem\#microsoft\-aspnetcore\-mvc\-controllerbase\-problem\(system\-string\-system\-string\-system\-nullable\(\(system\-int32\)\)\-system\-string\-system\-string\-system\-collections\-generic\-idictionary\(\(system\-string\-system\-object\)\)\)), 
[ControllerBase.ValidationProblem\(ValidationProblemDetails\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem\#microsoft\-aspnetcore\-mvc\-controllerbase\-validationproblem\(microsoft\-aspnetcore\-mvc\-validationproblemdetails\)), 
[ControllerBase.ValidationProblem\(ModelStateDictionary\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem\#microsoft\-aspnetcore\-mvc\-controllerbase\-validationproblem\(microsoft\-aspnetcore\-mvc\-modelbinding\-modelstatedictionary\)), 
[ControllerBase.ValidationProblem\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem\#microsoft\-aspnetcore\-mvc\-controllerbase\-validationproblem), 
[ControllerBase.ValidationProblem\(string?, string?, int?, string?, string?, ModelStateDictionary?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem\#microsoft\-aspnetcore\-mvc\-controllerbase\-validationproblem\(system\-string\-system\-string\-system\-nullable\(\(system\-int32\)\)\-system\-string\-system\-string\-microsoft\-aspnetcore\-mvc\-modelbinding\-modelstatedictionary\)), 
[ControllerBase.ValidationProblem\(string?, string?, int?, string?, string?, ModelStateDictionary?, IDictionary<string, object?\>?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.validationproblem\#microsoft\-aspnetcore\-mvc\-controllerbase\-validationproblem\(system\-string\-system\-string\-system\-nullable\(\(system\-int32\)\)\-system\-string\-system\-string\-microsoft\-aspnetcore\-mvc\-modelbinding\-modelstatedictionary\-system\-collections\-generic\-idictionary\(\(system\-string\-system\-object\)\)\)), 
[ControllerBase.Created\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.created\#microsoft\-aspnetcore\-mvc\-controllerbase\-created), 
[ControllerBase.Created\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.created\#microsoft\-aspnetcore\-mvc\-controllerbase\-created\(system\-string\-system\-object\)), 
[ControllerBase.Created\(Uri?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.created\#microsoft\-aspnetcore\-mvc\-controllerbase\-created\(system\-uri\-system\-object\)), 
[ControllerBase.CreatedAtAction\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-createdataction\(system\-string\-system\-object\)), 
[ControllerBase.CreatedAtAction\(string?, object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-createdataction\(system\-string\-system\-object\-system\-object\)), 
[ControllerBase.CreatedAtAction\(string?, string?, object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-createdataction\(system\-string\-system\-string\-system\-object\-system\-object\)), 
[ControllerBase.CreatedAtRoute\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-createdatroute\(system\-string\-system\-object\)), 
[ControllerBase.CreatedAtRoute\(object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-createdatroute\(system\-object\-system\-object\)), 
[ControllerBase.CreatedAtRoute\(string?, object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.createdatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-createdatroute\(system\-string\-system\-object\-system\-object\)), 
[ControllerBase.Accepted\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted\#microsoft\-aspnetcore\-mvc\-controllerbase\-accepted), 
[ControllerBase.Accepted\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted\#microsoft\-aspnetcore\-mvc\-controllerbase\-accepted\(system\-object\)), 
[ControllerBase.Accepted\(Uri\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted\#microsoft\-aspnetcore\-mvc\-controllerbase\-accepted\(system\-uri\)), 
[ControllerBase.Accepted\(string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted\#microsoft\-aspnetcore\-mvc\-controllerbase\-accepted\(system\-string\)), 
[ControllerBase.Accepted\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted\#microsoft\-aspnetcore\-mvc\-controllerbase\-accepted\(system\-string\-system\-object\)), 
[ControllerBase.Accepted\(Uri, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.accepted\#microsoft\-aspnetcore\-mvc\-controllerbase\-accepted\(system\-uri\-system\-object\)), 
[ControllerBase.AcceptedAtAction\(string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedataction\(system\-string\)), 
[ControllerBase.AcceptedAtAction\(string?, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedataction\(system\-string\-system\-string\)), 
[ControllerBase.AcceptedAtAction\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedataction\(system\-string\-system\-object\)), 
[ControllerBase.AcceptedAtAction\(string?, string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedataction\(system\-string\-system\-string\-system\-object\)), 
[ControllerBase.AcceptedAtAction\(string?, object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedataction\(system\-string\-system\-object\-system\-object\)), 
[ControllerBase.AcceptedAtAction\(string?, string?, object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedataction\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedataction\(system\-string\-system\-string\-system\-object\-system\-object\)), 
[ControllerBase.AcceptedAtRoute\(object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedatroute\(system\-object\)), 
[ControllerBase.AcceptedAtRoute\(string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedatroute\(system\-string\)), 
[ControllerBase.AcceptedAtRoute\(string?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedatroute\(system\-string\-system\-object\)), 
[ControllerBase.AcceptedAtRoute\(object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedatroute\(system\-object\-system\-object\)), 
[ControllerBase.AcceptedAtRoute\(string?, object?, object?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.acceptedatroute\#microsoft\-aspnetcore\-mvc\-controllerbase\-acceptedatroute\(system\-string\-system\-object\-system\-object\)), 
[ControllerBase.Challenge\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge\#microsoft\-aspnetcore\-mvc\-controllerbase\-challenge), 
[ControllerBase.Challenge\(params string\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge\#microsoft\-aspnetcore\-mvc\-controllerbase\-challenge\(system\-string\(\)\)), 
[ControllerBase.Challenge\(AuthenticationProperties\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge\#microsoft\-aspnetcore\-mvc\-controllerbase\-challenge\(microsoft\-aspnetcore\-authentication\-authenticationproperties\)), 
[ControllerBase.Challenge\(AuthenticationProperties, params string\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.challenge\#microsoft\-aspnetcore\-mvc\-controllerbase\-challenge\(microsoft\-aspnetcore\-authentication\-authenticationproperties\-system\-string\(\)\)), 
[ControllerBase.Forbid\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid\#microsoft\-aspnetcore\-mvc\-controllerbase\-forbid), 
[ControllerBase.Forbid\(params string\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid\#microsoft\-aspnetcore\-mvc\-controllerbase\-forbid\(system\-string\(\)\)), 
[ControllerBase.Forbid\(AuthenticationProperties\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid\#microsoft\-aspnetcore\-mvc\-controllerbase\-forbid\(microsoft\-aspnetcore\-authentication\-authenticationproperties\)), 
[ControllerBase.Forbid\(AuthenticationProperties, params string\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.forbid\#microsoft\-aspnetcore\-mvc\-controllerbase\-forbid\(microsoft\-aspnetcore\-authentication\-authenticationproperties\-system\-string\(\)\)), 
[ControllerBase.SignIn\(ClaimsPrincipal\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin\#microsoft\-aspnetcore\-mvc\-controllerbase\-signin\(system\-security\-claims\-claimsprincipal\)), 
[ControllerBase.SignIn\(ClaimsPrincipal, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin\#microsoft\-aspnetcore\-mvc\-controllerbase\-signin\(system\-security\-claims\-claimsprincipal\-system\-string\)), 
[ControllerBase.SignIn\(ClaimsPrincipal, AuthenticationProperties\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin\#microsoft\-aspnetcore\-mvc\-controllerbase\-signin\(system\-security\-claims\-claimsprincipal\-microsoft\-aspnetcore\-authentication\-authenticationproperties\)), 
[ControllerBase.SignIn\(ClaimsPrincipal, AuthenticationProperties, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signin\#microsoft\-aspnetcore\-mvc\-controllerbase\-signin\(system\-security\-claims\-claimsprincipal\-microsoft\-aspnetcore\-authentication\-authenticationproperties\-system\-string\)), 
[ControllerBase.SignOut\(\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout\#microsoft\-aspnetcore\-mvc\-controllerbase\-signout), 
[ControllerBase.SignOut\(AuthenticationProperties\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout\#microsoft\-aspnetcore\-mvc\-controllerbase\-signout\(microsoft\-aspnetcore\-authentication\-authenticationproperties\)), 
[ControllerBase.SignOut\(params string\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout\#microsoft\-aspnetcore\-mvc\-controllerbase\-signout\(system\-string\(\)\)), 
[ControllerBase.SignOut\(AuthenticationProperties, params string\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.signout\#microsoft\-aspnetcore\-mvc\-controllerbase\-signout\(microsoft\-aspnetcore\-authentication\-authenticationproperties\-system\-string\(\)\)), 
[ControllerBase.TryUpdateModelAsync<TModel\>\(TModel\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\-1\(\-0\)), 
[ControllerBase.TryUpdateModelAsync<TModel\>\(TModel, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\-1\(\-0\-system\-string\)), 
[ControllerBase.TryUpdateModelAsync<TModel\>\(TModel, string, IValueProvider\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\-1\(\-0\-system\-string\-microsoft\-aspnetcore\-mvc\-modelbinding\-ivalueprovider\)), 
[ControllerBase.TryUpdateModelAsync<TModel\>\(TModel, string, params Expression<Func<TModel, object?\>\>\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\-1\(\-0\-system\-string\-system\-linq\-expressions\-expression\(\(system\-func\(\(\-0\-system\-object\)\)\)\)\(\)\)), 
[ControllerBase.TryUpdateModelAsync<TModel\>\(TModel, string, Func<ModelMetadata, bool\>\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\-1\(\-0\-system\-string\-system\-func\(\(microsoft\-aspnetcore\-mvc\-modelbinding\-modelmetadata\-system\-boolean\)\)\)), 
[ControllerBase.TryUpdateModelAsync<TModel\>\(TModel, string, IValueProvider, params Expression<Func<TModel, object?\>\>\[\]\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\-1\(\-0\-system\-string\-microsoft\-aspnetcore\-mvc\-modelbinding\-ivalueprovider\-system\-linq\-expressions\-expression\(\(system\-func\(\(\-0\-system\-object\)\)\)\)\(\)\)), 
[ControllerBase.TryUpdateModelAsync<TModel\>\(TModel, string, IValueProvider, Func<ModelMetadata, bool\>\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\-1\(\-0\-system\-string\-microsoft\-aspnetcore\-mvc\-modelbinding\-ivalueprovider\-system\-func\(\(microsoft\-aspnetcore\-mvc\-modelbinding\-modelmetadata\-system\-boolean\)\)\)), 
[ControllerBase.TryUpdateModelAsync\(object, Type, string\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\(system\-object\-system\-type\-system\-string\)), 
[ControllerBase.TryUpdateModelAsync\(object, Type, string, IValueProvider, Func<ModelMetadata, bool\>\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryupdatemodelasync\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryupdatemodelasync\(system\-object\-system\-type\-system\-string\-microsoft\-aspnetcore\-mvc\-modelbinding\-ivalueprovider\-system\-func\(\(microsoft\-aspnetcore\-mvc\-modelbinding\-modelmetadata\-system\-boolean\)\)\)), 
[ControllerBase.TryValidateModel\(object\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryvalidatemodel\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryvalidatemodel\(system\-object\)), 
[ControllerBase.TryValidateModel\(object, string?\)](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.tryvalidatemodel\#microsoft\-aspnetcore\-mvc\-controllerbase\-tryvalidatemodel\(system\-object\-system\-string\)), 
[ControllerBase.HttpContext](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.httpcontext), 
[ControllerBase.Request](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.request), 
[ControllerBase.Response](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.response), 
[ControllerBase.RouteData](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.routedata), 
[ControllerBase.ModelState](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.modelstate), 
[ControllerBase.ControllerContext](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.controllercontext), 
[ControllerBase.MetadataProvider](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.metadataprovider), 
[ControllerBase.ModelBinderFactory](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.modelbinderfactory), 
[ControllerBase.Url](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.url), 
[ControllerBase.ObjectValidator](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.objectvalidator), 
[ControllerBase.ProblemDetailsFactory](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.problemdetailsfactory), 
[ControllerBase.User](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.user), 
[ControllerBase.Empty](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.controllerbase.empty), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Constructors

### <a id="Billing_Api_Cashiers_CashiersController__ctor_Wolverine_IMessageBus_"></a> CashiersController\(IMessageBus\)

Manages cashier operations such as retrieval, creation, updating, and deletion.

```csharp
public CashiersController(IMessageBus bus)
```

#### Parameters

`bus` IMessageBus

## Methods

### <a id="Billing_Api_Cashiers_CashiersController_CreateCashier_Billing_Cashiers_Commands_CreateCashierCommand_System_Threading_CancellationToken_"></a> CreateCashier\(CreateCashierCommand, CancellationToken\)

Creates a new cashier in the system

```csharp
[HttpPost]
[ProducesResponseType<object>(400)]
public Task<ActionResult<Cashier>> CreateCashier(CreateCashierCommand command, CancellationToken cancellationToken)
```

#### Parameters

`command` [CreateCashierCommand](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Commands/CreateCashier.cs)

The cashier creation request containing name and email

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

Cancellation token

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ActionResult](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.actionresult\-1)<[Cashier](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Contracts/Models/Cashier.cs)\>\>

The created cashier details

### <a id="Billing_Api_Cashiers_CashiersController_DeleteCashier_System_Guid_System_Threading_CancellationToken_"></a> DeleteCashier\(Guid, CancellationToken\)

Deletes a cashier from the system

```csharp
[HttpDelete("{id:guid}")]
[ProducesResponseType<object>(400)]
public Task<ActionResult> DeleteCashier(Guid id, CancellationToken cancellationToken)
```

#### Parameters

`id` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

The unique identifier of the cashier to delete

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

Cancellation token

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ActionResult](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.actionresult)\>

No content if successful

### <a id="Billing_Api_Cashiers_CashiersController_FakeError"></a> FakeError\(\)

Testing endpoint that throws an exception for error handling validation

```csharp
[HttpGet("fake-error")]
[Tags(new string[] { "Testing" })]
public Task<ActionResult<Cashier>> FakeError()
```

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ActionResult](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.actionresult\-1)<[Cashier](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Contracts/Models/Cashier.cs)\>\>

Never returns successfully - always throws an exception

### <a id="Billing_Api_Cashiers_CashiersController_GetCashier_System_Guid_System_Threading_CancellationToken_"></a> GetCashier\(Guid, CancellationToken\)

Retrieves a specific cashier by their unique identifier

```csharp
[HttpGet("{id:guid}")]
[ProducesResponseType(404)]
[ProducesResponseType<object>(400)]
public Task<ActionResult<Cashier>> GetCashier(Guid id, CancellationToken cancellationToken)
```

#### Parameters

`id` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

The unique identifier of the cashier

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

Cancellation token

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ActionResult](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.actionresult\-1)<[Cashier](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Contracts/Models/Cashier.cs)\>\>

The cashier details if found

### <a id="Billing_Api_Cashiers_CashiersController_GetCashiers_Billing_Cashiers_Queries_GetCashiersQuery_System_Threading_CancellationToken_"></a> GetCashiers\(GetCashiersQuery, CancellationToken\)

Retrieves a list of cashiers with optional filtering

```csharp
[HttpGet]
[ProducesResponseType<object>(400)]
public Task<ActionResult<IEnumerable<GetCashiersQuery.Result>>> GetCashiers(GetCashiersQuery query, CancellationToken cancellationToken)
```

#### Parameters

`query` [GetCashiersQuery](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Queries/GetCashiers.cs)

Query parameters for filtering and pagination

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

Cancellation token

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ActionResult](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.actionresult\-1)<[IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[GetCashiersQuery](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Queries/GetCashiers.cs).[Result](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Queries/GetCashiers.cs)\>\>\>

A list of cashiers matching the specified criteria

### <a id="Billing_Api_Cashiers_CashiersController_UpdateCashier_System_Guid_Billing_Cashiers_Commands_UpdateCashierCommand_System_Threading_CancellationToken_"></a> UpdateCashier\(Guid, UpdateCashierCommand, CancellationToken\)

Updates an existing cashier's information

```csharp
[HttpPut("{id:guid}")]
[ProducesResponseType<object>(400)]
public Task<ActionResult<Cashier>> UpdateCashier(Guid id, UpdateCashierCommand command, CancellationToken cancellationToken)
```

#### Parameters

`id` [Guid](https://learn.microsoft.com/dotnet/api/system.guid)

The unique identifier of the cashier to update

`command` [UpdateCashierCommand](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Commands/UpdateCashier.cs)

The updated cashier information

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

Cancellation token

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[ActionResult](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.mvc.actionresult\-1)<[Cashier](https://github.com/vgmello/momentum\-sample/blob/0b2e226d00660d6f2b9ea7a033ba4926f0678942/src/Billing/Cashiers/Contracts/Models/Cashier.cs)\>\>

The updated cashier details

