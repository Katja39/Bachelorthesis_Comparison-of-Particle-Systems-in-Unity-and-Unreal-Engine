using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(-90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 10);
    }
}


