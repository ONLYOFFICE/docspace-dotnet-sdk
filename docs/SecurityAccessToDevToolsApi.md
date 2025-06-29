# Docspace.Api.SecurityAccessToDevToolsApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SetTenantDevToolsAccessSettings**](SecurityAccessToDevToolsApi.md#settenantdevtoolsaccesssettings) | **POST** /api/2.0/settings/devtoolsaccess | Set the Developer Tools access settings |

<a id="settenantdevtoolsaccesssettings"></a>
# **SetTenantDevToolsAccessSettings**
> TenantDevToolsAccessSettingsWrapper SetTenantDevToolsAccessSettings (TenantDevToolsAccessSettingsDto? tenantDevToolsAccessSettingsDto = null)

Set the Developer Tools access settings

Sets the Developer Tools access settings for the portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Docspace.Api;
using Docspace.Client;
using Docspace.Model;

namespace Example
{
    public class SetTenantDevToolsAccessSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://http:";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure OAuth2 access token for authorization: OAuth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure Bearer token for authorization: ApiKeyBearer
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure API key authorization: asc_auth_key
            config.AddApiKey("asc_auth_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("asc_auth_key", "Bearer");
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SecurityAccessToDevToolsApi(httpClient, config, httpClientHandler);
            var tenantDevToolsAccessSettingsDto = new TenantDevToolsAccessSettingsDto?(); // TenantDevToolsAccessSettingsDto? |  (optional) 

            try
            {
                // Set the Developer Tools access settings
                TenantDevToolsAccessSettingsWrapper result = apiInstance.SetTenantDevToolsAccessSettings(tenantDevToolsAccessSettingsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityAccessToDevToolsApi.SetTenantDevToolsAccessSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetTenantDevToolsAccessSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the Developer Tools access settings
    ApiResponse<TenantDevToolsAccessSettingsWrapper> response = apiInstance.SetTenantDevToolsAccessSettingsWithHttpInfo(tenantDevToolsAccessSettingsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SecurityAccessToDevToolsApi.SetTenantDevToolsAccessSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantDevToolsAccessSettingsDto** | [**TenantDevToolsAccessSettingsDto?**](TenantDevToolsAccessSettingsDto?.md) |  | [optional]  |

### Return type

[**TenantDevToolsAccessSettingsWrapper**](TenantDevToolsAccessSettingsWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Developer Tools access settings |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

