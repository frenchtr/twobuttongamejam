using System;
using UnityEngine;
using UnityEngine.Events;

namespace GameEvents
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField]
        private GameEvent gameEvent;
        [SerializeField]
        private UnityEvent response;

        private void Awake()
        {
            this.gameEvent.Raised += this.OnGameEventRaised;
        }

        private void OnDestroy()
        {
            this.gameEvent.Raised -= this.OnGameEventRaised;
        }

        private void OnGameEventRaised()
        {
            this.response?.Invoke();
        }
    }
}
