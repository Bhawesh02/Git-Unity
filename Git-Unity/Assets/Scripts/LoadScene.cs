using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    int value;

    public void loadScene()
    {
        SceneManager.LoadScene(value);
    }
}
