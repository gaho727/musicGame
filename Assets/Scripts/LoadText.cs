using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    public Text btn1Text;
    public Text btn2Text;
    public Text btn3Text;
    public Text btn4Text;
    
    public static int answer;

    //private string path = "Assets/Resources/Texts/";
    string source;
    StringReader sr;

    string subject;

	private void Start()
	{
        Screen.SetResolution(1080, 2160, true);
	}

    public void SetSubjectText(string sub)
	{
        subject = sub;
	}

	public void LoadTxt()
	{
        TextAsset data = Resources.Load(subject, typeof(TextAsset)) as TextAsset; //"Texts/game1"
        sr = new StringReader(data.text);
        source = sr.ReadLine();
        //Debug.Log(source.ToString());
        //string[] values;

        //      while(source != null)
        //{
        //          values = source.Split('/');
        //          if (values.Length == 0)
        //	{
        //              sr.Close();
        //              return;
        //	}
        //          source = sr.ReadLine();
        //      }
    }

    public string LoadNextLine()
	{
        string[] values;
        //Debug.Log(source.ToString());
        values = source.Split('/');
        if (values.Length == 0)
        {
            sr.Close();
            return null;
        }
        SetBtnText(values);
        source = sr.ReadLine();
        return values[4];
    }

    private void SetBtnText(string[] values)
	{
        btn1Text.text = values[0];
        btn2Text.text = values[1];
        btn3Text.text = values[2];
        btn4Text.text = values[3];
    }

	public void ResetGame()
	{
        sr.Close();
        LoadTxt();
	}
}
