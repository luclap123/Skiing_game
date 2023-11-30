using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Detection : MonoBehaviour
{
    [SerializeField] float timeReloadScence = 2f;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            // Debug.Log("you lose");
            Invoke("ReloadScence", timeReloadScence);
        }
    }

    void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }
}
