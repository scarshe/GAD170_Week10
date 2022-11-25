using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public HpScript hpBar;
    public bool poisoned = false;
    public bool healing = false;

    float hpValue = 100f;
    float hpMax = 100f;
    
    public void Update()
    {
        if(poisoned == true)
        {
            TakeDamage(0.05f);
        }

        if(healing == true)
        {
            Heal(0.05f);
        }
    }

    public void TakeDamage(float damage)
    {
        hpValue -= damage;
        hpBar.SetValue(hpValue);
    }

    public void Heal(float heal)
    {
        hpValue += heal;
        hpBar.SetValue(hpValue);
    }
}
