using System;
using System.Numerics;

public static class CollisionDetection
{
    public class BoundingBox
    {
        public Vector3 Size { get; set; }

        public BoundingBox(Vector3 size)
        {
            Size = size;
        }
    }

    public class Entity
    {
        public Vector3 Location { get; set; }
        public BoundingBox BoundingBox { get; set; }

        public Entity(Vector3 location, BoundingBox boundingBox)
        {
            Location = location;
            BoundingBox = boundingBox;
        }
    }

    public class Obstacle
    {
        public Vector3 Location { get; set; }
        public BoundingBox BoundingBox { get; set; }

        public Obstacle(Vector3 location, BoundingBox boundingBox)
        {
            Location = location;
            BoundingBox = boundingBox;
        }
    }

    public class Structure
    {
        public Vector3 Location { get; set; }
        public BoundingBox BoundingBox { get; set; }

        public Structure(Vector3 location, BoundingBox boundingBox)
        {
            Location = location;
            BoundingBox = boundingBox;
        }
    }

    public class Projectile
    {
        public Vector3 Location { get; set; }
        public BoundingBox BoundingBox { get; set; }

        public Projectile(Vector3 location, BoundingBox boundingBox)
        {
            Location = location;
            BoundingBox = boundingBox;
        }
    }

    public static bool CheckCollision(Entity entity1, Entity entity2)
    {
        return CheckCollision(entity1.Location, entity1.BoundingBox, entity2.Location, entity2.BoundingBox);
    }

    public static bool CheckCollision(Entity entity, Obstacle obstacle)
    {
        return CheckCollision(entity.Location, entity.BoundingBox, obstacle.Location, obstacle.BoundingBox);
    }

    public static bool CheckCollision(Entity entity, Structure structure)
    {
        return CheckCollision(entity.Location, entity.BoundingBox, structure.Location, structure.BoundingBox);
    }

    public static bool CheckCollision(Entity entity, Projectile projectile)
    {
        return CheckCollision(entity.Location, entity.BoundingBox, projectile.Location, projectile.BoundingBox);
    }

    private static bool CheckCollision(Vector3 loc1, BoundingBox box1, Vector3 loc2, BoundingBox box2)
    {
        return
            loc1.X < loc2.X + box2.Size.X && loc1.X + box1.Size.X > loc2.X &&
            loc1.Y < loc2.Y + box2.Size.Y && loc1.Y + box1.Size.Y > loc2.Y &&
            loc1.Z < loc2.Z + box2.Size.Z && loc1.Z + box1.Size.Z > loc2.Z;
    }
}
