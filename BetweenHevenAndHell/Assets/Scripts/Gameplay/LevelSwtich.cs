using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwtich : MonoBehaviour
{
    public GameObject heavenLevel;
    public GameObject hellLevel;
    private bool heaven;
    void Start()
    {
        heaven = false;
        hellLevel.SetActive(true);
        heavenLevel.SetActive(false);
    }

    // Update is called once per frame
    public void SwitchLevel()
    {
        if (heaven)
        {
            heaven = false;
            hellLevel.SetActive(true);
            heavenLevel.SetActive(false);
        }
        else
        {
            heaven = true;
            heavenLevel.SetActive(true);
            hellLevel.SetActive(false);
        }
    }
}
