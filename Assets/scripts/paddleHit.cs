using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleHit : MonoBehaviour
{
    float restPosition = 0f;
    float pressedPosition = 45f;
    float flipperStrength = 25000f;
    float flipperDamper = 150f;
    public string InputName;
    HingeJoint joint;
    
    

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        JointLimits jlimits = new JointLimits();
        spring.spring = flipperStrength;
        spring.damper = flipperDamper;
        jlimits.max = 45F;
        jlimits.min = -45F;


        if (Input.GetAxis(InputName) == 1)
        {
            spring.targetPosition = pressedPosition;
        } else
        {
            spring.targetPosition = restPosition;
        }
        
        
        joint.limits = jlimits;
        joint.spring = spring;

    }
}
