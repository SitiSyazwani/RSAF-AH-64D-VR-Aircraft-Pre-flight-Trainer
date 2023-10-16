//#define LOG_TRACE_INFO
//#define LOG_EXTRA_INFO

using UnityEngine;
using System.Collections;

//---------------------------------------------------------------------------------
// Author		: XXX
// Date  		: 2015-05-12
// Modified By	: YYY
// Modified Date: 2015-05-12
// Description	: This is where you write a summary of what the role of this file.
//---------------------------------------------------------------------------------
public class AppQuit : MonoBehaviour 
{
    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.tag == "hand")
    //     {
    //         UnityEditor.EditorApplication.isPlaying = false;

    //         Application.Quit();
    //     }
    // }
    public void QuitGame() 
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
        Debug.Log("Quit");
    }

}
