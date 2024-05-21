using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGUI : MonoBehaviour
{
    public GUISkin _playerGUISkin;
    public GUIStyle _playerGUIStyle;

    public Texture2D _guiBorder;
    // Start is called before the first frame update
    void Start()
    {
        _playerGUISkin = (GUISkin)(Resources.Load("PlayerGUISkin"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        _playerGUIStyle = _playerGUISkin.label;

        _playerGUIStyle.font = (Font)Resources.Load("Audiowide-Regular");
        _playerGUIStyle.fontSize = Manager._playerGUIFontSize;
        _playerGUIStyle.alignment = TextAnchor.MiddleCenter;

        GUI.BeginGroup(new Rect(0,0,Screen.width, Screen.height));

        GUI.DrawTexture(new Rect(0 + Manager._screenWidthOffset, 0 + Manager._screenHeightOffset,
            Screen.width - (Manager._screenWidthOffset * 2),
            Screen.height - (Manager._screenHeightOffset * 2)), _guiBorder);

        GUI.EndGroup();
    }

    //public void SetNextBlockGUI()
    //{
    //    Debug.Log("SetNextBlock");
    //}
}
