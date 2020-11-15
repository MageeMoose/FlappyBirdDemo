
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FlappyBirdDemo.Web.Components;

namespace FlappyBirdDemo.Web.Models
{
    public class GameManager  
    {
        private readonly int _gravity = 2;

        public event EventHandler MainLoopCompleted;

        public BirdModel Bird { get; private set; }
        public List<PipeModel> Pipes { get; private set; }
        public bool IsRunning { get; private set; } = false;

        public GameManager()
        {
            Bird = new BirdModel();
            Pipes = new List<PipeModel>();
        }

        public async void MainLoop()
        {
            IsRunning = true;
            while(IsRunning)
            {
                MoveObjects();
                CheckForCollisions();
                ManagePipes();

                MainLoopCompleted.Invoke(this, EventArgs.Empty);
                await Task.Delay(20);
            }
        }

        void CheckForCollisions()
        {
            if (Bird.IsOnGround())
                GameOver();

            var centerdPipe = Pipes.FirstOrDefault(p => p.IsCentered());

            if (centerdPipe != null)
            {
                bool hasCollideWithBottom = Bird.DistanceFromGround < centerdPipe.GapBotton - 150;
                bool hasCollideWithTop = Bird.DistanceFromGround + 45> centerdPipe.GapTop - 150;
                
                if (hasCollideWithBottom || hasCollideWithTop)
                    GameOver();
            }
        }

        void ManagePipes()
        {
            if(!Pipes.Any() || Pipes.Last().DistanceFromLeft <= 250)
                Pipes.Add(new PipeModel());

            if (Pipes.First().IsOffScreen())
                Pipes.Remove(Pipes.First());

        }
         void MoveObjects()
        {
            Bird.Fall(_gravity);
            foreach (var pipe in Pipes)
            {
                pipe.Move();
            }
        }
        public void StartGame()
        {
            if (!IsRunning)
            {
                Bird = new BirdModel();
                Pipes = new List<PipeModel>();
                MainLoop();
            }
           
        }

        public void Jump()
        {
            if(IsRunning)
                Bird.Jump();
        }

        public void GameOver()
        {
            IsRunning = false;
        }
    }
}
