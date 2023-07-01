using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonescontrol : MonoBehaviour
{
    private GameObject[] zone;
     public int see = 1;
  
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

        zone = GameObject.FindGameObjectsWithTag("Zones");
       

            if (see == 1){
                foreach (var obj in zone)
                    {
                        obj.GetComponent<Renderer>().enabled = true;
                see = 0;
                    }
            } else {
                foreach (var obj in zone)
                {
                     obj.GetComponent<Renderer>().enabled = false;
                see = 1;
                }
            }
        }
    }

