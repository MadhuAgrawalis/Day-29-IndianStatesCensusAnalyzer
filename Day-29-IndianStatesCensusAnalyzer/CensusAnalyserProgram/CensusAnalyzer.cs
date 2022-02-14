using System;
using System.Collections.Generic;

namespace CensusAnalyserProgram
{
    internal class CensusAnalyzer
    {
        public static implicit operator CensusAnalyzer(CensusAnalyserTest.CensusAnalyzer v)
        {
            throw new NotImplementedException();
        }

        internal Dictionary<string, CensusAnalyserTest.CensusDTO> LoadCensusData(object iNDIA, string indianStateCensusFilePath, string indianStateCensusHeaders)
        {
            throw new NotImplementedException();
        }
    }
}