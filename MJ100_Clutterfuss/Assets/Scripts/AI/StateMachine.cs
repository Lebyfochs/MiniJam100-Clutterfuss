using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//State machine used in previous projects.

public interface IState
{
    public IEnumerator Execute();
}



public class StateMachine : MonoBehaviour
{

    IState CurrentState;

    WorkerAgent worker;

    Coroutine coroutine;

    public StateMachine(IState state, WorkerAgent agent)
    {
        CurrentState = state;
        this.worker = agent;
        
    }

    public void ChangeState(IState NewState)
    {
        if(coroutine!=null)
        {
            worker.StopCoroutine(coroutine);
            coroutine = null;
        }
        
        coroutine = worker.StartCoroutine(CurrentState.Execute());
    }

}
