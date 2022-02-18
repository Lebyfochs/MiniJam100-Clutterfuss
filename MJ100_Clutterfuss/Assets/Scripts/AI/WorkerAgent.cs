using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorkerAgent : MonoBehaviour
{

    StateMachine states;
    private WorkState working;
    private MoveState moving;
    private PrintingState printing;
    public NavMeshAgent navAI;

    private void Awake()
    {
        states = GetComponent<StateMachine>();
        working = GetComponent<WorkState>();
        moving = GetComponent<MoveState>();
        printing = GetComponent<PrintingState>();
        navAI = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        states = new StateMachine(working, this);
    }

    void Update()
    {
        
    }
}
