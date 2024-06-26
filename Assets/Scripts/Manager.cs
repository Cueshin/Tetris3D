using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static bool _randomBackground;
    public static bool _sequentialBackground;

    public static int _screenWidthOffset;
    public static int _screenHeightOffset;
    public static int _playerGUIFontSize;
    public static float _currentTimerValue;

    public static int _introCountdownMax = 3;

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
        ///test///
        _randomBackground = true;
        _sequentialBackground = false;
        ///test///
        UpdateSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateSettings()
    {
        _screenWidthOffset = (Screen.width / 70);
        _screenHeightOffset = (Screen.width / 40);
        _playerGUIFontSize = (Screen.width / 40);
    }
}
