using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectricalTask : MonoBehaviour
{
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;
    [SerializeField] private Button button5;

    [SerializeField] private Light light1;
    [SerializeField] private Light light2;
    [SerializeField] private Light light3;
    [SerializeField] private Light light4;

    //Ici nous essaireons de gérer la task de l'éléctricité :
    // Canvas avec des 5 boutons --> Tout les boutons sont activés = lumières allumées
    // --> Sinon lumières éteintes
    // #### En construction, nous devons nous renseigner sur comment faire ####

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool button1State = button1.GetComponent<buttonState>().state;
        bool button2State = button2.GetComponent<buttonState>().state;
        bool button3State = button3.GetComponent<buttonState>().state;
        bool button4State = button4.GetComponent<buttonState>().state;
        bool button5State = button5.GetComponent<buttonState>().state;

        if (!button1State || !button2State || !button3State || !button4State || !button5State){
            light1.intensity = 0.2f;
            light2.intensity = 0.2f;
            light3.intensity = 0.2f;
            light4.intensity = 0.2f;
        }
        else{
            light1.intensity = 0.9f;
            light2.intensity = 0.5f;
            light3.intensity = 0.5f;
            light4.intensity = 0.2f;
        }
    }
}
