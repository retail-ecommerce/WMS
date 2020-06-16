﻿using Coldairarrow.Entity.PB;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coldairarrow.Business.PB
{
    public partial interface IPB_LocationBusiness
    {
        Task<PageResult<PB_Location>> GetDataListAsync(PageInput<ConditionDTO> input);
        Task<List<PB_Location>> GetDataListAsync();
        Task<PB_Location> GetTheDataAsync(string id);
        Task AddDataAsync(PB_Location data);
        Task UpdateDataAsync(PB_Location data);
        Task DeleteDataAsync(List<string> ids);
        //Task ModifyEnableAsync(string Id);
        Task AddDataExlAsync(List<PB_Location> list);
        
    }
}