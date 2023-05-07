using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{

   public GameObject tutorial;

    private void Awake()
    {
        Time.timeScale = 0;
    }


   public void UnderstandButton()
    {
        Time.timeScale = 1;
        tutorial.SetActive(false);

    }
}
