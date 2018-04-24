using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconFollow : MonoBehaviour
{
	public GameObject podToFollow;
	void Update () 
	{
		this.transform.position = podToFollow.transform.position + new Vector3(0, 0, -10);
	}
}
