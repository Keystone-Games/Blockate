using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataUtils : MonoBehaviour
{

    public void clearData(bool confirmation)
    {
        if (!confirmation)
        {
            Debug.Log("Did not clear data; no confirmation");
            return;
        }
        Debug.Log("Clearing data");
        return;
    }
}
