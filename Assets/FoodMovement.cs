using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RandomPlacement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomPlacement()
    {
        var x = Random.Range(0, 4) + 0.5f;
        var y = Random.Range(0, 4) + 0.5f;
        var z = Random.Range(0, 4) + 0.5f;
        transform.position = new Vector3(x, y, z);
    }
    private void OnTriggerEnter(Collider other)
    {
        RandomPlacement();
    }
}