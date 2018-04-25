using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killMe : MonoBehaviour {

    private void OnEnable()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(8);
        gameObject.GetComponent<ParticleSystem> ().emissionRate = 0;
    }
}
