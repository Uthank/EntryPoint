using System;
using Structure;
using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(HeroMover))]
    public class Hero : MonoBehaviour
    {
        private const string ScoreKey = "Score";
        
        private int _score;
        
        public event Action<int> OnScoreChanged;

        public int Score => _score;
        
        private void Awake()
        {
            if (Services.SaveService.HasKey(ScoreKey))
                _score = Services.SaveService.LoadInt(ScoreKey);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out ScoreBox scoreBox) == false) 
                return;
            
            _score++;
            OnScoreChanged?.Invoke(_score);
            Services.SaveService.SaveInt(ScoreKey, _score);
        }
    }
}