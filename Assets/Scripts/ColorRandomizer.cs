using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    public Texture2D[] _colouredTextures;
    public Renderer[] _renderer;
    public Texture _mainTexture;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponentsInChildren<Renderer>();
        
        Texture2D _randomTexture = _colouredTextures[Random.Range(0, _colouredTextures.Length)];  
        _mainTexture = _randomTexture;

        foreach (Renderer _tempRender in _renderer)
            _tempRender.material.SetTexture("_MainTex", _mainTexture);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
