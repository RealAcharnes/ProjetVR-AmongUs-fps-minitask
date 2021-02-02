using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandsScript : MonoBehaviour
{
    private InputDevice targetDevice;
    public InputDeviceCharacteristics controllerCharacteristics;
    private GameObject spawnedHandModel;
    [SerializeField] private GameObject handModelPrefab;
    private Animator handAnimator;


    // Start is called before the first frame update
    void Start()
    {
        TryInitialize();
    }

    void TryInitialize()
    {
        List<InputDevice> devices = new List<InputDevice>();

        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        spawnedHandModel = Instantiate(handModelPrefab, transform);
        handAnimator = spawnedHandModel.GetComponent<Animator>();
    }

    void updateHandAnimation() 
    {
        if(targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Trigger", 0f);
        }

        if(targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!targetDevice.isValid)
        {
            TryInitialize();
        }
        else
        {
            updateHandAnimation();
        }
        
    }
}
