using System;
using UnityEngine;

public class GameStatus
{
       public static GameStatus Instance;
       public GameState GameState;

       public GameStatus()
       {
           Instance = this;
       }

       public GameStatus(GameState gameState)
       {
           Instance = this;
           Instance.GameState = gameState;
       }
}