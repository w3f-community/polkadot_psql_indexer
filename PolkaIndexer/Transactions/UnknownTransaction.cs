﻿using Polkadot.Data;

namespace PolkaIndexer
{
    internal class UnknownTransaction : ISpecificTransaction
    {
        public void Execute(int transactionId)
        {
            // Empty method. That is unknown specific transaction 
        }

        public bool Parse(BlockHash bh, SignedBlock sb, string extrinsic)
        {
            return true;
        }
    }
}