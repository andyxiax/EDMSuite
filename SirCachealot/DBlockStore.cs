using System;
using System.Collections.Generic;
using System.Text;

using Analysis.EDM;

namespace SirCachealot
{
    
    public interface DBlockStore
    {
        UInt32[] GetUIDsByCluster(string clusterName, UInt32[] fromUIDs);
        UInt32[] GetUIDsByCluster(string clusterName);

        UInt32[] GetUIDsByTag(string tag, UInt32[] fromUIDs);
        UInt32[] GetUIDsByTag(string tag);

        UInt32[] GetUIDsByAnalysisTag(string tag, UInt32[] fromUIDs);
        UInt32[] GetUIDsByAnalysisTag(string tag);

        UInt32[] GetUIDsByMachineState(bool eState, bool bState, UInt32[] fromUIDs);
        UInt32[] GetUIDsByMachineState(bool eState, bool bState);

        UInt32[] GetUIDsByDateRange(DateTime start, DateTime end, UInt32[] fromUIDs);
        UInt32[] GetUIDsByDateRange(DateTime start, DateTime end);

        UInt32[] GetUIDsByPredicate(PredicateFunction func, UInt32[] fromUIDs);

        DemodulatedBlock GetDBlock(UInt32 uid);
       
        UInt32 AddDBlock(DemodulatedBlock db);
  
        void RemoveDBlock(UInt32 uid);
        
        void AddTagToBlock(string clusterName, int blockIndex, string tag);
        
        void RemoveTagToBlock(string clusterName, int blockIndex, string tag);
    }

    public delegate bool PredicateFunction(DemodulatedBlock dblock);

}