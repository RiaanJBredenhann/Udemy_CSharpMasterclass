using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo2
{
    internal class VideoPost : Post
    {
        protected bool _isPlaying = false;
        protected int _currentDuration = 0;
        Timer timer;
        
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, bool isPublic, string sendByUsername, string videoUrl, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoUrl;
            this.Length = length;
        }

        public void Play()
        {
            if (!_isPlaying)
            {
                _isPlaying = true;
                Console.WriteLine("Playing Video...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        public void TimerCallback(Object obj)
        {
            if (_currentDuration < Length)
            {
                _currentDuration++;
                Console.WriteLine($"Video at {_currentDuration} seconds");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (_isPlaying)
            {
                _isPlaying = false;
                Console.WriteLine($"Stopped at {_currentDuration}");
                _currentDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} - by {this.SendByUsername}");
        }

       
    }
}
