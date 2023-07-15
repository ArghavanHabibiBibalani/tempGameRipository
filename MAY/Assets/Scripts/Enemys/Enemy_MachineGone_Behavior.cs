using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_MachineGone_Behavior : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPos;

    private float timer;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

   
    void Update()
    {
        float distance = Vector2.Distance(transform.position , player.transform.position);

        if(distance < 10)
        {
            timer += Time.deltaTime;
            if(timer > 2)
            {
                timer = 0;
                shot();
            }
        }
        
    }

    private void shot()
    {
        Instantiate(bullet , transform.position, Quaternion.identity);
    }
}
