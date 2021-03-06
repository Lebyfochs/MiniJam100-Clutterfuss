using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawner : MonoBehaviour
{
    public GameObject PaperSpawn;
    public Transform SpawnPoint;
    public float SpawnTimer;

    [SerializeField] private List<Transform> SpawnLocations = new List<Transform>();

    ChaosHandler chaos;

    private void Awake()
    {
        chaos = GameObject.Find("ChaosHandlingOBJ").GetComponent<ChaosHandler>();
    }

    void Start()
    {
        SpawnTimer = Random.Range(0.0f, 2.5f);
    }

    
    void Update()
    {
        if (chaos.GameRunning == true)
        {
            var SpawnPos = SpawnLocations[Random.Range(0, SpawnLocations.Count)];

            SpawnTimer += Time.deltaTime;

            if (SpawnTimer >= 5)
            {
                Instantiate(PaperSpawn, SpawnPos.position, Quaternion.identity);
                SpawnTimer = Random.Range(0.0f, 2.0f);
            }
        }

        
    }
}
