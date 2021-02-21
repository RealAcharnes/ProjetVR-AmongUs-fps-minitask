using System.Collections;
using UnityEngine;
public class BotMovement : MonoBehaviour
{
    private float movementz = -2f;
    [SerializeField] private float speed = 1f;
    private float timer;
    [SerializeField] private float movementTime = 3f;
    [SerializeField] private GameObject player;
    private Transform PlayerTransform;
    

    void Start()
    {
        timer = 0.0f;
        PlayerTransform = player.transform;
       
    }
    private void Update()
    {
        
        timer += Time.deltaTime;
        PlayerTransform.position += PlayerTransform.forward * movementz * speed * Time.deltaTime;

        if (timer >= movementTime){
            PlayerTransform.Rotate(new Vector3(0f, 180f, 0f));
            timer -= movementTime;
        }
        
    }
}