using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openurl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/@shivanshpandey4237");
    }
    public void hackerrank()
    {
        Application.OpenURL("https://www.hackerrank.com/T_21_22_44");
    }
    public void git()
    {
        Application.OpenURL("https://github.com/shivaay0898");
    }
    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/shivaay0898/");
    }
}
