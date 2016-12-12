using UnityEngine;
using System.Collections;

public class UnitySystemInfoTrial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("SystemInfo.deviceModel: " + SystemInfo.deviceModel);
		Debug.Log ("SystemInfo.deviceName: " + SystemInfo.deviceName);
		Debug.Log ("SystemInfo.deviceType: " + SystemInfo.deviceType);
		Debug.Log ("SystemInfo.deviceUniqueIdentifier: " + SystemInfo.deviceUniqueIdentifier);
		Debug.Log ("SystemInfo.operatingSystem: " + SystemInfo.operatingSystem);

		Debug.Log ("Application.bundleIdentifier: " + Application.bundleIdentifier);
		Debug.Log ("Application.platform: " + Application.platform);
		Debug.Log ("Application.productName: " + Application.productName);
		Debug.Log ("Application.systemLanguage: " + Application.systemLanguage);
		Debug.Log ("Application.version: " + Application.version);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
