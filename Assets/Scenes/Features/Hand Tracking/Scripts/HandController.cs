using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class HandController : MonoBehaviour
{
    public int fistValue = 0;
    public XRNode handTyp;
    
    

    // Update is called once per frame
    
    void Update()
    {
        // Get the input device
        InputDevice handDevice = InputDevices.GetDeviceAtXRNode(handTyp);
           
        // Check if the trigger button is pressed
        bool triggerValue;
        if (handDevice.TryGetFeatureValue(CommonUsages.triggerButton, out triggerValue) && triggerValue)
        {
            fistValue = 1;
        }
        else
        {
            fistValue = 0;
        }
    }
    }

