using System.Collections.Generic;
using System;

namespace GoFish.Models
{
  public Array<Player> Players { get; set; }               
  public class Player
  {
    public string Name { get; set; }
    public List<string> Hand { get; set; } = new List<string>() {};
    public Player()
    {
      Players.Add(this);
    }
  }

}

// string name
// dealt hand
// game starts with array of 2 players