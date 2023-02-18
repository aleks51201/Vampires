using System;

namespace Vampire.PauseObject
{
    public class PauseManager
    {
        private static bool _isPause = false;


        public static bool IsPause
        {
            get
            {
                return _isPause;
            }
            private set
            {
                _isPause = value;
            }
        }


        public static Action PausedEvent;
        public static Action UnpausedEvent;


        public static void Pause()
        {
            if (_isPause)
            {
                return;
            }
            _isPause = true;
            PausedEvent?.Invoke();
        }

        public static void Unpause()
        {
            if (!_isPause)
            {
                return;
            }
            _isPause = false;
            UnpausedEvent?.Invoke();
        }
    }
}
