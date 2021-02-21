using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemisManager : MonoBehaviour
{
    [SerializeField] private Transform container;
    [SerializeField] private float respawnTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in container)
        {  
            if (!child.gameObject.activeSelf){
                StartCoroutine(respawnEnnemie(child));
            }
        }
    }

    private IEnumerator respawnEnnemie(Transform child){
        yield return new WaitForSeconds(respawnTime);
        child.gameObject.SetActive(true);
    }
}
