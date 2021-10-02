using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager: MonoBehaviour {

	public AudioClip gameOver;
	public AudioClip scoreNormal;
	public AudioClip scoreCombo;
	public AudioClip wrongMove;
	public AudioClip tap;
	private AudioSource player;

	private static SoundManager _instance = null;
	public static SoundManager Instance {
		get {
			if(_instance == null) {
				_instance = FindObjectOfType<SoundManager>();

				if(_instance == null) {
					Debug.LogError( "Fatal Error: SoundManager not Found" );
				}
			}

			return _instance;
		}
	}

	private void Start() {
		player = GetComponent<AudioSource>();
	}

	public void PlayScore(bool isCombo) {
		if(isCombo) {
			player.PlayOneShot( scoreCombo );
		} else {
			player.PlayOneShot( scoreNormal );
		}
	}

	public void PlayWrong() {
		player.PlayOneShot( wrongMove );
	}

	public void PlayTap() {
		player.PlayOneShot( tap );
	}

	public void playGameOver() {
		player.PlayOneShot( gameOver );
	}
}
