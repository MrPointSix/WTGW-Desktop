using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreboardController : MonoBehaviour
{
    public TMP_Text topScoreText, bottomScoreText;
    int topScore, bottomScore = 0;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void ResetScore()
    {
        audioManager.PlaySFX(audioManager.menuNav);
        topScore = 0;
        bottomScore = 0;
        topScoreText.text = topScore.ToString();
        bottomScoreText.text = bottomScore.ToString();
    }

    public void UpTopScore()
    {
        if (topScore < 99)
        {
            audioManager.PlaySFX(audioManager.menuNav);
            topScore++;
            topScoreText.text = topScore.ToString();
        } else
        {
            audioManager.PlaySFX(audioManager.menuNav);
        }     
    }

    public void DownTopScore()
    {
        if (topScore > 0)
        {
            audioManager.PlaySFX(audioManager.menuNav);
            topScore--;
            topScoreText.text = topScore.ToString();
        }
        else
        {
            audioManager.PlaySFX(audioManager.menuNav);
        }     
    }

    public void UpBottomScore()
    {
        if (bottomScore < 99)
        {
            audioManager.PlaySFX(audioManager.menuNav);
            bottomScore++;
            bottomScoreText.text = bottomScore.ToString();
        }
        else
        {
            audioManager.PlaySFX(audioManager.menuNav);
        }       
    }

    public void DownBottomScore()
    {
        if (bottomScore > 0)
        {
            audioManager.PlaySFX(audioManager.menuNav);
            bottomScore--;
            bottomScoreText.text = bottomScore.ToString();
        }
        else
        {
            audioManager.PlaySFX(audioManager.menuNav);
        }  
    }

}
