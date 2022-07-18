using System;

namespace Maszyna
{
    interface Machine 
    {
        void Store();
        void Refill();
        void ConditionCheck();
        void GetMoney();
        void StanKonta();
        void Exit();
    }
}