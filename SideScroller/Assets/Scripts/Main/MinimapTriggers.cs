using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapTriggers : MonoBehaviour 
{

	private bool beenTriggered = false;
    
	[SerializeField]
	public Image flipImage;
    
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && !beenTriggered)
		{
			beenTriggered = !beenTriggered;
			flipImage.enabled = false;
		}
	}
}
