using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI : MonoBehaviour
{
    public GUISkin _playerGUISkin;
    public GUIStyle _playerGUIStyle;

    public Texture2D _guiBackground;
    public Texture2D _guiBorder;

    private Texture2D _IShaped;
    private Texture2D _JShaped;
    private Texture2D _LShaped;
    private Texture2D _OShaped;
    private Texture2D _SShaped;
    private Texture2D _TShaped;
    private Texture2D _ZShaped;

    private Texture2D _nextBlockGUI;
    private Texture2D _heldBlockGUI;

    public Texture2D _threeCountdown;
    public Texture2D _twoCountdown;
    public Texture2D _oneCountdown;

    void Start()
    {
        _playerGUISkin = (GUISkin)(Resources.Load("PlayerGUISkin"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHeldBlockGUI()
    {
        UnityEngine.Debug.Log("SetHeldBlockGUI");
    }
    private void OnGUI()
    {
        _playerGUIStyle = _playerGUISkin.label;

        _playerGUIStyle.font = (Font)Resources.Load("Audiowide-Regular");
        _playerGUIStyle.fontSize = Manager._playerGUIFontSize;
        _playerGUIStyle.alignment = TextAnchor.MiddleCenter;
        GUI.contentColor = Color.yellow;

        GUI.BeginGroup(new Rect(0,0,Screen.width, Screen.height));

        GUI.DrawTexture(new Rect(0 + Manager._screenWidthOffset, 0 + Manager._screenHeightOffset,
            Screen.width - (Manager._screenWidthOffset * 2),
            Screen.height - (Manager._screenHeightOffset * 2)), _guiBackground);

        GUI.DrawTexture(new Rect(0 + Manager._screenWidthOffset, 0 + Manager._screenHeightOffset,
            Screen.width - (Manager._screenWidthOffset * 2),
            Screen.height - (Manager._screenHeightOffset * 2)), _guiBorder);

        ////Countdown//
        
       /* if(SpawnBlocks._introCoundownCurrent >2)
        {

        }*/ 
        ///LEFT SIDE////

        GUI.Label(new Rect(0, 0, Screen.width / 4.25f,
            Screen.height / 4.5f), "Next Block", _playerGUIStyle);

        GUI.Label(new Rect(0, 0, Screen.width / 4.25f,
           Screen.height / 1.5f), "Held Block", _playerGUIStyle);

        GUI.Label(new Rect(0, 0, Screen.width / 4.25f,
           Screen.height / 0.8f), "Speed", _playerGUIStyle);

        GUI.Label(new Rect(0, 0, Screen.width / 4.25f,
           Screen.height / 4.5f), "Next Block", _playerGUIStyle);

        GUI.Label(new Rect(0, 0, Screen.width / 4.25f,
           Screen.height / 0.65f), "Lines", _playerGUIStyle);

        ///RiGHT SIDE////

        GUI.Label(new Rect(0, 0, Screen.width / 0.57f,
           Screen.height / 4.5f), "Score", _playerGUIStyle);

        GUI.Label(new Rect(0, 0, Screen.width / 0.57f,
           Screen.height / 0.8f), "Time", _playerGUIStyle);

        GUI.Label(new Rect(0, 0, Screen.width / 0.57f,
           Screen.height / 0.65f), "Hi-Score", _playerGUIStyle);

        GUI.EndGroup();
    }

    //public void SetNextBlockGUI()
    //{
    //    Debug.Log("SetNextBlock");
    //}
}
