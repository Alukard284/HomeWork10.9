using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTrap : MonoBehaviour
{
    [SerializeField] ConfigurableJoint _springtrap;
    private float trapReload = 4f;
   

    // Update is called once per frame
    void Update()
    {
        SpringTarapReload();
    }
    private void SpringTarapReload()
    {
        trapReload -= Time.deltaTime;
        Vector3 startPosition = new Vector3 (0f, 0f, 0f);
        Vector3 targetPosition = new Vector3 (25f, 0f, 0f);
        ConfigurableJoint joint = _springtrap;
        if(trapReload <= 4f)
        {
            joint.targetPosition = startPosition;
            if(trapReload <= 0f)
            {
                trapReload = 4f;
                joint.targetPosition = targetPosition;
            }
        }
    }
}
