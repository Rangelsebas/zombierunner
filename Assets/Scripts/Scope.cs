using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    public GameObject playerCam;
    public GameObject sniperScope;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            playerCam.GetComponent<Camera>().fieldOfView = 30; 
            sniperScope.SetActive(true);
        }

        if (Input.GetMouseButtonUp(1))
        {
            playerCam.GetComponent<Camera>().fieldOfView = 90; 
            sniperScope.SetActive(false);
        }
    }
}
