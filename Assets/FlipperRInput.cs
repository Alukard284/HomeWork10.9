using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperRInput : MonoBehaviour
{
    [SerializeField] HingeJoint _flipperR;
    private JointSpring _springR;
    void Start()
    {
        _springR = _flipperR.spring;
    }

    
    void Update()
    {
        FlippersPushR();
    }
    public void FlippersPushR()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            _springR.targetPosition = 45;
            _flipperR.spring = _springR;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            _springR.targetPosition = 0f;
            _flipperR.spring = _springR;
        }
    }
}
