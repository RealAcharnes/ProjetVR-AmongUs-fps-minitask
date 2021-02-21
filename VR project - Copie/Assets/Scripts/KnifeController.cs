using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
     private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
