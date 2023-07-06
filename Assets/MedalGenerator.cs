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
        for (float x = -10f; x < 10f; x += 0.5f) {
            for (float z = -28f; z < 5f; z += 0.5f) {
                Instantiate(medalPrefab, new Vector3(x, 5, z), Quaternion.identity);
                count++;
            }
        }
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 tapPosition = Input.mousePosition;
            tapPosition.z = 40f; // オブジェクトを配置するZ軸の距離（カメラからの距離）を指定します
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(tapPosition);
            Instantiate(medalPrefab, worldPosition, Quaternion.identity);
        }
    }
}
