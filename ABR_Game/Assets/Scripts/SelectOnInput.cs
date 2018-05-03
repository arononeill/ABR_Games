using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectedObject;

    private bool buttonSelected;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //checks if movement was detected on the vertical acccess, maybe from keyboard or joystick.
		if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false )
        {
            //causes eventSystem to select one of our buttons
            //Object were going to select is selected Object
            eventSystem.SetSelectedGameObject(selectedObject);

            buttonSelected = true;
        }

	}

    //When gameObject is de-activated 
    private void OnDisable()
    {
        //de-activated the object nothing no longer selected.
        buttonSelected = false;
    }
}  
