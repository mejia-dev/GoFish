using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class GameTests
  {
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
  }
}