using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static float _currentTimerValue;

    public float[] _droptimer = new float[]
    {
        0.2f,
        0.4f,
        0.6f,
        0.8f,
        1.0f,
        1.2f,
        1.4f,
        1.6f,
        1.8f,
        2.0f
    };
    // Start is called before the first frame update
    void Start()
    {
        _currentTimerValue = _droptimer[9];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
