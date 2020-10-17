namespace Singleton
{
    class NotUseSingleton
    {
        /// <summary>
        /// インスタンスが持つID
        /// </summary>
        int instanceID;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public NotUseSingleton()
        {
            var rand = new System.Random();
            this.instanceID = rand.Next();
        }

        /// <summary>
        /// インスタンスのIDを取得
        /// </summary>
        /// <returns>インスタンスID</returns>
        public int GetInstanceID() => instanceID;
    }
}
