using System;

namespace NoShake
{
    public class SingleOperationController
    {
        public void StartOperationWeak()
        {
            lock(_sO)
            {
                throw new NotImplementedException();
            }
        }
        public void StartOperationStrong()
        {
            lock (_sO)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private object _sO = new object();
    }
}
