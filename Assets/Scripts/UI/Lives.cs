using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    [SerializeField] private Health health;
    public GameObject lives1;
    public GameObject lives2;
    public GameObject lives3;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (health.currentLives == 3)
        {
            lives1.SetActive(true);
            lives2.SetActive(true);
            lives3.SetActive(true);
        }
        else if (health.currentLives == 2)
        {
            lives1.SetActive(true);
            lives2.SetActive(true);
            lives3.SetActive(false);
        }
        else if (health.currentLives == 1)
        {
            lives1.SetActive(true);
            lives2.SetActive(false);
            lives3.SetActive(false);
        }
        else if (health.currentLives == 0)
        {
            lives1.SetActive(false);
            lives2.SetActive(false);
            lives3.SetActive(false);
        }
    }
}
