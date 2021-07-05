using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SoundManager))]
[RequireComponent(typeof(SceneManagement))]
public class GameManager : MonoBehaviour
{

    public List<GameObject> indestructables = new List<GameObject>();

    private void Awake()
    {
        DontDestroyOnLoad(this);

        foreach (GameObject indestructable in indestructables)
        {

            DontDestroyOnLoad(indestructable);
        }
    }

    private void Start()
    {

        GetComponent<SoundManager>().Play("dion");
    }

    public void RestartGame()
    {
        foreach (GameObject indestructable in indestructables)
        {
            Destroy(indestructable);
        }

        Destroy(gameObject);
    }

    public void StopGame()
    {
        Application.Quit();
        Debug.Log("Game Succefully Ended.!");
    }
}
