using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow: MonoBehaviour {



	public bool IsGameOver { get { return isGameOver; } }
	private bool isGameOver = false;

	private static GameFlow _instance = null;
	public static GameFlow Instance {
		get {
			if(_instance == null) {
				_instance = FindObjectOfType<GameFlow>();

				if(_instance == null) {
					Debug.LogError( "Fatal Error: GameFlowManager not Found" );
				}
			}

			return _instance;
		}
	}

	[Header( "UI" )]
	public UIGameFlow GameOverUI;

	public void GameOver() {
		isGameOver = true;
		SoundManager.Instance.playGameOver();
		ScoreManager.Instance.SetHighScore();
		GameOverUI.Show();
	}
	private void Start() {
		isGameOver = false;
	}

}
