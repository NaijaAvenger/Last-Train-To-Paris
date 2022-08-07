using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public GameObject head;
    public GameObject gameOver;
    public GameController controller;

    private void Awake()
    {
        head.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("bullet"))
        {
            controller.lives -= 1;
            Destroy(other.gameObject);
            if (controller.lives <= 0)
            {
                StartCoroutine(GameOver());
            }
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0);
        head.GetComponent<SphereCollider>().enabled = false;
        gameOver.SetActive(true);

        yield return new WaitForSeconds(2);
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
