using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float speed = 40;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform barrel;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    public void Fire()
    {
        GameObject spawnedBullet = (GameObject) Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().AddForce(speed * barrel.forward);
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnedBullet, 3);
    }
}
