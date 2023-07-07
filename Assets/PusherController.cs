using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PusherController : MonoBehaviour
{
    public float speed = 0.0001f;   // 移動速度
    public float distance = 5f;   // 移動する距離
    private int updateCount = 0;

    private Vector3 startPosition;
    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (updateCount >= 10) {
            // 時間を更新
            currentTime += Time.deltaTime * speed;

            // z軸方向に移動
            float movement = Mathf.Sin(currentTime) * distance;
            transform.position = startPosition + new Vector3(0f, 0f, movement);
            updateCount = 0;
        } else {
            updateCount++;
        }
    }
}
