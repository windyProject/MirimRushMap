using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.SceneManagement;

public class Page_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    SerialPort serialP = new SerialPort("COM8", 9600);

    void Start()
    {
        if (!serialP.IsOpen) //포트 연결
            serialP.Open();
    }

    // Update is called once per frame

    string tmp = null;

    void Update()
    {
        if (serialP.IsOpen)
        {
            try
            {
                print(serialP.ReadByte());
            }
            catch (System.TimeoutException e)
            {
                Debug.Log(e);
                throw;
            }
            //GameObject.Find("Text").GetComponent<Text>().text = "연결됨";
        }

        else if (!serialP.IsOpen)
        {
            //GameObject.Find("Text").GetComponent<Text>().text = "안연결됨";
            serialP.Open();
        }
    }

    public void print(int num)
    {
        if (num == 1)
            SceneManager.LoadScene("Map");
    }

    private void OnApplicationQuit()
    {
        serialP.Close();//포트 닫기
    }
}
