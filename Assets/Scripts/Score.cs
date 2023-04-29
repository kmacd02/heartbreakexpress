using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   public int playerScore;

   private void OnTriggerEnter2D(Collider2D other)
   {
      AddScore();
   }

   void AddScore()
   {
      playerScore++;
   }
}
