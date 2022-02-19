using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperScript : MonoBehaviour
{

    ChaosHandler chaos;

    private void Awake()
    {
        //This is helpful, use this when you want to set reference without inspector(?).
        chaos = GameObject.Find("ChaosHandlingOBJ").GetComponent<ChaosHandler>();
    }

    void Start()
    {
        chaos.Chaos += Random.Range(0.75f, 2.0f);
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            chaos.PaperNum += 1;
            chaos.Chaos -= Random.Range(0.5f, 1.25f);
        }
    }
}
