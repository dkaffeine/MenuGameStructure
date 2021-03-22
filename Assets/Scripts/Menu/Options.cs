using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Options
{
    private static string fileName = Application.persistentDataPath + "/options.save";

    // Start is called before the first frame update
    public static void SaveToDisk(Save data)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(fileName);
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Data saved to " + fileName);
    }

    // Update is called once per frame
    public static Save LoadFromDisk()
    {
        if (File.Exists(fileName))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(fileName, FileMode.Open);
            Save data = (Save)bf.Deserialize(file);
            file.Close();
            Debug.Log("Data loaded from " + fileName);
            return data;
        }
        else
        {
            Debug.Log(fileName + "is missing, creating it...");
            Save data = new Save();
            SaveToDisk(data);
            return data;
        }
    }
}
