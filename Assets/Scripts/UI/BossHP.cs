using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHP : MonoBehaviour
{

    [SerializeField] private Health health;
    public Text textHP;

    // Update is called once per frame
    void Update()
    {
        textHP.text = health.currentHealth.ToString();
    }
}
