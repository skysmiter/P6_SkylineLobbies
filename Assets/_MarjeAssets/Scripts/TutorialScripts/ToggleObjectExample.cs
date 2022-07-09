using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleObjectExample : MonoBehaviour
{
    public InputActionReference toggleReference = null;
    public GameObject Infobubble1;
    public GameObject Infobubble2;
    public GameObject Infobubble3;
    public GameObject Paper1;
    public GameObject Paper2;
    public GameObject Paper3;


    //if I don't do that & the player presses button to make infobubble/paper appear b4 the bubble was thrown to wall it doesn't look good
    private float very = 1000f;
    private float far = 1000f;
    private float away = 1000f;





    private void Awake()
    {
        toggleReference.action.started += Toggle1;
        toggleReference.action.started += Toggle2;
        toggleReference.action.started += Toggle3;

    }


    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle1;
        toggleReference.action.started -= Toggle2;
        toggleReference.action.started -= Toggle3;
    }

    private void Toggle1(InputAction.CallbackContext context)
    {
        //bool isActive = !gameObject.activeSelf;
        //gameObject.SetActive(isActive);
        Infobubble1.transform.position = new Vector3(very, far, away); //not even a toggle anymore but I gave up to do it the complicated way
        Paper1.transform.position = new Vector3(very, far, away);
    }

    private void Toggle2(InputAction.CallbackContext context)
    {
        //bool isActive = !gameObject.activeSelf;
        //gameObject.SetActive(isActive);
        Infobubble2.transform.position = new Vector3(very, far, away); //not even a toggle anymore but I gave up to do it the complicated way
        Paper2.transform.position = new Vector3(very, far, away);
    }

    private void Toggle3(InputAction.CallbackContext context)
    {
        //bool isActive = !gameObject.activeSelf;
        //gameObject.SetActive(isActive);
        Infobubble3.transform.position = new Vector3(very, far, away); //not even a toggle anymore but I gave up to do it the complicated way
        Paper3.transform.position = new Vector3(very, far, away);
    }

    //could've done this much easier with tags or layers but meh I don't wanna
}
