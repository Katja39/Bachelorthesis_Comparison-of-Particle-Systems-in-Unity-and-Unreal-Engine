using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    public GameObject explosionPSPrefab;
    private GameObject explosion;
    void Start()
    {
    }

    void Update()
    { 
    }

    private void OnTriggerEnter(Collider boxCollider)
    {
        explosion = Instantiate(explosionPSPrefab, transform.position, Quaternion.identity);
        StartCoroutine(WaitAndDestroy(explosion, explosion.GetComponent<ParticleSystem>().main.duration+1));
        Destroy(boxCollider.gameObject);
    }

    IEnumerator WaitAndDestroy(GameObject obj, float waitTime)
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(waitTime);
        Destroy(obj);
        Destroy(gameObject);
    }
}


