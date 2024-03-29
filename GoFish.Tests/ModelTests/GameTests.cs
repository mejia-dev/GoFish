using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class GameTests : IDisposable
  {
    public void Dispose()
    {
      Game.ClearAll();
    }
    
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void GetDeck_ReturnsCardDeck_Deck()
    {
      //Act
      Game newGame = new Game();
      List<string> expected = new List<string> {};
      CollectionAssert.AreEqual(expected,newGame.Deck);
    }
    [TestMethod]
    public void DeckBuilder_PopulatesDeckWith52Cards_Void()
    {
      Game newGame = new Game();
      newGame.DeckBuilder();
      Assert.AreEqual(52,newGame.Deck.Count);
    }

    [TestMethod]
    public void GetActivePlayerBool_ReturnsActivePlayerBool_Bool()
    {
      bool playerActive = true;
      Game newGame = new Game();
      Assert.AreEqual(true,newGame.ActivePlayerBool);
    }
    
    [TestMethod]
    public void GetCurrentPlayerTurn_ReturnsCurrentPlayerTurn_Int()
    {
      int expected = 1;
      Game newGame = new Game();
      Assert.AreEqual(expected,newGame.CurrentPlayerTurn);
    }

    [TestMethod]
    public void SetCurrentPlayerTurn_ChangeCurrentPlayerTurn_Int()
    {
      Game newGame = new Game();
      int updated = 2;
      newGame.CurrentPlayerTurn = updated;

      Assert.AreEqual(updated,newGame.CurrentPlayerTurn);
    }

    [TestMethod]
    public void GetPlayers_ReturnsPlayer_List()
    {
      Game newGame = new Game();
      Player player1 = new Player();
      Player player2 = new Player();
      List<Player> expected = new List<Player> { player1, player2 };
      newGame.GetAll();
      CollectionAssert.AreEqual(expected, newGame.Players);
    }
  }
}