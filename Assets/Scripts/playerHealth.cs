using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int hearts = 3;
    public int maxHearts = 3;
    [SerializeField] public HealthSystem hs;

    public void Start()
    {
        hs.DrawHearts(hearts, maxHearts);
    }

    public void DamagePlayer(int dmg)
    {
        if (hearts > 0)
        {
            hearts -= dmg;
            hs.DrawHearts(hearts, maxHearts);
        }
    }
    
}
