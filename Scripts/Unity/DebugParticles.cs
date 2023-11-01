using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugParticles : MonoBehaviour
{
    private ParticleSystem ps; 

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        Debug.Log("Particles alive count: " + GetAliveParticles());
    }

    int GetAliveParticles()
    {
        ParticleSystem.Particle[] particles = new ParticleSystem.Particle[ps.particleCount];
        return ps.GetParticles(particles);
    }
}

