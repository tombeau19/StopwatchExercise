using System;

namespace StopwatchExercise
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch Already Running!");

            _running = true;
            _startTime = DateTime.Now;
            Console.WriteLine($"Stopwatch started at {_startTime}");
        }

        public void Stop()
        {
            if (!_running) 
                throw new InvalidOperationException("Stopwatch has not been started");

            _running = false;
            _stopTime = DateTime.Now;
            _duration += _stopTime - _startTime;

            Console.WriteLine($"{_duration}");
        }

        public void Reset()
        {
            _duration = TimeSpan.Zero;
            _running = false;
        }

        public Stopwatch()
        {
            Reset();
        }
    }
}