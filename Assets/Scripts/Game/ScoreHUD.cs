using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class ScoreHUD : MonoBehaviour
    {
        [SerializeField] Text _scoreText;

        private Hero _hero;
        
        public void Init(Hero hero)
        {
            _hero = hero;
            _scoreText.text = _hero.Score.ToString();
            _hero.OnScoreChanged += OnScoreChanged;
        }

        private void OnDestroy()
        {
            _hero.OnScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int score)
        {
            _scoreText.text = score.ToString();
        }
    }
}