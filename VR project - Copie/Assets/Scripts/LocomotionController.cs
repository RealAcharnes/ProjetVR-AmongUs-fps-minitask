using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{

    [SerializeField] private ActionBasedController leftTeleportRay;
    [SerializeField] private ActionBasedController rightTeleportRay;
    [SerializeField] private float activationThreshold = 0.1f;
    [SerializeField] private XRRayInteractor leftInteractorRay;
    [SerializeField] private XRRayInteractor rightInteractorRay;
    public bool EnableLeftTeleport {get; set; } = true;
    public bool EnableRightTeleport {get; set; } = true;


    // Update is called once per frame
    void Update()
    {
        if (leftTeleportRay)
        {
            bool isLeftInteractorRayHovering = leftInteractorRay.TryGetHitInfo(out Vector3 pos, out Vector3 norm, out int index, out bool validTarget);
            leftTeleportRay.gameObject.SetActive(EnableLeftTeleport && CheckIfActivated(leftTeleportRay) && !isLeftInteractorRayHovering);
            
        }
        if (rightTeleportRay)
        {
            bool isRightInteractorRayHovering = rightInteractorRay.TryGetHitInfo(out Vector3 pos, out Vector3 norm, out int index, out bool validTarget);
            rightTeleportRay.gameObject.SetActive(EnableRightTeleport && CheckIfActivated(rightTeleportRay) && !isRightInteractorRayHovering);
        }
    }

    public bool CheckIfActivated(ActionBasedController controller)
    {
        bool isActivated;
        float pression = controller.selectAction.action.ReadValue<float>();
        if (pression >= activationThreshold) isActivated = true;
        else isActivated = false;

        return isActivated;
    }
}
