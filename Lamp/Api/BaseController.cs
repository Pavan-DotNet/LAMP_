//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using DataModel;
//using Lamp.Repo;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Caching.Memory;

//namespace Lamp.Api
//{
//    [Produces("application/json")]
//    public class BaseController : Controller
//    {

//        private IMemoryCache _cache;

//        public BaseController(IMemoryCache memoryCache)
//        {
//            _cache = memoryCache;
//        }


//        public async Task<bool> CheckorUpdateCache()
//        {
//            try
//            {
//                List<lamp_bp_profile_vw> AllData = _cache.Get("GetAllData") as List<lamp_bp_profile_vw>;
//                if (AllData == null)
//                {
//                    AllData = await HomeRepo.GetAllData();
//                    _cache.Set("GetAllData", AllData, DateTimeOffset.UtcNow.AddHours(24));
//                }
//                return true;
//            }
//            catch (Exception ex) { return false; }
//        }

//        public static IEnumerable<object> GetCache()
//        {
//            List<lamp_bp_profile_vw> AllData = _cache.Get("GetAllData") as List<lamp_bp_profile_vw>;
//            return AllData;
//        }
//    }
//}