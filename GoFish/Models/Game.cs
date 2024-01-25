using System.Collections.Generic;
using System;

namespace GoFish.Models
{
  public class Game
  {
    public bool ActivePlayerBool { get; }
    public int CurrentPlayerTurn { get; }
    public List<string> Deck { get; set; }

    public Game()
    {
      Deck = new List<string> { };
      ActivePlayerBool = true;
      CurrentPlayerTurn = 1;
    }

    public void DeckBuilder()
    {
      Deck = new List<string>();
      for (int i = 1; i <= 13; i++)
      {
        Deck.Add("Spades" + i);
        Deck.Add("Hearts" + i);
        Deck.Add("Clubs" + i);
        Deck.Add("Diamonds" + i);
      }
      Console.WriteLine(Deck.Count);
    }


  }
}


//Game obj
//props
//active player bool
// List of Cards
// List of players - toggle player
// Drawing bool
// AskFor method input to ask for card
// check method/match method
// reset game
// build deck method


//Player obj
//props
// name
// assignedHand