using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBullets : MonoBehaviour
{
    public SimpleShoot rgun;
    public SimpleShoot2 lgun;
    public bool extrabullets = false;

    // Start is called before the first frame update
    void Start()
    {
        lgun = GameObject.FindGameObjectWithTag("lgun").GetComponent<SimpleShoot2>();
        rgun = GameObject.FindGameObjectWithTag("rgun").GetComponent<SimpleShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (extrabullets)
        {
            rgun.maxammo = 20;
            lgun.maxammo = 20;
        }
        else if(!extrabullets)
        {
            rgun.maxammo = 10;
            lgun.maxammo = 10;
        }
    }
    void Dead()
    {
        rgun.currentammo = 20;
        lgun.currentammo = 20;
        this.gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        this.gameObject.GetComponentInChildren<Collider>().enabled = false;
        StartCoroutine(BulletPowerup());
    }

    IEnumerator BulletPowerup()
    {
        yield return new WaitForSeconds(0);
        extrabullets = true;

        yield return new WaitForSeconds(20);
        extrabullets = false;

    }
}
