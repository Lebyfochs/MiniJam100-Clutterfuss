using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkState : MonoBehaviour, IState
{

    public WorkerAgent worker;
    public GameObject DeskOBJ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Execute()
    {
        worker.navAI.destination = DeskOBJ.transform.position;
        yield return null;
    }
}
