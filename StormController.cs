using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class StormController : MonoBehaviour
{
    public float duration = 10.0f;

    public ParticleSystem rainParticleSystem;

    public float currentStrength; 
    private Coroutine stormCoroutine;

    public void Start() {
        rainParticleSystem.Stop();
    }
    public IEnumerator WaitAndStartStorm(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartStorm();
    }

    public void StartStorm()
    {
        if (!GameManager.isStormStarted)
        {
            return;
        }

        if (rainParticleSystem != null)
        {
            var emission = rainParticleSystem.emission;
            emission.rateOverTime = currentStrength*20;
            rainParticleSystem.Play();
        }
    }

    public void StopStorm()
    {
        if (stormCoroutine != null)
        {
            StopCoroutine(stormCoroutine);
            stormCoroutine = null;

            if (rainParticleSystem != null)
            {
                rainParticleSystem.Stop();
            }
        }
    }


}
