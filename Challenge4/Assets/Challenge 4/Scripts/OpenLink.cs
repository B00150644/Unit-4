using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenChannel() 
    {
        Application.OpenURL("https://github.com/B00150644/Unit-4.git");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
