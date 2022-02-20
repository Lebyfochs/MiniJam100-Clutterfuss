using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    ChaosHandler chaos;
    float ProjectileSpeed = 4.0f;

    private void Awake()
    {
        chaos = GameObject.Find("ChaosHandlingOBJ").GetComponent<ChaosHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, ProjectileSpeed) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "BackWall")
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Player"))
        {
            
            chaos.Chaos += Random.Range(0.25f, 0.75f);
            Destroy(gameObject);
        }
    }
}
