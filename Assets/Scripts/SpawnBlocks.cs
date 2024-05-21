using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public string _currentBlockID;

    public string _nextBlockID;
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

        _currentBlock = null;
        _spawnNextBlock = false;

        if(_nextBlockID == null)
            _nextBlockID = _blocks[Random.Range(0, _blocks.Length)];


    }

    // Update is called once per frame
    void Update()
    {
        if (_currentBlock == null)
            ChooseNextBlock();

        if(_spawnNextBlock == true)
        {
            ChooseNextBlock();
            _spawnNextBlock= false;
        }

        if (Input.GetKeyDown("b"))
        {
            Destroy(_currentBlock);
        }
    }

    private void ChooseNextBlock()
    {
        if(_nextBlockID != null) 
        {
            _currentBlockID = _nextBlockID;
        }

        SpawnBlock();

        _nextBlockID = _blocks[Random.Range(0, _blocks.Length)];

        PlayerGUI _playerTempGUI = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<PlayerGUI>();

        //_playerTempGUI.SetNextBlockGUI();

     
    }
    

    private void SpawnBlock()
    {
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
