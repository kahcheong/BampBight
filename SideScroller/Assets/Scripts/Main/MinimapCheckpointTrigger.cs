using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class MinimapCheckpointTrigger : MonoBehaviour
{
    private bool beenTriggered = false;
    public Image flipImage;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !beenTriggered)
        {
            flipImage.enabled = false;
        }
    }
}