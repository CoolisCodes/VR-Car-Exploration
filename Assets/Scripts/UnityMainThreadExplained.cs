using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMainThreadExplained : MonoBehaviour
{
    public GameObject gameObject;

    public int num = 1;
    // Hello 
    public string test;

    /// <summary>
    /// Runs every time the component gets enabled
    /// </summary>
    private void OnEnable()
    {

    }
    /// <summary>
    /// Runs every time the component gets disabled
    /// </summary>
    private void OnDisable()
    {

    }

    /// <summary>
    /// runs at the start of the first frame
    /// </summary>
    private void Awake()
    {

    }

    /// <summary>
    /// runs at the end of the first frame
    /// </summary>
    private void Start()
    {

    }


    /// <summary>
    /// Runs at every frame as fast as the CPU can!!!
    /// </summary>
    private void Update()
    {

    }

    /// <summary>
    /// Runs at every frame at a fixed time step
    /// </summary>
    private void FixedUpdate()
    {

    }
}
