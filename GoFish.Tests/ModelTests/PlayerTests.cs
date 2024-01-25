using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GoFish.Models;
using System;

namespace GoFish.Tests
{
  [TestClass]
  public class PlayerTests : IDisposable
  public void Dispose()
    {
      Player.ClearAll();
    }
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player newPlayer = new Player();
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }
    [TestMethod]
    public void PlayerConstructor_AddsToPlayersList_Void()
    {
      Player newPlayer = new Player();
      List<string> expected = new List<string> { newPlayer }
      CollectionAssert.AreEqual(Player.Players, expected)
    }
    [TestMethod]
    public void ClearAll_ClearsPlayersList_Void()
    {
      Player newPlayer = new Player();
      List<string> expected = new List<string> {}
      Player.ClearAll()
      CollectionAssert.AreEqual(Player.Players, expected)
    }
  }
}