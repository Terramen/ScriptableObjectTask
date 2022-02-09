using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class ChessPositionConfig : ScriptableObject
    {
        [SerializeField] private ChessFigureConfig chessFigureConfig;
        [SerializeField] private BoardConfig boardConfig;

        //[SerializeField] private 

        public void GenerateWhiteChessFigure()
        {
            foreach (var chessPosition in chessFigureConfig.ChessPositions)
            {
                Instantiate(chessFigureConfig.GetChessFigure(chessPosition.ID).ChessFigureInfo.Prefab, new Vector3(chessPosition.X, 0, chessPosition.Y), Quaternion.identity);
            }
        }
        
        public void GenerateBlackChessFigure()
        {
            Instantiate(chessFigureConfig.GetChessFigure("Rook").ChessFigureInfo.Prefab);
        }
    }
}