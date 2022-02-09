using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private BoardConfig boardConfig;
        [SerializeField] private ChessPositionConfig chessPositionConfig;
        private void Start()
        {
            boardConfig.InitCells();
            chessPositionConfig.GenerateWhiteChessFigure();
        }
    }
}