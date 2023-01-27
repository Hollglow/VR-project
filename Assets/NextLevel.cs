using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private GameObject loader;
    private void OnTriggerEnter(Collider other)
    {
        loader = GameObject.Find("LevelLoader");
        loader.GetComponent<LevelLoader>().LoadNextLevel();
    }
}
