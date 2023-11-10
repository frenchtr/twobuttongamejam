using System;
using UnityEngine;
using UnityEngine.Events;

namespace GameEvents
{
    [CreateAssetMenu(menuName = "Scriptables/Game Event")]
    public class GameEvent : ScriptableObject
    {
        [SerializeField]
        private UnityEvent raised;

        public event Action Raised;

        public void Raise()
        {
            this.raised?.Invoke();
            this.Raised?.Invoke();
        }
    }
}
