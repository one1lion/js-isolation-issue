using Microsoft.JSInterop;

namespace JsIsolationIssue.JsInterop;

public static class FullAppInterop
{
    public static ValueTask DoAlertAsync(this IJSRuntime jsRuntime, string message) 
        => jsRuntime.InvokeVoidAsync("fullAppFuncs.doAlert", message);
}
