using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Minimapbehaviour : MonoBehaviour
{
    public Camera minimapCam;
    private int minimapMode = 0; //0 = small bottom
                                 //1 = big middle
                                 //2 = None
    private Vector4 minimapCamStart;
    private Rect minimapStart;
    private void Start()
    {

        minimapCamStart = new Vector4(minimapCam.rect.x, minimapCam.rect.y, minimapCam.rect.width, minimapCam.rect.height);
        minimapStart = new Rect(minimapCamStart.w, minimapCamStart.x, minimapCamStart.y, minimapCamStart.z);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
            if (minimapMode == 0)
            {
                minimapMode = 1;
                print(minimapMode);
            }
            else if (minimapMode == 1)
            {
                minimapMode = 2;
                print(minimapMode);
            }
            else if (minimapMode == 2)
            {
                minimapMode = 0;
                print(minimapMode);
            }
        }

        switch (minimapMode)
        {
            case 0:
                minimapCam.ResetAspect();
                minimapCam.orthographicSize = 100;
                minimapCam.enabled = true;
                break;
                
                
            case 1:
                minimapCam.ResetAspect();
                minimapCam.enabled = true;
                break;
                
                
            case 2:
                minimapCam.enabled = false;
                break;
        }

    }
}
