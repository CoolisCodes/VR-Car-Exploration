using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehaviour : MonoBehaviour
{
    public NavMeshAgent myAgent;
    public float movementDelay = 2;
    public float valueRange = 10;
    public float randomX;
    public float randomY;

    private void Awake()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        StartCoroutine(WaitToAct());
    }

    public void RandomizeValues()
    {
        float randomFloatX = Random.Range(-valueRange, valueRange + 1);
        float randomFloatY = Random.Range(-valueRange, valueRange + 1);

        randomX = randomFloatX;
        randomY = randomFloatY;
    }

    public void ApplyRoatations()
    {
        myAgent.SetDestination(new Vector3(randomX, 0, randomY));
    }

    public IEnumerator WaitToAct()
    {
        while (true)
        {
            RandomizeValues();
            ApplyRoatations();
            yield return new WaitForSeconds(movementDelay);
        }
    }
    
}
