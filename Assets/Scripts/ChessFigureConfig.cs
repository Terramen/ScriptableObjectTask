using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class ChessFigureConfig : ScriptableObject
    {
        //[SerializeField] private ChessFigureInfo[] chessFigureInfo;
        [SerializeField] private ChessPosition[] chessPositions;

        public ChessPosition[] ChessPositions => chessPositions;
        public ChessPosition GetChessFigure(string id)
        {
            return chessPositions.FirstOrDefault(s => s.ID == id);
        }
        
    }
}