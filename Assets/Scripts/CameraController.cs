using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public Camera cameraToMove;
    public Button moveButtonR;
    public Button moveButtonL;
    public Transform[] positions;
    public int currentPositionIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (moveButtonR != null)
        {
            moveButtonR.onClick.AddListener(OnMoveButtonClickR);
        }
        if (moveButtonL != null)
        {
            moveButtonL.onClick.AddListener(OnMoveButtonClickL);
        }
    }

    // Update is called once per frame
    public void OnMoveButtonClickR()
    {
        if (cameraToMove != null && positions.Length > 0)
        {
            currentPositionIndex = (currentPositionIndex + 1) % positions.Length;
            cameraToMove.transform.position = positions[currentPositionIndex].position ;
            cameraToMove.transform.rotation = positions[currentPositionIndex].rotation;
        }

    }
    public void OnMoveButtonClickL()
    {
        if (cameraToMove != null && positions.Length > 0 && currentPositionIndex != 0)
        {
            currentPositionIndex = (currentPositionIndex - 1);
            cameraToMove.transform.position = positions[currentPositionIndex].position;
            cameraToMove.transform.rotation = positions[currentPositionIndex].rotation;
        }
        else if (currentPositionIndex == 0)
        {
            currentPositionIndex = 3;
            cameraToMove.transform.position = positions[currentPositionIndex].position;
            cameraToMove.transform.rotation = positions[currentPositionIndex].rotation;

        }
    }
}
