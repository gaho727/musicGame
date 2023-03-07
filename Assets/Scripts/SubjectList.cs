using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectList : MonoBehaviour
{
	public LoadText loadText;
	public Playgame playgame;
	public BtnEvent btnEvent;

	public AudioClip[] game1;
	public AudioClip[] maple;
	public AudioClip[] dnf;
	public AudioClip[] tooniverse;
	public AudioClip[] lol;
	public AudioClip[] movie;
	public AudioClip[] drama;
	public AudioClip[] musical;
	public void Game1()
	{
		loadText.SetSubjectText("Texts/game1");
		loadText.LoadTxt();
		playgame.SetAudioClips(game1);
		btnEvent.SetInfoMsg("노래를 듣고\n게임이름을 맞혀주세요.");
	}
	public void Maple()
	{
		loadText.SetSubjectText("Texts/maple");
		loadText.LoadTxt();
		playgame.SetAudioClips(maple);
		btnEvent.SetInfoMsg("노래를 듣고\n알맞은 맵을 맞혀주세요.");
	}

	public void Dnf()
	{
		loadText.SetSubjectText("Texts/dnf");
		loadText.LoadTxt();
		playgame.SetAudioClips(dnf);
		btnEvent.SetInfoMsg("노래를 듣고\n알맞은 맵을 맞혀주세요.");
	}

	public void Tooniverse()
	{
		loadText.SetSubjectText("Texts/tooniverse");
		loadText.LoadTxt();
		playgame.SetAudioClips(tooniverse);
		btnEvent.SetInfoMsg("노래를 듣고\n만화이름을 맞혀주세요.");
	}

	public void Lol()
	{
		loadText.SetSubjectText("Texts/lol");
		loadText.LoadTxt();
		playgame.SetAudioClips(lol);
		btnEvent.SetInfoMsg("노래를 듣고 어느 챔피언과\n관련있는지 맞혀주세요.");
	}

	public void Movie()
	{
		loadText.SetSubjectText("Texts/movie");
		loadText.LoadTxt();
		playgame.SetAudioClips(movie);
		btnEvent.SetInfoMsg("노래를 듣고\n영화 제목을 맞혀주세요.");
	}

	public void Drama()
	{
		loadText.SetSubjectText("Texts/drama");
		loadText.LoadTxt();
		playgame.SetAudioClips(drama);
		btnEvent.SetInfoMsg("노래를 듣고\n드라마 제목을 맞혀주세요.");
	}

	public void Musical()
	{
		loadText.SetSubjectText("Texts/musical");
		loadText.LoadTxt();
		playgame.SetAudioClips(musical);
		btnEvent.SetInfoMsg("노래를 듣고\n뮤지컬 제목을 맞혀주세요.");
	}
}
