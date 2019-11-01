using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager GM;
    public Slider _speedSlider;
    // Start is called before the first frame update
    void Start()
    {
        //--------------------------------------------------------------------------
        // Game Settings Related Code


        //--------------------------------------------------------------------------
        // Music Settings Related Code
        _speedSlider = GameObject.Find("Speed_Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        ScanForKeyStroke();
    }

    void ScanForKeyStroke()
    {
        if (Input.GetKeyDown("escape")) GM.TogglePauseMenu();
    }
}
