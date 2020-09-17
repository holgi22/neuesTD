using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zieleinlauf : MonoBehaviour {

    public GameObject panel;
    public int angekommen = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            angekommen++;
            if (angekommen > 2)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
