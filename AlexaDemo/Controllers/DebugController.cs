using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlexaDemo.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class DebugController : ControllerBase
	{
		[HttpGet]
		public string TestMethod()
		{
			return "Hello There";
		}
	}
}
