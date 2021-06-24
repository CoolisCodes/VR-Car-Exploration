using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestAgent : MonoBehaviour
{
    public Transform toGoTo;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent>();

        navMeshAgent.SetDestination(toGoTo.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
