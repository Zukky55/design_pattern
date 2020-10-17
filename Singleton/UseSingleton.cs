namespace Singleton
{
    class UseSingleton
    {
        /// <summary>
        /// 一意なインスタンス
        /// </summary>
        static UseSingleton instance;
        
        /// <summary>
        /// mutexロック。ロック内のスレッド直列化を保障する
        /// </summary>
        static object lockObj = new object();
        /// <summary>
        /// インスタンスが持つID
        /// </summary>
        int instanceID;

        /// <summary>
        /// コンストラクタ
        /// NOTE: newさせたくないのでprivate.
        /// </summary>
        private UseSingleton()
        {
            var rand = new System.Random();
            this.instanceID = rand.Next();
        }

        /// <summary>
        /// 一意なインスタンスを取得する。
        /// </summary>
        /// <returns></returns>
        public static UseSingleton GetInstance()
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new UseSingleton();
                }
                return instance;
            }
        }

        public int GetInstanceID() => instanceID;
    }
}
