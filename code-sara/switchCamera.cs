using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject BirdEyeView;
    public GameObject FirstPersonView;
    public int Manager = 1;

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ChangeCamera();
        }
    }

    public void ChangeCamera()
    {
        GetComponent<Animator>().SetTrigger("Change");
    }

    public void ManageCamera()
    {
        if (Manager == 0)
        {
            SwitchToFirstPersonView();
            Manager = 1;
        } 
        else
        {
            SwitchToBirdEyeView();
            Manager = 0;
        }
    }

    public void SwitchToBirdEyeView()
    {
        BirdEyeView.SetActive(true);
        FirstPersonView.SetActive(false);
    }

    public void SwitchToFirstPersonView()
    {
        BirdEyeView.SetActive(false);
        FirstPersonView.SetActive(true);
    }
}
