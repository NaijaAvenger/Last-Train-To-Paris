using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameObject head;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("end"))
        {
            StartCoroutine(NextLevel());
        }
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(0);
        head.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
