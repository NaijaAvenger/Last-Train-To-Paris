using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Dead()
    {
        if(controller.lives <5)
        {
            controller.lives = 5;
        }
        if(controller.lives >=5 && controller.lives <8)
        {
            controller.lives = 8;
        }

        this.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        this.gameObject.GetComponentInChildren<Collider>().enabled = false;
    }
}
