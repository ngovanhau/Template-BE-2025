using BE.Common.Controllers;
using BE.Service;
using Microsoft.AspNetCore.Mvc;

namespace BE.Controllers
{
    public class R5EVENTSController(IServiceProvider services) : BaseV1Controller<R5EVENTSService>(services)
    {
        /// <summary>
        /// Get By WoCode
        /// </summary>
        /// 
        [HttpGet("GetByWo")]
        public async Task<IActionResult> GetByWo(string WO_CODE)
        {
            var result = await _service.GetByWo(WO_CODE);
            return Success(result);
        }
    }
}
