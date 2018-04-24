using UnityEngine;
using System.Collections;
public class moth : MonoBehaviour
{

    public GameObject source;
    public GameObject vivi;
    private float dist;
    public Hover move;
    public succ soul;
    public AudioSource grapefruit;
    private bool startSucc = true;

    private float x, y;

    private void Start()
    {
        x = move.xamplitude;
        y = move.yamplitude;
        soul = source.GetComponent<succ>();
    }

    private void Update()
    {
        dist = Vector3.Distance(source.transform.position, gameObject.transform.position);

        if (dist < 5f)
        {
            if (startSucc)
            {
                grapefruit.Play();
                AudioFadeIn.FadeIn(grapefruit, 0.5f, 1);
                startSucc = false;
            }
            soul.moth = gameObject;
            source.GetComponent<ParticleSystem>().emissionRate = 100;
            if (vivi.GetComponent<Vivi>().juice > 0) vivi.GetComponent<Vivi>().juice -= 1.0f / 6.0f; ;
        }
        else
        { 
            source.GetComponent<ParticleSystem>().emissionRate -= 5;  
            if (!startSucc)
            {
                AudioFadeOut.FadeOut(grapefruit, 0.5f);
                startSucc = true;
            }
        }
    }


}