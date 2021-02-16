using UnityEngine;
public class BotMovement : MonoBehaviour
{
    [SerializeField] private float movement;
    private float timer;
    private float orientation;
    public float framerate;
    private int compteur;
    private Transform PlayerTransform;
    [SerializeField] private GameObject player;
    private Vector3 PlayerAngle;
    void Start()
    {
        timer = 0.0f;
        Vector3 playerPosition = transform.position;
        movement = 0.05f;
        PlayerAngle = transform.rotation.eulerAngles;
        PlayerTransform = player.GetComponent<Transform>();

    }
    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        
        
        if (timer >= framerate)
        {
            PlayerAngle = new Vector3(PlayerAngle.x, PlayerAngle.y + 180, PlayerAngle.z);
            PlayerTransform.rotation = Quaternion.Euler(PlayerAngle);

            timer -= framerate;
        }

        
        
        
        //transform.position += new Vector3(0, 0, orientation*movement);
        
    }
}