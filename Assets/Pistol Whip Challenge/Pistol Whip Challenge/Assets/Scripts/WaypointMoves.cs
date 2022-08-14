using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointMoves : MonoBehaviour
{
    public Transform[] checkpoints;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private bool waiting;
    private WaitForSecondsRealtime wait;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        wait = new WaitForSecondsRealtime(1);
        StartCoroutine(GotoNextPoint());
    }

    IEnumerator GotoNextPoint()
    {
        if (checkpoints.Length == 0)
            yield break;

        waiting = true;

        yield return wait;

        waiting = false;

        agent.destination = checkpoints[destPoint].position;

        destPoint = (destPoint + 1) % checkpoints.Length;
    }

    private void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f && !waiting)
            StartCoroutine(GotoNextPoint());
    }
}
