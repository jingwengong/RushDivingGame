using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenomSpellBehavior : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDING LANDING MARK");
        
        Debug.Log(other.name);
        if (other.name == "Player")
        {

            Debug.Log("You die.");
            Menu.isWinner = true; //Y: 150
        }

    }
}
