using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
   public int playerScore;
   public TMP_Text playerScoreCount;

   private void OnTriggerEnter2D(Collider2D other)
   {
      AddScore();
   }

   void AddScore()
   {
      playerScore++;
      playerScoreCount.text = playerScore.ToString();
   }
}
