using UnityEngine;
public class BotMovement : MonoBehaviour
{
    [SerializeField] private float movementx;
    [SerializeField] private float movementz;
    private float timer;
    private float orientation;
    public float framerate;
    private int compteur;
    private Transform PlayerTransform;
    [SerializeField] private GameObject player;
    private Vector3 PlayerAngle;
    private Vector3 PlayerMovement;
    
    void Start()
    {
        timer = 0.0f;
        Vector3 playerPosition = transform.position;
        PlayerAngle = transform.rotation.eulerAngles;
        PlayerTransform = player.GetComponent<Transform>();
        orientation = -1;
        if (movementx != 0)
        {
            PlayerAngle = new Vector3(PlayerAngle.x, PlayerAngle.y +90, PlayerAngle.z);
        }
        

    }
    private void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        
        
        if (timer >= framerate)
        {
            if (movementx != 0)
            {
                PlayerAngle = new Vector3(PlayerAngle.x, PlayerAngle.y +180, PlayerAngle.z);
            }


            if (movementz != 0)
            {
                PlayerAngle = new Vector3(PlayerAngle.x, PlayerAngle.y +180, PlayerAngle.z);
            }
            
            PlayerTransform.rotation = Quaternion.Euler(PlayerAngle);
            orientation = -orientation;
            timer -= framerate;
        }
        
        
        transform.position += new Vector3(movementx*orientation*Time.deltaTime, 0f, movementz*orientation*Time.deltaTime);
        

        
        
        
        //transform.position += new Vector3(0, 0, orientation*movement);
        
    }
}