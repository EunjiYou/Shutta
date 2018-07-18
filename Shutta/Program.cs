using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shutta
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();

            Board board = new Board();

            // 동적배열
            List<Player> players = new List<Player>();
            players.Add(new Player());
            players.Add(new Player());

            // 둘 중 한 명이 오링날 때까지
            while (CanGoRound(players))
            {
                // 라운드 진행

            }
        }

        static bool CanGoRound(List<Player> players)
        {
            if (players[0].Money > 0 && players[1].Money > 0)
                return true;

            return false;
        }
    }
}
