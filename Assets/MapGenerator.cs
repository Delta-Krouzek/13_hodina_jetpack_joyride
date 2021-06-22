using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public GameObject BorderUp;
    public GameObject BorderDown;
    public GameObject Player;
    public GameObject ceiling;
    public GameObject floor;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.x > floor.transform.position.x)
        {
            var tempCeiling = ceiling;
            var tempFloor = floor;
            ceiling = BorderUp;
            floor = BorderDown;
            tempCeiling.transform.position += new Vector3(80, 0, 0);
            tempFloor.transform.position += new Vector3(80, 0, 0);
            ceiling = tempCeiling;
            floor = tempFloor;
        }
    }
}
