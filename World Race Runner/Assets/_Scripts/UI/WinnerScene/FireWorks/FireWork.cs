using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class FireWork : MonoBehaviour
{
    private float randomDelay;

    IEnumerator PlayParticleEffect()
    {
        while (true)
        {
            GetComponent<ParticleSystem>().Play();
            yield return new WaitForSeconds(randomDelay);
            GetComponent<ParticleSystem>().Stop();
            yield return new WaitForSeconds(randomDelay);
        }
    }

    private void Awake()
    {
        randomDelay = Random.Range(0.5f, 1.5f);
    }

    void Start()
    {
        StartCoroutine(PlayParticleEffect());
    }
}
