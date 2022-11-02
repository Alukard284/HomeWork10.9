using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlpperLInput : MonoBehaviour
{
    [SerializeField] HingeJoint _flipperSL;


    private JointSpring _springL;

    private void Start()
    {
        _springL = _flipperSL.spring;

    }
    private void Update()
    {
        FlippersPushL();

    }
    public void FlippersPushL()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            _springL.targetPosition = -45f;
            _flipperSL.spring = _springL;
            Debug.Log("input");
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _springL.targetPosition = 0f;
            _flipperSL.spring = _springL;
        }

    }
}
