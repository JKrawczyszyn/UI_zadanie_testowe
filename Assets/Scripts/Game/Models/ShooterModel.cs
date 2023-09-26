using UnityEngine;

namespace Game.Models
{
    public class ShooterModel
    {
        public int Id { get; }
        public Vector2 Position { get; }
        public int Angle { get; set; }
        public int Lives { get; }
        public float NextTurnTime { get; set; }
        public float SpawnTime { get; set; }
        public double NextShootTime { get; set; }
        public bool Active { get; set; }

        public ShooterModel(int id, Vector2 position, int angle, int lives, float nextTurnTime, float spawnTime,
            float nextShootTime)
        {
            Id = id;
            Position = position;
            Angle = angle;
            Lives = lives;
            NextTurnTime = nextTurnTime;
            SpawnTime = spawnTime;
            NextShootTime = nextShootTime;
            Active = false;
        }
    }
}
