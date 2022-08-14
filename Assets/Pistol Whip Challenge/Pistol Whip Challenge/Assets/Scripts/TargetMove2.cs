using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove2 : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;
    public GameController controller;
    // Use this for initialization
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        min = transform.position.y;
        max = transform.position.y + Random.Range(2, 4);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,Mathf.PingPong(Time.time * Random.Range(2, 3), max - min) + min, transform.position.z);
    }

    void Dead()
    {
        this.GetComponent<Rigidbody>().useGravity = true;
        controller.score++;
        Destroy(this.gameObject, 2f);
    }
}
