using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colect : MonoBehaviour
{
    private const string Tag = "Player";

    // Start is called before the first frame update
    private void Start()
    {
    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 15, 0) * Time.deltaTime);
    }
    private void OnDestroy()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Tag))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PontosColetados>().points++;
            //other.GetComponent<PontosColetados>().points++;
        }
    }
}
