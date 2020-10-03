using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwo_Repo
{
    public class ClaimsDataRepo
    {
        public List<ClaimsData> _listOfClaimsData = new List<ClaimsData>();

        //enter new claim
        public void AddClaimToList(ClaimsData data)
        {
            _listOfClaimsData.Add(data);
        }
    
        //view all claims
        public List<ClaimsData> GetDataList()
        {
            return _listOfClaimsData;
        }

        public ClaimsData GetContentByRequiresAttention(bool requiresAttention)
        {
            foreach(ClaimsData data in _listOfClaimsData)
            {
                if(data.RequiresAttention == true)
                {
                    return data;
                }
                else 
                {
                    return null;
                }
            }
           
        }

    }
}
