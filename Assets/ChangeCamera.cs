using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeCamera : MonoBehaviour
{
    public GameObject cameraWide;
    public GameObject cameraCloseUp;
    public GameObject cameraMidRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetKeyDown("w"))
        {
            cameraWide.SetActive(true);
            cameraCloseUp.SetActive(false);
            cameraMidRange.SetActive(false);
        }

        if (Input.GetKeyDown("c"))
        {
            cameraWide.SetActive(false);
            cameraCloseUp.SetActive(true);
            cameraMidRange.SetActive(false);
        }

        if (Input.GetKeyDown("m"))
        {
            cameraWide.SetActive(false);
            cameraCloseUp.SetActive(false);
            cameraMidRange.SetActive(true);
        }
    }

}


