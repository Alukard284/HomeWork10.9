using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBallSpring : MonoBehaviour
{
    [SerializeField] ConfigurableJoint _pinballSpring;
    private float _springReload = 10f;
    void Update()
    {
        SpringTension();
        
    }
    public void SpringTension()
    {
        _springReload -= Time.deltaTime;
        Vector3 targetposition = new Vector3(79.87f, 1.6f, -10f);
        Vector3 startPosition = new Vector3(79.87f, 1.6f, -0.3f);
        ConfigurableJoint joint = _pinballSpring;
        joint.targetPosition = targetposition;
        if(_springReload <= 9f)
        {
            joint.targetPosition = startPosition;
            if(_springReload <= 0)
            {
                _springReload = 10f;
                joint.targetPosition = targetposition;
            }
        }
    }
}
