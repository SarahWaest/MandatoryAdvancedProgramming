namespace Mandatory_AdvancedProgramming.Objects
{
    public class CheckForCollision
    {
        public bool Collision(Position creaturePosition, Position obstacleEnemyPosition)
        {
            if (creaturePosition.X > 0 || creaturePosition.X < obstacleEnemyPosition.X - 1 || 
                creaturePosition.Y > 0 || creaturePosition.Y < obstacleEnemyPosition.Y - 1 ||
                creaturePosition.X == obstacleEnemyPosition.X && creaturePosition.Y == obstacleEnemyPosition.Y)
            {
                return false;
            }

            return true;
        }
    }
}