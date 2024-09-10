using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public string _currentBlockID;
    public static string _nextBlockID;
    public static string _heldBlockID;
    public bool _releasingBlock;

    public float _introCountdownCurrent;

    public GameObject _currentBlock;

    public static bool _spawnNextBlock;

    public string[] _blocks = new string[]
    {
        "I-Shaped",
        "J-Shaped",
        "L-Shaped",
        "O-Shaped",
        "S-Shaped",
        "T-Shaped",
        "Z-Shaped"

    };
    // Start is called before the first frame update
    void Start()
    {
        _currentBlockID = "";
        _nextBlockID = "";
        _heldBlockID = "";

        _currentBlock = null;
        _spawnNextBlock = false;
        _releasingBlock = false;

        _introCountdownCurrent = Manager._introCountdownMax;

        if(_nextBlockID == null)
            _nextBlockID = _blocks[Random.Range(0, _blocks.Length)];


    }

    // Update is called once per frame
    void Update()
    {
        if(_introCountdownCurrent > 0)
        {
            _introCountdownCurrent -= 1 * Time.deltaTime;
        }
        if (_introCountdownCurrent < 0)
            _introCountdownCurrent = 0;

        if(_releasingBlock == false)
        {
            if (_introCountdownCurrent == 0 && _currentBlock == null)
            {
                ChooseNextBlock();

            }
        }

            if (_currentBlock == null)
            ChooseNextBlock();

        if(_spawnNextBlock == true)
        {
            ChooseNextBlock();
            _spawnNextBlock= false;
        }

        if (Input.GetButtonDown("Hold_Button"))
        {
            _heldBlockID = _currentBlockID;

            Destroy(_currentBlock);
        }

        if (Input.GetButtonDown("Release_Button") 
            && _heldBlockID != null)
        {
            _releasingBlock = true;

            Destroy(_currentBlock);

            SpawnHeldBlock();
        }

        if (Input.GetKeyDown("b"))
        {
            Destroy(_currentBlock);
        }
    }

    private void SpawnHeldBlock()
    {
        UnityEngine.Debug.Log("SpawnHeldBlock");

        _currentBlockID = _heldBlockID;

        SpawnBlock();

    }


    private void ChooseNextBlock()
    {
        UnityEngine.Debug.Log("ChooseNextBlock");
        if (_nextBlockID != null) 
        {
            _currentBlockID = _nextBlockID;
        }

        SpawnBlock();

        _nextBlockID = _blocks[Random.Range(0, _blocks.Length)];

       CallGUIFunctions();

    }

    private void CallGUIFunctions()
    {
        PlayerGUI _playerTempGUI =
           GameObject.FindGameObjectWithTag("MainCamera")
           .GetComponent<PlayerGUI>();

        //_playerTempGUI.SetNextBlockGUI();

        //_playerTempGUI.SetHeldBlockGUI();

    }


    private void SpawnBlock()
    {
        UnityEngine.Debug.Log("SpawnBlock");
        switch (_currentBlockID)
        {
            case "I-Shaped": _currentBlock = Instantiate(Resources.Load("I-Shaped"), new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                break;
            case "J-Shaped":
                _currentBlock = Instantiate(Resources.Load("J-Shaped"), new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                break;
            case "L-Shaped":
                _currentBlock = Instantiate(Resources.Load("L-Shaped"), new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                break;
            case "O-Shaped":
                _currentBlock = Instantiate(Resources.Load("O-Shaped"), new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                break;
            case "S-Shaped":
                _currentBlock = Instantiate(Resources.Load("S-Shaped"), new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                break;
            case "T-Shaped":
                _currentBlock = Instantiate(Resources.Load("T-Shaped"), new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                break;
            case "Z-Shaped":
                _currentBlock = Instantiate(Resources.Load("Z-Shaped"), new Vector3(0, 10, 0), Quaternion.identity) as GameObject;
                break;

        }
       
    }
}
