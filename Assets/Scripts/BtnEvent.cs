using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnEvent : MonoBehaviour
{
	public GameObject startPanel;
	public GameObject gamePanel;
	public GameObject infoPanel;
	public GameObject subjectPanel;
	public Text infoMsg;
	public Playgame playgame;
	public LoadText loadText;
	public AudioSource notification;

	private string answer;
	private int max;
	private int count = 0;
	private bool resetFlag = false;
	private int collect = 0;
	private string infoMsgText;
		


	public void ClickBtn1()
	{
		count++;
		playgame.StopMusic();
		infoPanel.SetActive(true);
		if (answer.Equals("1"))
		{
			infoMsg.text = "정답입니다! :)";
			collect++;
		}
		else
		{
			infoMsg.text = "틀렸습니다. :(";
		}
		if(count < max) answer = loadText.LoadNextLine();
	}

	public void ClickBtn2()
	{
		count++;
		playgame.StopMusic();
		infoPanel.SetActive(true);
		if (answer.Equals("2"))
		{
			infoMsg.text = "정답입니다! :)";
			collect++;
		}
		else
		{
			infoMsg.text = "틀렸습니다. :(";
		}
		if (count < max) answer = loadText.LoadNextLine();
	}

	public void ClickBtn3()
	{
		count++;
		playgame.StopMusic();
		infoPanel.SetActive(true);
		if (answer.Equals("3"))
		{
			infoMsg.text = "정답입니다! :)";
			collect++;
		}
		else
		{
			infoMsg.text = "틀렸습니다. :(";
		}
		if (count < max) answer = loadText.LoadNextLine();
	}

	public void ClickBtn4()
	{
		count++;
		playgame.StopMusic();
		infoPanel.SetActive(true);
		if (answer.Equals("4"))
		{
			infoMsg.text = "정답입니다! :)";
			collect++;
		}
		else
		{
			infoMsg.text = "틀렸습니다. :(";
		}
		if (count < max) answer = loadText.LoadNextLine();
	}

	public void ClickHomeBtn()
	{
		//게임초기화
		count = 0;
		collect = 0;
		playgame.ResetGame();
		loadText.ResetGame();
		playgame.StopMusic();
		gamePanel.SetActive(false);
		subjectPanel.SetActive(false);
		startPanel.SetActive(true);
	}

	public void ClickInfoPanel()
	{
		
		if (count >= max)
		{
			infoPanel.SetActive(true);
			infoMsg.text = "총 점수는 (" + collect+"/"+max + ")점 입니다.";
			Invoke("delayFlag", 0.5f); 
		}
		else
		{
			playgame.PlayMusic();
			infoPanel.SetActive(false);
		}
		if (resetFlag)
		{
			resetFlag = false;
			count = 0;
			collect = 0;
			playgame.ResetGame();
			loadText.ResetGame();
			playgame.StopMusic();
			gamePanel.SetActive(false);
			startPanel.SetActive(true);
		}
	}

	private void delayFlag()
	{
		resetFlag = true;
	}

	public void ClickStarBtn()
	{
		notification.Play();
		startPanel.SetActive(false);
		subjectPanel.SetActive(true);
	}

	public void ClickGameBtn()
	{
		notification.Play();
		answer = loadText.LoadNextLine();
		max = playgame.getAudioClips();
		resetFlag = false;
		subjectPanel.SetActive(false);
		infoPanel.SetActive(true);
		infoMsg.text = infoMsgText;
		gamePanel.SetActive(true);
	}

	public void SetInfoMsg(string str)
	{
		infoMsgText = str;
	}

	public void ClickEndBtn()
	{
		Application.Quit();
	}
}
