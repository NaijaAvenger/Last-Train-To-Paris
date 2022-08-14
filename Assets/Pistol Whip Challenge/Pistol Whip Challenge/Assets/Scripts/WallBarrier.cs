using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WallBarrier : MonoBehaviour
{
    public float lives = 5f;
    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        lives = Random.Range(4, 8);
        livesText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = lives.ToString();
        if (lives <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

    void Dead()
    {
        lives -= 1;
    }
}
