using System.Collections.Generic;
using System;

namespace GoFish.Models
{
  public class Game
  {
    private static List<Game> _instances = new List<Game> { };
    public int GameId { get; }
    public bool ActivePlayerBool { get; }
    public int CurrentPlayerTurn { get; set; }
    public List<string> Deck { get; set; }
    public List<Player> Players { get; set; }

    public Game()
    {
      _instances.Add(this);
      GameId = _instances.Count;
      Deck = new List<string> { };
      ActivePlayerBool = true;
      CurrentPlayerTurn = 1;
      Players = new List<Player> {};
      
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

    public static List<Game> GetAll()
    {
      return _instances;
    }

    public static  void ClearAll()
    {
      _instanceslayers.Clear();
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