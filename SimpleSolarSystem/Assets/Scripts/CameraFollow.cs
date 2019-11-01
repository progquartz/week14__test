using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;           // target 
    public float dist = 10.0f;           // 거리
    public float height = 5.0f;         // 높이
    public float dampRotate = 5.0f;  //회전 속도

    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float cur_Y_Angle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, dampRotate * Time.deltaTime);

        //float cur_Z_Angle = Mathf.LerpAngle(tr.eulerAngles.z, target.eulerAngles.z, dampRotate * Time.deltaTime);
        //Mathf.LerpAngle(float s, float e, flaot t) = t시간 동안 s부터 e까지 각도를 변환하는 것.

        Quaternion rot = Quaternion.Euler(0, cur_Y_Angle, 0);

        tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);
        //타겟 위치 - 카메라위치 = 카메라가 타겟 뒤로 가야 타겟이 보이겠죠?
        tr.LookAt(target);
    }
}
