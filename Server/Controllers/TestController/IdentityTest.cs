using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace QuanLyNongTrai.Test
{
    [Route("api/test/identity")]
    [Authorize]
    public class IdentityTest : Controller{
        [HttpGet]
        public string[] GetString(){
            return new string[] {
                "account 1",
                "account 2",
                "account 3",
                "account 4"
            };
        }
    }
}