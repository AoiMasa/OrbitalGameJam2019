using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

    [System.Serializable]
    public class UnityMyEvent : UnityEvent<GameEventMessage>
    {

    }

    public class GameEventListener : MonoBehaviour
    {
        [SerializeField]
        private GameEvent[] gameEvents;
        [SerializeField]
        private UnityMyEvent myEvent;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnEnable()
        {
            foreach (GameEvent evt in gameEvents)
                evt.AddListerner(this);
        }

        private void OnDisable()
        {
            foreach (GameEvent evt in gameEvents)
                evt.RemoveListerner(this);
        }

        public void SendEvent(GameEventMessage message)
        {
            myEvent.Invoke(message);
        }
    }
