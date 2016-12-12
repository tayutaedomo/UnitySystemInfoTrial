using UnityEngine;
using System.Collections;

public class UnitySystemInfoTrial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Application.platform: " + Application.platform);

		Debug.Log ("SystemInfo.deviceType: " + SystemInfo.deviceType);
		Debug.Log ("SystemInfo.operatingSystem: " + SystemInfo.operatingSystem);
		Debug.Log ("SystemInfo.deviceUniqueIdentifier: " + SystemInfo.deviceUniqueIdentifier);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
