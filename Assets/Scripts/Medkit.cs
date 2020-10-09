using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medkit : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UseBattery()
    {
        player.GetComponentInChildren<player>().AddHealth();
        Destroy(gameObject);
    }

    void Update()
    {

    }
}