using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAndDie : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject mainMenuButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameOverPanel.SetActive(true);
            mainMenuButton.SetActive(true);
            Destroy(collision.gameObject); //kill player bye bye
        }
    }
}
