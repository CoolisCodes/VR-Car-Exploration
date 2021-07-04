using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroducePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;
    void Start()
    {
        FindObjectOfType<Player>().returnToGame.SetActive(false);
        FindObjectOfType<Player>().playerUI.SetActive(true);
        FindObjectOfType<Player>().linearMovementBehaviour.playerHeight = -11.50f;
        
        
    }
}
