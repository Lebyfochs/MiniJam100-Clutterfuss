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

    //For when AI is at the printer.
    //Goes there and collects paper, may drop some for player to pick up.
    //Adds to chaos level?
    public int paper;

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
