using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class GameEventMessage
    {

        public const int DEFAULT_INT= -1;
        public const float DEFAULT_FLOAT = -1;
        public const bool DEFAULT_BOOL = false;
        public const string DEFAULT_STRING = "";


        public Component EventSender
        {
            get; set;
        }

        public GameEvent GameEventSender
        {
            get; set;
        }

        public int intValue1;
        public int intValue2;
        public int intValue3;

        public float foatValue1;
        public float foatValue2;
        public float foatValue3;

        public bool boolValue1;
        public bool boolValue2;
        public bool boolValue3;


        public string stringValue1;
        public string stringValue2;
        public string stringValue3;

        public Vector3 vectorValue1;
        public Vector3 vectorValue2;
        public Vector3 vectorValue3;

        public GameEventMessage(Component gameEvent)
        {
            EventSender = gameEvent;
        }

    }
