using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levelscore : MonoBehaviour
{
    public Text LS;
    public Transform END;
    

    // Update is called once per frame
    void Update()
    {
        LS.text = END.position.z.ToString("0");
    }
}
