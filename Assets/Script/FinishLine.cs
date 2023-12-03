using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float timeReloadScence = 2f;
    [SerializeField] ParticleSystem particleSystem;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            particleSystem.Play();
            Invoke("ReloadScence", timeReloadScence);
        }
    }

    void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }
}
