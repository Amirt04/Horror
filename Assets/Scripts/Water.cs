using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    public float maxWaterLife = 100;
    public float curWaterLife;
    float WaterDrain = 1f;
    public Image waterUI;
    void Start()
    {
        curWaterLife = maxWaterLife;
    }
    void Update()
    {
        if (curWaterLife > 0)
        {
            curWaterLife -= WaterDrain * Time.deltaTime;
        }

        if (curWaterLife <= 0)
        {
            curWaterLife = 0;
        }

        waterUI.transform.localScale = new Vector3(
    curWaterLife / maxWaterLife,
    waterUI.transform.localScale.y,
    waterUI.transform.localScale.z
    );

        if (curWaterLife <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}