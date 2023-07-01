using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{

    public GameObject Overlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void WhenButtonClicked()
    {
        if(Overlay.activeInHierarchy == true)
            Overlay.SetActive(false);
        else
            Overlay.SetActive(true);
    }
}
