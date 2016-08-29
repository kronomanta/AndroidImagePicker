using UnityEngine;

public static class AndroidUtils {

    private static AndroidJavaObject currentActivity
    {
        get
        {
            return new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        }
    }
	
    /// <summary>
    /// Notify the Android system we want to select an image
    /// </summary>
    /// <param name="callbackObjectName">Name of gameobject that handles the response</param>
    /// <param name="callbackMethodName">Name of the callback method on the callback gameobject that handles the response</param>
    public static void SelectImage(string callbackObjectName, string callbackMethodName)
    {
        if (Application.platform != RuntimePlatform.Android)
            return;

        var jc = new AndroidJavaClass("hu.TiborKanyo.AndroidUtils.ImagePickerRouter");
        // Calling a Call method to which the current activity is passed, it initializes the activity
        jc.CallStatic("Call", currentActivity, callbackObjectName, callbackMethodName);
    }
}
