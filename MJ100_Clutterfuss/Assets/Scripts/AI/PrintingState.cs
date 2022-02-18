using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintingState : MonoBehaviour, IState
{
    public WorkerAgent worker;
    public GameObject PrinterOBJ;

    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public IEnumerator Execute()
    {
        worker.navAI.destination = PrinterOBJ.transform.position;
        yield return null;
    }
}
