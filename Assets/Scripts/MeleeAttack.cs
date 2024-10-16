using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{

    public float attackDelay; //delay before attack hits enemy. BIG WEAPON = SLOW
    public Transform weaponTransform; //location of weapon
    public float weaponRange; //raidus of area to check for enemies
    public int weaponDMG; //weapon... damage
    public LayerMask enemyLayer; // script identify enemies from non-targets

    bool canAttack = true;
    public Animator playerAnim;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canAttack == true)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        canAttack = false;
        playerAnim.Play("Player_Attacking");
        Collider2D enemy = Physics2D.OverlapCircle(weaponTransform.position, weaponRange, enemyLayer);
        yield return new WaitForSeconds(attackDelay);
        if (enemy != null)
        {
            enemy.GetComponent<EnemyStats>().TakeDamage(weaponDMG);
          
        }
        canAttack = true;
        
    }
}
