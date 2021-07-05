using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<SoundManager>().AddOrigin(gameObject, "Hello_F_A");

    }

    public void GreetPlayer()
    {
        GetComponent<AudioSource>().Play();
    }
}
