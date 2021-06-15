﻿using System;

namespace c_project
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      string[] el = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
      int[][] possibilities = { new int[] { 0, 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 6, 7, 8 }, new int[] { 0, 3, 6 }, new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 0, 4, 8 }, new int[] { 2, 4, 6 } };


      string currentPlayer;
      int moves = 0;
      string outcome = "draw";
      bool winner = false;

      string player1, player2;


      Console.Write("Player 1: ");
      player1 = Console.ReadLine();


      Console.Write("Player 2: ");
      player2 = Console.ReadLine();

      currentPlayer = player1;

      Console.Clear();



      while (!winner)
      {
        string currentIcon = currentPlayer == player1 ? "X" : "O";

        if (currentPlayer == player1)
        {
          Console.WriteLine();
          Console.WriteLine($"Player's turn: {currentPlayer}");
          Console.WriteLine();
          Console.WriteLine($" {el[0]} | {el[1]} | {el[2]}");
          Console.WriteLine($"----------");
          Console.WriteLine($" {el[3]} | {el[4]} | {el[5]}");
          Console.WriteLine($"----------");
          Console.WriteLine($" {el[6]} | {el[7]} | {el[8]}");

          Console.WriteLine();
          Console.WriteLine("Where to? ");
          string temp = Console.ReadLine();
          el[Convert.ToInt32(temp) - 1] = currentIcon;


          for (int j = 0; j < possibilities.Length; j++)
          {
            int[] possibilityEachArray = possibilities[j];
            if (el[possibilityEachArray[0]] == currentIcon && el[possibilityEachArray[1]] == currentIcon && el[possibilityEachArray[2]] == currentIcon)
            {
              outcome = "winner";
              winner = true;
            }
          }

          moves++;
          Console.Clear();
          if (winner != true)
          {
            currentPlayer = player2;
          }

        }
        else
        {
          Console.WriteLine();
          Console.WriteLine($" Player's turn: {currentPlayer}");
          Console.WriteLine();
          Console.WriteLine($" {el[0]} | {el[1]} | {el[2]}");
          Console.WriteLine($"----------");
          Console.WriteLine($" {el[3]} | {el[4]} | {el[5]}");
          Console.WriteLine($"----------");
          Console.WriteLine($" {el[6]} | {el[7]} | {el[8]}");

          Console.WriteLine();
          Console.WriteLine("Where to? ");
          string tempNumberValueString = Console.ReadLine();
          int tempNumberValueToIntIndex = Convert.ToInt32(tempNumberValueString) - 1;
          el[tempNumberValueToIntIndex] = currentIcon;

          for (int j = 0; j < possibilities.Length; j++)

          {
            int[] possibilityEachArray = possibilities[j];
            if (el[possibilityEachArray[0]] == currentIcon && el[possibilityEachArray[1]] == currentIcon && el[possibilityEachArray[2]] == currentIcon)
            {
              outcome = "winner";
              winner = true;
            }
          }

          moves++;
          Console.Clear();

          if (winner != true)
          {
            currentPlayer = player1;
          }
        }

      }

      if (outcome == "winner")
      {

        Console.WriteLine($"{currentPlayer} is the {outcome}");
      }
      else
      {

        Console.WriteLine("play again");
      }

      Console.ReadKey();
    }
  }
}
