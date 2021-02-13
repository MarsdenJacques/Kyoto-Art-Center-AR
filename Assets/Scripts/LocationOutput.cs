using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LocationOutput : MonoBehaviour
{
    string path;
    string output = "";
    private void Start()
    {
        path = Application.persistentDataPath;
    }

    public void RecordLocation()
    {
        output += "" + transform.position.x + "," + transform.position.y + "," + transform.position.z + "; \n";
        File.WriteAllText(path + "/locations.txt", output);
    }
}
