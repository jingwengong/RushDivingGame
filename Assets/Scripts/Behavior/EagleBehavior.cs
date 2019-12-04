using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleBehavior : MonoBehaviour
{
    private Vector3 moveDir;

    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        moveDir = transform.TransformDirection(Vector3.forward);
        speed = Random.Range(15, 25);
    }

    // Update is called once per frame
    void Update()
    {

        float step = speed * Time.deltaTime;

        transform.position += moveDir * step;
    }
}
