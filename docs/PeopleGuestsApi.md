# Docspace.Api.PeopleGuestsApi

All URIs are relative to *http://http:*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApproveGuestShareLink**](PeopleGuestsApi.md#approveguestsharelink) | **POST** /api/2.0/people/guests/share/approve | Approve a guest sharing link |
| [**DeleteGuests**](PeopleGuestsApi.md#deleteguests) | **DELETE** /api/2.0/people/guests | Delete guests |

<a id="approveguestsharelink"></a>
# **ApproveGuestShareLink**
> EmployeeFullWrapper ApproveGuestShareLink (EmailMemberRequestDto? emailMemberRequestDto = null)

Approve a guest sharing link

Approves a guest sharing link and returns the detailed information about a guest.

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
    public class ApproveGuestShareLinkExample
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
            var apiInstance = new PeopleGuestsApi(httpClient, config, httpClientHandler);
            var emailMemberRequestDto = new EmailMemberRequestDto?(); // EmailMemberRequestDto? |  (optional) 

            try
            {
                // Approve a guest sharing link
                EmployeeFullWrapper result = apiInstance.ApproveGuestShareLink(emailMemberRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleGuestsApi.ApproveGuestShareLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApproveGuestShareLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve a guest sharing link
    ApiResponse<EmployeeFullWrapper> response = apiInstance.ApproveGuestShareLinkWithHttpInfo(emailMemberRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleGuestsApi.ApproveGuestShareLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailMemberRequestDto** | [**EmailMemberRequestDto?**](EmailMemberRequestDto?.md) |  | [optional]  |

### Return type

[**EmployeeFullWrapper**](EmployeeFullWrapper.md)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Detailed profile information |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |
| **404** | User not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteguests"></a>
# **DeleteGuests**
> void DeleteGuests (UpdateMembersRequestDto? updateMembersRequestDto = null)

Delete guests

Deletes guests from the list and excludes them from rooms to which they were invited.

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
    public class DeleteGuestsExample
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
            var apiInstance = new PeopleGuestsApi(httpClient, config, httpClientHandler);
            var updateMembersRequestDto = new UpdateMembersRequestDto?(); // UpdateMembersRequestDto? |  (optional) 

            try
            {
                // Delete guests
                apiInstance.DeleteGuests(updateMembersRequestDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PeopleGuestsApi.DeleteGuests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGuestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete guests
    apiInstance.DeleteGuestsWithHttpInfo(updateMembersRequestDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PeopleGuestsApi.DeleteGuestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateMembersRequestDto** | [**UpdateMembersRequestDto?**](UpdateMembersRequestDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Basic](../README.md#Basic), [OAuth2](../README.md#OAuth2), [ApiKeyBearer](../README.md#ApiKeyBearer), [asc_auth_key](../README.md#asc_auth_key), [Bearer](../README.md#Bearer), [OpenId](../README.md#OpenId)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Request parameters for deleting guests |  -  |
| **401** | Unauthorized |  -  |
| **403** | No permissions to perform this action |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

