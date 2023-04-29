using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
        }else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        } else if (life < 3)
        {
            Destroy(hearts[3].gameObject);
        }
    }
    public void TakeDamage(int d)
    {
        life -= d;
    }
    
}
