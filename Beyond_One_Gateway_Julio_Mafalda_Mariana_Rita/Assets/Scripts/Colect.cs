using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colect : MonoBehaviour
{

    private const string Tag = "Player";
    private AudioSource som;
    private bool destruir = false;

    // Start is called before the first frame update
    private void Start()
    {
	som = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 15, 0) * Time.deltaTime);
	if (destruir)
	{
		if(!som.isPlaying) Destroy(gameObject);
	}
    }
    private void OnDestroy()
    {
        
    }

    public void TocaSom()
    {
        som.Play();
        destruir = true;
    }
}
