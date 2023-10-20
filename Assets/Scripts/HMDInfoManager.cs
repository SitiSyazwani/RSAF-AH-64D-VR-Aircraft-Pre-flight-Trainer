using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

//---------------------------------------------------------------------------------
// Author		: Vincent Goh
// Date  		: 2023-01-12
// Youtube      : https://www.youtube.com/watch?v=UlqdHrfXppo
// Description	: This will check which HMD is available. If not try to use MockHMD.
//				  Simplify for XR2.2 that has most stuff.
//				  Not need in XR2.3 when it is out.
//---------------------------------------------------------------------------------
public class HMDInfoManager : MonoBehaviour 
{
	//===================
	// Private Variables
	//===================
	[SerializeField] GameObject mockSimulator;

	protected void Awake() 
	{
		Debug.Log("Is Device Active: " + XRSettings.isDeviceActive);
		Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);
		

		if (!XRSettings.isDeviceActive)
		{
			Debug.Log("No Headset plugged in");
			mockSimulator.SetActive(true);
		}
		else if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName == "MockHMD Display")
		{
			Debug.Log("Using Mock HMD");
			mockSimulator.SetActive(true);
		}
		else
		{
			Debug.Log("We Have a Headset " + XRSettings.loadedDeviceName);
			mockSimulator.SetActive(false);
		}
		// Lock Mouse Cursor at center of Game Window and hide it. Press ESC to see cursor
		Cursor.lockState = CursorLockMode.Locked;
	}

}
