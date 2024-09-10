using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;




public class Skybox_Manager : MonoBehaviour
{

    public Material[] _skyboxes;
    public int _index;

    public int _sequentialCurrentValue;
    public int _sequentialMaxValue;

    public int _backgroundButtonTimerMax = 1;
    public float _backgroundButtonTimerCurrent;

    public bool _needToSetSkyBox;

    // Start is called before the first frame update
    void Start()
    {
       _backgroundButtonTimerCurrent = 0;
        _needToSetSkyBox = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (_needToSetSkyBox == true && Manager._randomBackground == true)
            SetSkyBox();

        if (_needToSetSkyBox == true && Manager._randomBackground != true)
            _needToSetSkyBox = false;

        if (_backgroundButtonTimerCurrent !=0)
            _backgroundButtonTimerCurrent -= 1 
                * Time.deltaTime;
        if (_backgroundButtonTimerCurrent < 0)
            _backgroundButtonTimerCurrent = 0;
          
    }

    void SetSkyBox()
    {
        UnityEngine.Debug.Log("SetSkyBox");

        if(Manager._randomBackground == true)
        {
            for (_index = 0; _index < _skyboxes.Length; _index++) ;

            RenderSettings.skybox = _skyboxes[UnityEngine.Random.Range(0, _skyboxes.Length)];

            _needToSetSkyBox = false;
        }
    }

}
