using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Movement : MonoBehaviour
{
    public Vector3 _currentPosition;
    public float _currentMovePause;
    public Quaternion _currentRotation;

    public float _horizontalMoveInput;
    public float _verticalMoveInput;  
    public bool _movingHorizontal;
    public bool _lockPosition;
    public Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _movingHorizontal = false;

        _lockPosition = false;

        _currentPosition = transform.position;
        _currentRotation = Quaternion.Euler(0, 0, 0);
        _currentMovePause = Manager._currentTimerValue;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }
    
    private void MoveBlock()
    {
        if (_lockPosition == true)
            return;
        

        MoveBlockHorizontal();
        RotateBlockVertical();
        
        if(transform.position.y == 0)
        {
            FreezeConstraints();
            return;
        }

        if (_movingHorizontal == true)
            return;
        _currentPosition = transform.position;
        _currentPosition.y -= 1;
        transform.position = _currentPosition;
    }
    private void Countdown()
    {
        _currentMovePause -= Manager._currentTimerValue * Time.deltaTime;

        if (_currentMovePause < 0)
            _currentMovePause = 0;

        if(_currentMovePause == 0 && _movingHorizontal == true)
        {
            _currentMovePause = Manager._currentTimerValue;
            _movingHorizontal = false;
        }
        else if(_currentMovePause == 0)
        {
            MoveBlock();

            _currentMovePause = Manager._currentTimerValue; 
        }
    }
    private void MoveBlockHorizontal()
    {
        _horizontalMoveInput = Input.GetAxis("Movement_Horizontal");        
        
        if(_horizontalMoveInput > 0 && _currentMovePause == 0)
        {
            _movingHorizontal = true;
            _currentPosition = transform.position;
            _currentPosition.x += 1;
            transform.position = _currentPosition;
        }
        if (_horizontalMoveInput < 0 && _currentMovePause == 0)
        {
            _movingHorizontal = true;
            _currentPosition = transform.position;
            _currentPosition.x -= 1;
            transform.position = _currentPosition;
        }
    }

    public void RotateBlockVertical()
    {
        _verticalMoveInput = Input.GetAxis("Movement_Vertical");

        if(_verticalMoveInput > 0 && _currentMovePause == 0)
        {
            transform.Rotate(transform.position.x + 90, 0, 0, Space.Self);
        }
        else if (_verticalMoveInput < 0 && _currentMovePause == 0)
        {
            transform.Rotate(transform.position.x - 90, 0, 0, Space.Self);
        }
    }
    private void OnCollisionEnter(Collision coliision)
    {
        FreezeConstraints();
    }

    private void FreezeConstraints()
    {
        SpawnBlocks._spawnNextBlock = true;

        _lockPosition = true;

        _rigidbody = GetComponent<Rigidbody>();

        _rigidbody.constraints = RigidbodyConstraints.FreezeAll;

        GetComponent<Block_Movement>().enabled = false;

    }
}
