using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectile;
    public GameObject cube;
    public Vector3    cubePosition;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
            GameObject[] projectiles = GameObject.FindGameObjectsWithTag("Bomb");
            if (cubes.Length == 1 && projectiles.Length==0)
            {
                Instantiate(projectile, transform.position, projectile.transform.rotation);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");
            GameObject[] projectiles = GameObject.FindGameObjectsWithTag("Bomb");
            if (cubes.Length == 0 && projectiles.Length == 0)
            {
                Instantiate(cube, cubePosition, transform.rotation);
            }
        }
    }
}


