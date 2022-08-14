using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public Collider character;
    public GameObject shield;

    // Start is called before the first frame update
    void Start()
    {
        shield = GameObject.FindGameObjectWithTag("shield");
        shield.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Dead()
    {
        if (character.enabled == true)
        {
            character.enabled = false;
            shield.GetComponent<SpriteRenderer>().enabled = true;
            this.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
            this.gameObject.GetComponentInChildren<Collider>().enabled = false;
            StartCoroutine(ShieldPowerUp());
        }
        else
        {
            this.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
            this.gameObject.GetComponentInChildren<Collider>().enabled = false;
        }
    }

    IEnumerator ShieldPowerUp()
    {
        yield return new WaitForSeconds(5);
        character.enabled = true;
        shield.GetComponent<SpriteRenderer>().enabled = false;
    }
}
