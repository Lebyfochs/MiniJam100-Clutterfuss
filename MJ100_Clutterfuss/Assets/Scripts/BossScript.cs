using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
   
    [SerializeField] private float BossSpeed = 3.0f;
    public GameObject Projectile;
    public Transform ThrowLocation;

    private float ThrowTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * BossSpeed, 5) - 2.5f, transform.position.y, transform.position.z);
        ThrowTimer += Time.deltaTime;
        if (ThrowTimer >= 4)
        {
            Instantiate(Projectile, ThrowLocation.position, Quaternion.identity);
            ThrowTimer = 0;
        }
        
    }
}
