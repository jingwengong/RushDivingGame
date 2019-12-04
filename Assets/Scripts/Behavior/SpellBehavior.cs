﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class SpellBehavior : MonoBehaviour
{
    public AudioSource collisionSource;

    public Transform Player;

    public Vector3 targetPos;

    public bool metPlayer = false;

    private Vector3 moveDir;

    private float travelledDistance;

    private float maxFlyRange = 5000; // hardcoded, might be modified when we adjust starting position

    private float velocity = 550f;

    private void Start()
    {

        float accuracy = Random.Range(0f, 100f);
        Debug.Log("AIMING PLAYER " + Player.position);
        if (accuracy < 30)
        {
            targetPos = Player.position;


        }
        else
        {
            targetPos = Player.position + new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
        }

        
        
        moveDir = (targetPos - transform.position).normalized;
        travelledDistance = 0;


    }

    private void Update()
    {
        //transform.LookAt(targetPos);


        //transform.Translate(Vector3.forward * Time.deltaTime * 700, Space.Self);

        float step = velocity * Time.deltaTime; // calculate distance to move

        transform.position += moveDir * step;

        Debug.Log("Current Position: " + transform.position);

        travelledDistance += step;
        if (travelledDistance > maxFlyRange)
        {
            Debug.Log("DESTRYING " + travelledDistance);
            Destroy(this.gameObject);
        }

        //transform.position = Vector3.MoveTowards(transform.position, targetPos, step);


        //Debug.Log( "THE DISTANCE " +  Vector3.Distance(this.transform.position, Player.transform.position));

        //if (Vector3.Distance(this.transform.position, Player.transform.position) < 20)
        //{
        //    metPlayer = true;
        //}

        //if (metPlayer == true && Vector3.Distance(this.transform.position, Player.transform.position) > 400)
        //{
        //    Debug.Log("DESTROYING RSPELL.");
        //    Destroy(this);
        //}


    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDING");
        Debug.Log("THE DISTANCE " + Vector3.Distance(this.transform.position, Player.transform.position));
        Debug.Log(other.name);
        if (other.name == "Player")
        {

            Debug.Log("You die.");
            //Menu.isDead = true;
        }

    }
}
