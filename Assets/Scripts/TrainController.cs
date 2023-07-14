using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint1;
    [SerializeField] GameObject spawnPoint2;
    [SerializeField] float trainSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnPoint2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // move train to spawn point 2 off screen
        if (transform.position != spawnPoint1.transform.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, spawnPoint1.transform.position, trainSpeed);
        }
        
    }
}
