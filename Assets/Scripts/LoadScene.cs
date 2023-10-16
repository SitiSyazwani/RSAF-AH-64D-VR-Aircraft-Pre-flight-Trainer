using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DentedPixel;

//---------------------------------------------------------------------------------
// Author		: Yeo Siok Chin Jazlyn
// Date  		: 2022-11-11
// Description	: This is where you write a summary of what the role of this file.
//---------------------------------------------------------------------------------

public class LoadScene : MonoBehaviour
{
	#region Variables
	//===================
	// Public Variables
	//===================

	// public string sceneName;
	public int LoadTime = 2;
	public FadeCamera _fadeCamera;
	public SplashMenuLT _splashScreen;

	#endregion

	#region Own Methods

	// private void OnTriggerEnter(Collider other)
	// {

	// 	if (other.gameObject.tag == "hand")
	// 	{
	// 		Debug.Log("Collision Detected");
	// 		SceneManager.LoadScene(sceneName);

	// 	}
	// }
	// public void LoadMyScene(string sceneName)
	// {
	// 	Debug.Log("sceneName to load: " + sceneName);
	// 	SceneManager.LoadScene(sceneName);
	// }

	public void LoadMyScene()
	{
		//_splashScreen.FadeMenu();
		//_fadeCamera.FadeOutCam();
		StartCoroutine(LoadingScene(SceneManager.GetActiveScene().buildIndex + 1));
	}

	IEnumerator LoadingScene(int loadingIndex)
	{
		yield return new WaitForSeconds(LoadTime);
		SceneManager.LoadScene(loadingIndex);
	}

	#endregion
}
