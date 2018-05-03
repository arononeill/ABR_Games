using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour {

    //need to be public so they can be addreseed by the OnClickEvent
    public void Quit()
    {

    //All this is for platform Compilation
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Appllication.Quit();
#endif
    }
}


