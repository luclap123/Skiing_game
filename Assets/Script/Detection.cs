using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Detection : MonoBehaviour
{
    [SerializeField] float timeReloadScence = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip sound;
    bool hasCrash = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player" && !hasCrash) {
            // GetComponent<Controller>().disableControl();
            hasCrash = true;
            FindObjectOfType<Controller>().disableControl();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(sound);
            Invoke("ReloadScence", timeReloadScence);
        }
    }

    void ReloadScence()
    {
        SceneManager.LoadScene(0);
    }
}
