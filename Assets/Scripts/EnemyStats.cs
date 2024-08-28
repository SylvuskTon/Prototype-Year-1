using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public int enemyHP;


    public void TakeDamage(int amount)
    {
        enemyHP -= amount;
        if (enemyHP <= 0)
        {
            Destroy(gameObject);
        }
    }

}
