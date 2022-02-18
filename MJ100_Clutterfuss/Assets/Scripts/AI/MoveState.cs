using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//AI movement code similar to Idle state from previous projects.
//Used for when worker is not at desk working or doing anything important.
public class MoveState : MonoBehaviour, IState
{

    public WorkerAgent worker;
    public float NavRange = 10.0f;
    [SerializeField] private List<Transform> MovPosTrans = new List<Transform>();

    private void Awake()
    {
        worker = GetComponent<WorkerAgent>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public IEnumerator Execute()
    {
        while(true)
        {
            var newPos = MovPosTrans[Random.Range(0, MovPosTrans.Count)];
            worker.navAI.destination = newPos.position;

            while (Vector3.Distance(transform.position, worker.navAI.destination) < 0.5f)
            {
                yield return null;
            }
            yield return new WaitForSeconds(3.0f);
        }
        
    }
}
