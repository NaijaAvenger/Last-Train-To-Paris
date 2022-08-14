using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;
    // Use this for initialization
    public GameController controller;
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        min = transform.position.x;
        max = transform.position.x + Random.Range(3,5);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * Random.Range(2, 3), max - min) + min, transform.position.y, transform.position.z);
    }

    void Dead()
    {
        this.GetComponent<Rigidbody>().useGravity = true;
        controller.score++;
        Destroy(this.gameObject, 2f);
    }
}