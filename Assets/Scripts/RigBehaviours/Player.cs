using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float teleportationDleay = 0;

    public Transform target;

    public Teleportation teleportationBehaviour;

    private void Awake()
    {
        teleportationBehaviour = new Teleportation(this.transform);
    }

    private void Start()
    {
        SoundManager soundManager = FindObjectOfType<SoundManager>();

        soundManager.Play("KeyPress");

    }

    public void TeleportToSphere(Transform sphere)
    {
        target = sphere;

        StartCoroutine(WaitToAct());
    }


    public IEnumerator WaitToAct()
    {
        yield return new WaitForSeconds(teleportationDleay);

        teleportationBehaviour.Teleport(target);
    }
}
