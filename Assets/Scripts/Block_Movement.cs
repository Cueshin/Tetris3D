using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Movement : MonoBehaviour
{
    public Vector3 _currentPosition;
    public float _currentMovePause;
    // Start is called before the first frame update
    void Start()
    {
        _currentPosition = transform.position;
        _currentMovePause = Manager._currentTimerValue;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }
    
    private void MoveBlock()
    {
        _currentPosition = transform.position;
        _currentPosition.y -= 1;
        transform.position = _currentPosition;
    }
    private void Countdown()
    {
        _currentMovePause -= Manager._currentTimerValue * Time.deltaTime;

        if (_currentMovePause < 0)
            _currentMovePause = 0;

        if(_currentMovePause == 0)
        {
            MoveBlock();

            _currentMovePause = Manager._currentTimerValue; 
        }
    }
}
