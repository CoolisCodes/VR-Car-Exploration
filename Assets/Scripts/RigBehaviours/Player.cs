using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float teleportationDleay = 0;

    public Transform target;

    public Teleportation teleportationBehaviour;
    public LinearMovement linearMovementBehaviour;

    public GameObject playerUI;

    private void OnEnable()
    {

    }

    private void Awake()
    {
        teleportationBehaviour = new Teleportation(this.transform);

        linearMovementBehaviour = new LinearMovement(this.transform, transform.GetChild(0));
    }

    public void StartMoving()
    {
        linearMovementBehaviour.SetSpeed(0.002f);
    }

    public void StopMoving()
    {
        linearMovementBehaviour.SetSpeed(0);
    }



    private void Update()
    {
        linearMovementBehaviour.Move();
    }

    public void TeleportToSphere(Transform sphere)
    {
        target = sphere;

        StartCoroutine(WaitToTeleport());
    }


    public IEnumerator WaitToTeleport()
    {
        yield return new WaitForSeconds(teleportationDleay);

        teleportationBehaviour.Teleport(target);
    }
}
