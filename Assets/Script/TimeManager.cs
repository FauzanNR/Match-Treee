using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager: MonoBehaviour {

	public int duration;
	private float time;

	private static TimeManager _instance = null;
	public static TimeManager Instance {
		get {
			if(_instance == null) {
				_instance = FindObjectOfType<TimeManager>();

				if(_instance == null) {
					Debug.LogError( "Fatal Error: TimeManager not Found" );
				}
			}

			return _instance;
		}
	}

	private void Start() {
		time = 0;
	}

	private void Update() {
		if(GameFlow.Instance.IsGameOver) {
			return;
		}

		if(time > duration) {
			GameFlow.Instance.GameOver();
			return;
		}

		time += Time.deltaTime;
	}

	public float GetRemainingTime() {
		return duration - time;
	}
}
