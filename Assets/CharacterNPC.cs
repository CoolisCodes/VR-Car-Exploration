using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNPC : MonoBehaviour
{
    // Start is called before the first frame update
    public string soundName;
    private Animator anim;
    public string AnimName;
    void Start()
    {

        FindObjectOfType<SoundManager>().AddOrigin(gameObject, soundName);
        anim = GetComponent<Animator>();
    }

    public void GreetPlayer()
    {
        GetComponent<AudioSource>().Play();
        if (anim != null)
        {
            anim.Play(AnimName);
        }
    }
}
