using System;
using System.Collections;

namespace Lesson4_练习题
{
    #region 练习题一
    //请描述Hashtable的存储规则

    // 一个键值对形式存储的 容器
    // 一个键 对应一个值
    // 类型是object
    #endregion
    //制作一个怪物管理器，提供创建怪物
    //移除怪物的方法。每个怪物都有自己的唯一ID
    
    /// <summary>
    /// 怪物管理器 因为一般 管理器 都是唯一的 所以把它做成 一个单例模式的对象
    /// </summary>
    #region 练习题二
    
    class MonsterMgr{
        // HashTable hashTable = new HashTable();
        // hashTable.Add(1, new Monster(1,"123"));
        // hashTable.Add(2, new Monster(1,"123"));
        // hashTable.Add(3, new Monster(3,"123")); 
        // hashTable.Remove(1);

        //内部定义一个静态管理器对象，以实现单例
        private static MonsterMgr instance = new MonsterMgr();
        private MonsterMgr{

        }

        //通过共有成员属性实现私有变量外部访问控制
        public static MonsterMgr Instance{
            return instance;
        }

        private int index = 0;
        private Hashtable monsterTable;
        public void AddMonster(Monster monster){
            monsterTable.Add(index, monster);
            index++;
        }
        public void RemoveMonster(int monsterId){
            if(monsterTable.Contains(monsterId)){
                monsterTable.Remove(monsterId);
            }else{
                Console.WriteLine("没有该对象")；
            }
        }
    }

    class Monster{
        public int id;
        public string monsterName;
        Monster(int id, string monsterName){
            this.id = id;
            this.monsterName = monsterName;
        }
    }

    class MonsterMgr
    {
        private static MonsterMgr instance = new MonsterMgr();

        private Hashtable monstersTable = new Hashtable();

        private MonsterMgr()
        {

        }

        public static MonsterMgr Instance
        {
            get
            {
                return instance;
            }
        }

        private int monsterID = 0;

        public void AddMonster()
        {
            Monster monster = new Monster(monsterID);
            Console.WriteLine("创建了id为{0}的怪物", monsterID);
            ++monsterID;
            //Hashtable 的键 是不能重复的 所以一定是用唯一ID
            monstersTable.Add(monster.id, monster);
        }

        public void RemoveMonster(int monsterID)
        {
            if( monstersTable.ContainsKey(monsterID) )
            {
                (monstersTable[monsterID] as Monster).Dead();
                monstersTable.Remove(monsterID);
            }
        }
    }

    class Monster
    {
        public int id;

        public Monster(int id)
        {
            this.id = id;
        }

        public void Dead()
        {
            Console.WriteLine("怪物{0}死亡", id);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable练习题");

            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();

            MonsterMgr.Instance.RemoveMonster(0);
            MonsterMgr.Instance.RemoveMonster(3);
        }
    }
}
