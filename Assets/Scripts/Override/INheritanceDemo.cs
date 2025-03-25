using UnityEngine;
namespace Override
{
    public class INheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Player player = new Player(100, 30);
            Goblin go = new Goblin(50, 10);
            Skeleton sk = new Skeleton(100, 20);
            Zombie zb = new Zombie(200, 30);

            player.TakeDamage(go);
            DrawHealth(player);
            player.TakeDamage(sk);
            DrawHealth(player); 
            player.TakeDamage(zb);
            DrawHealth(player);

            go.TakeDamage(player);
            DrawHealth(go);
            sk.TakeDamage(player);
            DrawHealth(sk);
            zb.TakeDamage(player);
            DrawHealth(zb);

        }


        public void DrawHealth(Character ch)
        {
            Debug.Log($"{ch}:{ch.health}");
        }

        //public void DrawPlayerHealth(Player player)
        //{
        //    Debug.Log($"{player}:{player.health}");
        //}
        //public void DrawGoblinHealth(Goblin goblin)
        //{
        //    Debug.Log($"{goblin}:{goblin.health}");
        //}
        //public void DrawSkeletonHealth(Skeleton skeleton)
        //{
        //    Debug.Log($"{skeleton}:{skeleton.health}");
        //} 
        //public void DrawZombieHealth(Zombie zombie)
        //{
        //    Debug.Log($"{zombie}:{zombie.health}");
        //}
    }
}