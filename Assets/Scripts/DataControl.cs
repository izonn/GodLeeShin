using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable]
public class MyData
{
    public Boolean firstLoad = true;
    public string myName = "noName";
    public int myAge = 0;
    //public List<string> myAlbumList = new List<string> () {};
    //public 
}


public class DataControl {
    
    public void Save(string _myName)
    {
        MyData myData = new MyData();
        if (myData.firstLoad)
        {
            myData.firstLoad = false;
        }
        myData.myName = _myName;

        //Convert to Json
        string jsonData = JsonUtility.ToJson(myData);
        //Save Json string
        PlayerPrefs.SetString("MySaveData", jsonData);
        PlayerPrefs.Save();

        Debug.Log("Save Data Complete " + _myName);
    }

    public MyData Load()
    {
        //Load saved Json
        string jsonData = PlayerPrefs.GetString("MySaveData");
        //Convert to Class
        MyData myData = JsonUtility.FromJson<MyData>(jsonData);
        
        Debug.Log("Load Data Complete");
        Debug.Log(jsonData);

        return myData;
    }
}
