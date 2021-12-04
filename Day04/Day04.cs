using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2021.Day04
{
    public class Day04
    {
        public static int SolvePart1(StreamReader input)
        {
            var winningCard = GetWinningCards(input).First();
            return GetCardScore(winningCard.Card, winningCard.NumbersDrawnWhenCardWon) * winningCard.WinningNumber;
        }
        
        public static int SolvePart2(StreamReader input)
        {
            var winningCard = GetWinningCards(input).Last();
            return GetCardScore(winningCard.Card, winningCard.NumbersDrawnWhenCardWon) * winningCard.WinningNumber;
        }

        private static List<WinningCard> GetWinningCards(StreamReader input)
        {
            var winningCards = new List<WinningCard>();
            var drawnNumbers = input.ReadLine().Split(",").Select(int.Parse).ToList();
            var cards = GetCards(input);
            
            for (var i = 0; i < drawnNumbers.Count; i++)
            {
                var drawnAtThisPoint = drawnNumbers.Take(i + 1).ToList();
                var winners = WinninCards(cards, drawnAtThisPoint);
                winningCards.AddRange(winners.Select(x => new WinningCard {Card = x, WinningNumber = drawnNumbers[i], NumbersDrawnWhenCardWon = drawnAtThisPoint}));
                winners.ForEach(x => cards.Remove(x));
            }

            return winningCards;
        }

        private static List<List<int>> GetCards(StreamReader input)
        {
            return input.ReadToEnd()
                .Split("\r\n\r\n")
                .Select(x => x.Replace("\r\n", " ").Replace("  ", " ").Trim().Split(" ").Select(int.Parse).ToList())
                .ToList();
        }

        private static int GetCardScore(List<int> winner, IEnumerable<int> drawnNumbers)
        {
            return winner.Where(x => !drawnNumbers.Contains(x)).Sum();
        }

        private static List<List<int>> WinninCards(List<List<int>> cards, List<int> drawnNumbers)
        {
            return cards
                .Where(x => AnyRowWins(drawnNumbers, x) || AnyColumnWins(drawnNumbers, x))
                .ToList();
        }

        private static bool AnyRowWins(List<int> drawnNumbers, List<int> card)
        {
            for (var i = 0; i < 5; i++)
            {
                if (card.Skip(i * 5).Take(5).All(drawnNumbers.Contains))
                    return true;
            }
;
            return false;
        }

        private static bool AnyColumnWins(List<int> drawnNumbers, List<int> card)
        {
            for (var i = 0; i < 5; i++)
            {
                var markedInARow = 0;
                for (var j = 0; j < 5; j++)
                {
                    if (drawnNumbers.Contains(card[i + j * 5]))
                        markedInARow++;                    
                }

                if (markedInARow == 5)
                    return true;
            }

            return false;
        }
    }
}