using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAndDie : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject); //kill player bye bye
    }
}
