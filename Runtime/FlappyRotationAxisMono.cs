using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyRotationAxisMono : MonoBehaviour
{

    public Transform m_whatToRotate;
    public bool m_isRotatingRequested = true;
    public Vector3 m_rotateAxis= Vector3.right;
    public Space m_spaceToRotate= Space.Self;
    public float m_angleSpeedRotation=180;


    void Reset()
    {
        m_whatToRotate = transform;
    }

    void Update()
    {
        if (m_isRotatingRequested) {

            m_whatToRotate.Rotate(m_rotateAxis, m_angleSpeedRotation*Time.deltaTime, m_spaceToRotate);
        }
    }
}
