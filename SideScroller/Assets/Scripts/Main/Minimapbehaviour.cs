using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Minimapbehaviour : MonoBehaviour
{
    public Camera minimapCam;
    private int minimapMode = 0; //0 = small bottom
                                 //1 = big middle
                                 //2 = None
    
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (minimapMode == 0)
            {
                minimapMode = 1;
            }
            if (minimapMode == 1)
            {
                minimapMode = 2;
            }
            if (minimapMode == 2)
            {
                minimapMode = 0;
            }
            
            switch (minimapMode)
            {
                case 0:
                    minimapCam.orthographicSize = 80;
                    break;
                
                
                case 1:
                    minimapCam.orthographicSize = 250;
                    minimapCam.rect = Camera.main.rect;
                    break;
                
                
                case 2:
                    minimapCam.enabled = false;
                    break;
            }
        }
    }
}
