using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    float rotSpeed = 1.0f; //ADD
    public Slider speedValue;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        speedUpdate();
    }

    void FixedUpdate()
    {
        float ver = Input.GetAxis("Vertical");          //앞, 뒤 키
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");


        transform.Rotate(Vector3.up * rotSpeed * MouseX);
        transform.Rotate(Vector3.left * rotSpeed * MouseY);
        transform.Translate(Vector3.forward * speed * ver * Time.deltaTime);      //이동
    }

    void speedUpdate()
    {
        speed = speedValue.value;
    }


}
