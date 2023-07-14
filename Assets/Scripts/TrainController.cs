using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainController : MonoBehaviour
{
    [SerializeField] public GameObject spawnPoint1;
    [SerializeField] public GameObject spawnPoint2;
    [SerializeField] float trainSpeed = 0.01f;

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
            // move position of train
            transform.position = Vector2.MoveTowards(transform.position, spawnPoint1.transform.position, trainSpeed);

            // move rotation of train so it faces target (stays on tracks)
            transform.up = spawnPoint1.transform.position - transform.position;
        }
        else
        {
            // train reached other point off screen, destroy itself
            Destroy(gameObject);
        }
        
    }
}
