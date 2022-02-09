using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class ChessPosition : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private int x;
        [SerializeField] private int y;
        [SerializeField] private ChessFigureInfo chessFigureInfo;

        public string ID => id;

        public int X => x;

        public int Y => y;

        public ChessFigureInfo ChessFigureInfo => chessFigureInfo;
    }
}