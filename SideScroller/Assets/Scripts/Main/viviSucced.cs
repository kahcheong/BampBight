using UnityEngine;
using System.Collections;

public class viviSucced : MonoBehaviour
{
    public GameObject[] Target;

    private ParticleSystem system;

    private static ParticleSystem.Particle[] particles = new ParticleSystem.Particle[1000];

    int count;

    void Start()
    {
        if (system == null)
            system = GetComponent<ParticleSystem>();

        if (system == null)
        {
            this.enabled = false;
        }
        else
        {
            system.Play();
        }
    }
    void Update()
    {
        if (Target != null)
        {
            count = system.GetParticles(particles);

            for (int i = 0; i < count; i++)
            {
                ParticleSystem.Particle particle = particles[i];
               
                Vector3 v1 = system.transform.TransformPoint(particle.position);
                Vector3 v2 = system.transform.TransformPoint(Target[0].transform.position);
                float dist = Vector3.Distance(v1, v2);

                for (int j = 1; j < Target.Length; j++)
                {
                    Vector3 v3 = system.transform.TransformPoint(Target[j].transform.position);
                    float check = Vector3.Distance(v1, v3);

                    if (check < dist)
                    {
                        v2 = v3;
                        dist = Vector3.Distance(v1, v2);
                    }
                    
                }
                dist = Vector3.Distance(v1, v2);
                if (dist < 0.28f)
                {
                    Vector3 tarPosi = (v2 - v1) * (particle.remainingLifetime / particle.startLifetime);
                    particle.position = system.transform.InverseTransformPoint(v2 - tarPosi);
                    particles[i] = particle;
                }
            }

            system.SetParticles(particles, count);
        }
    }
}