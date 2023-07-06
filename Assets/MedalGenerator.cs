using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalGenerator : MonoBehaviour
{
    public GameObject medalPrefab;

    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        for (float x = -10f; x < 10f; x++) {
            for (float z = -25f; z < 5f; z += 0.5f) {
                Instantiate(medalPrefab, new Vector3(x, 5, z), Quaternion.identity);
                count++;
            }
        }
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
