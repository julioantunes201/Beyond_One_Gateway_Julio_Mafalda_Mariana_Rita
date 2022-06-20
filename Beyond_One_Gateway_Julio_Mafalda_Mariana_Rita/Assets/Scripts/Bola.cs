using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float lifeTime = 10f;
    public bool inWindZone = false;
    public GameObject windZone;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                Destruction();
            }
        }
        if (this.transform.position.y <= -20)
        {
            Destruction();
        }
    }

    private void FixedUpdate()
    {
        if (inWindZone)
        {
            rb.AddForce(windZone.GetComponent<windarea>().direction * windZone.GetComponent<windarea>().strenght);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "WindArea")
        {
            windZone = coll.gameObject;
            inWindZone = true;
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.tag == "WindArea")
        {
            if(coll.gameObject.tag == "WindArea")
            {
                inWindZone = false;
            }
        }
    }
    private void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.name == "destroyer")
        {
            Destruction();
        }
    }
    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
