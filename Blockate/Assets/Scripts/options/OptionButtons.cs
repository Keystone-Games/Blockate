using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Trigger_Local()
    {
        SceneManager.LoadScene("worldlist");
    }

    public void Trigger_Global()
    {
        SceneManager.LoadScene("serverlist");
    }

    public void Trigger_Settings()
    {
        SceneManager.LoadScene("settings");
    }
}
