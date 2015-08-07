using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;

public class InputManager : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM3", 9600);

    public bool rightBool;
    public bool leftBool;

    public bool action;

    void OnApplicationQuit()
    {
        stream.Close();
    }

    void OpenConnection()
    {

        if (stream != null)
        {

            if (stream.IsOpen)
            {
                stream.Close();
                Debug.LogError("Failed to open Serial Port, already open!");
            }
            else
            {
                stream.Open();
                stream.ReadTimeout = 200;

                Debug.Log("Open Serial port");
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        OpenConnection();
    }

    // Update is called once per frame
    void Update()
    {
        string result = "";
        result = stream.ReadLine();
        Debug.Log(result);
        if (result == "A")
            action = true;
        else action = false;
        if (result == "R")
            rightBool = true;
        else rightBool = true;
        if (result == "L")
            leftBool = true;
        else leftBool = false;
    }
}
