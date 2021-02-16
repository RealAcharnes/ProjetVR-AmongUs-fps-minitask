using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonState : MonoBehaviour
{

    [SerializeField] private Button button;
    public bool state = true;

    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchButtonState(){
        state = !state;
        if (state){
            button.GetComponent<Image>().color = Color.green;
        }
        if(!state){
            button.GetComponent<Image>().color = Color.grey;
        }
        Debug.Log(state);
    }

}
