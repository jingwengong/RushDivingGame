using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpell : MonoBehaviour
{
    public GameObject Spell;

    public Transform Target;

    public Transform Player;

    private float Timer;

    public int time;

    private int spawnInterval = 20;

    //private ;

    void Start()
    {
        time = 0;
    }


    void Update()
    {

        time++;

        GameObject go;

        Timer += Time.deltaTime;
        if (Timer >= 0.1f && time % spawnInterval == 0)
        {
            Timer = 0;
            go = createSpell();
        }




    }

    private GameObject createSpell()
    {

        Debug.Log("PRINTING TARGET.POSITION " + Target.position);

        GameObject go = Instantiate(Spell);
        //go.transform.position = (Target.position + Player.position) / 2 + new Vector3(Random.Range(-100f, 100f), 0, Random.Range(-100f, 100f));
        go.transform.position = Target.position;

        go.SetActive(true);

        return go;


    }
}
