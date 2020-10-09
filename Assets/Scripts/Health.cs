using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealthLife = 100;
    public float curHealthLife;
    float HealthDrain = 1f;
    public Image healthUI;
    void Start()
    {
        curHealthLife = maxHealthLife;
    }
    void Update()
    {
        if (curHealthLife > 0)
        {
            curHealthLife -= HealthDrain * Time.deltaTime;
        }

        if (curHealthLife <= 0)
        {
            curHealthLife = 0;
        }

        healthUI.transform.localScale = new Vector3(
    curHealthLife / maxHealthLife,
    healthUI.transform.localScale.y,
    healthUI.transform.localScale.z
    );

        if (curHealthLife <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}