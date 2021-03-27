using System;

namespace StopwatchExercise
{
    public class Stopwatch
    {
        private string _status;
        private TimeSpan _duration;
        private DateTime _startTime;
        private DateTime _stopTime;

        public void Start()
        {
            if (_status == "running")
                throw new InvalidOperationException("Stopwatch Already Running!");

            _status = "running";
            _startTime = DateTime.Now;
            Console.WriteLine($"Stopwatch started at {_startTime}");
        }

        public void Stop()
        {
            _status = "stopped";
            _stopTime = DateTime.Now;
            _duration += _stopTime - _startTime;

            Console.WriteLine($"{_duration}");
        }

        public void Reset()
        {
            _duration = TimeSpan.Zero;
            _status = "ready";
        }

        public Stopwatch()
        {
            _status = "ready";
            _duration = TimeSpan.Zero;
        }
    }
}