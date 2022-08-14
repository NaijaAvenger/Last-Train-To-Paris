using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            StartCoroutine(PowerUpIntro());
        }
        else
        transform.position += Time.deltaTime * new Vector3(0, 0, 2);
    }

    IEnumerator PowerUpIntro()
    {
        yield return new WaitForSeconds(5);
        transform.position += Time.deltaTime * new Vector3(0, 0, 2);
    }
}
