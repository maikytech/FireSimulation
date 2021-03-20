using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuttingOutFire : MonoBehaviour
{
    [SerializeField] GameObject fire;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Invoke("OutFire", 4.0f);
        }
    }

    private void OutFire()
    {
        fire.SetActive(false);
    }
}
