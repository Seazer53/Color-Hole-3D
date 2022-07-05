using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckTrigger : MonoBehaviour
{
    private int collectedLoot = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Loot"))
        {
            collectedLoot++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            collectedLoot = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (collectedLoot == 10)
            {
                collectedLoot = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (collectedLoot == 21)
            {
                collectedLoot = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (collectedLoot == 50)
            {
                collectedLoot = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
