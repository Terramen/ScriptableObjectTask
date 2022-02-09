using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class ChessFigureInfo : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private GameObject prefab;

        public string Name => name;

        public GameObject Prefab => prefab;
    }
}