using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 3f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    public CanvasGroup caughtBackgroundImageCanvasGroup;

    public AudioSource caughtSound;
    public AudioSource wonSound;

    bool m_IsPlayerAtExit = false;
    bool m_IsPlayerCaught = false;
    float m_Timer;

    // Update is called once per frame
    void Update() {
        if (m_IsPlayerAtExit)
        {
            EndGameFade(exitBackgroundImageCanvasGroup, false);
            if (!wonSound.isPlaying) wonSound.Play();
        }
        else if (m_IsPlayerCaught)
        {
            EndGameFade(caughtBackgroundImageCanvasGroup, true);
            if (!caughtSound.isPlaying) caughtSound.Play();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    private void EndGameFade(CanvasGroup group, bool restart)
    {
        m_Timer += Time.deltaTime;
        group.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (!restart) Application.Quit();
            else SceneManager.LoadScene(0);
        }
    }

    public void SetPlayerCaught(bool caught) { this.m_IsPlayerCaught = caught; }
}
