# <a id="Billing_BackOffice_Orleans_Infrastructure_Extensions_OrleansExtensions"></a> Class OrleansExtensions

Namespace: [Billing.BackOffice.Orleans.Infrastructure.Extensions](Billing.BackOffice.Orleans.Infrastructure.Extensions.md)  
Assembly: Billing.BackOffice.Orleans.dll  

```csharp
public static class OrleansExtensions
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OrleansExtensions](Billing.BackOffice.Orleans.Infrastructure.Extensions.OrleansExtensions.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

## Methods

### <a id="Billing_BackOffice_Orleans_Infrastructure_Extensions_OrleansExtensions_AddOrleans_Microsoft_Extensions_Hosting_IHostApplicationBuilder_"></a> AddOrleans\(IHostApplicationBuilder\)

```csharp
public static IHostApplicationBuilder AddOrleans(this IHostApplicationBuilder builder)
```

#### Parameters

`builder` [IHostApplicationBuilder](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.ihostapplicationbuilder)

#### Returns

 [IHostApplicationBuilder](https://learn.microsoft.com/dotnet/api/microsoft.extensions.hosting.ihostapplicationbuilder)

### <a id="Billing_BackOffice_Orleans_Infrastructure_Extensions_OrleansExtensions_MapOrleansDashboard_Microsoft_AspNetCore_Builder_WebApplication_System_String_"></a> MapOrleansDashboard\(WebApplication, string\)

```csharp
public static WebApplication MapOrleansDashboard(this WebApplication app, string path = "/dashboard")
```

#### Parameters

`app` [WebApplication](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.builder.webapplication)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [WebApplication](https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.builder.webapplication)

