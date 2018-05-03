using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;
	
	// Update is called once per frame
	void Update () {

        //Constantly monitoring to see if we are pressing the Viewmode key
		if(Input.GetButtonDown ("Viewmode"))
        {

            //if its = to 2 then sets back to 0
            if(CamMode == 2)
            {
                CamMode = 0;
            }

            //if not 3 then it adds 1 to the CamMode
            else
            {
                CamMode += 1;
            }
            StartCoroutine(ModeChange());

        }
	}

    IEnumerator ModeChange()
    {
        //waits for tenth of a second before camera change
        yield return new WaitForSeconds(0.01f);

        //if = 0 Turns on the normal cam
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }

        //Turns on the FarCam and disables the NormalCam
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }

        //turns on the FPCam and deactivates the FarCam
        if (CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }


    }
}
