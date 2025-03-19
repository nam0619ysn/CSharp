using UnityEngine;
namespace Method
{
    public class ParameterDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Monster monster1 = new Monster(100,10);
            Monster.monsetCount++;
            Monster monster2 = new Monster(200, 20);
            Monster.monsetCount++;


            monster1.TakeDamage(monster2.atk);
            monster2.TakeDamage(monster1.atk);
            //MonsterBattle(monster2, monster1);
            Debug.Log($"monster1 hp:{monster1.hp},atk:{monster1.atk}");
            Debug.Log($"monster2 hp:{monster2.hp},atk:{monster2.atk}");
            Debug.Log($"monster count:{Monster.monsetCount}");

        }
        void MonsterBattle(Monster atkMonster,Monster defMonster)
        {
            defMonster.hp -= atkMonster.atk;
        }
        public class Monster
        {
            public static int monsetCount = 0;
            public int hp;
            public int atk;

            public Monster(int hp, int atk)
            {
                this.hp = hp;
                this.atk = atk;
            }
            public void TakeDamage(/*Monster this,*/ int damage)
            {
            this.hp -= damage;
            }

        }


       
    }
}