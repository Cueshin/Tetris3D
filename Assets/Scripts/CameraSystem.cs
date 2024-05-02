using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Vector3 _cameraPivotPoint;

    public int _gameheight;
    public int _cameraHeightPoint;

    public float _horizontalSpeed = 100f;
    public float _verticalSpeed = 10f;

    public float _horizontalInput;
    public float _verticalInput;

    public Vector3 _cameraStartingPosition;
    public Vector3 _cameraStartingRotation;


    // Start is called before the first frame update
    void Start()
    {
        _gameheight = 20;

        _cameraHeightPoint = _gameheight / 2;

        _cameraPivotPoint = new Vector3(0, _cameraHeightPoint, 0);

        _cameraStartingPosition = new Vector3(0, 15, -10);
        transform.position = _cameraStartingPosition;

        _cameraStartingRotation = new Vector3(25, 0, 0);
        transform.rotation = Quaternion.Euler(_cameraStartingRotation);
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = _horizontalSpeed * Input.GetAxis("Camera_Horizontal");

        transform.RotateAround(_cameraPivotPoint, Vector3.up, _horizontalInput * Time.deltaTime);
            
        _verticalInput = _verticalSpeed * Input.GetAxis("Camera_Vertical");

        transform.Translate(Vector3.up * (_verticalInput  * Time.deltaTime), Space.World);

    }
}
