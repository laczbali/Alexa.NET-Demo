using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Alexa.NET.Request;
using Alexa.NET.Response;
using Alexa.NET.Request.Type;

namespace AlexaDemo.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class EndpointController : ControllerBase
	{
		[HttpPost]
		public SkillResponse FunctionHandler(SkillRequest input)
		{
			IntentRequest intentRequest;
			try
			{
				intentRequest = input.Request as IntentRequest;
			}
			catch(Exception)
			{
				return MakeSkillResponse("Failed to determine input intent");
			}

			switch(intentRequest.Intent.Name)
			{
				case "Hello":
					return MakeSkillResponse("IT'S ALIVE!");

				default:
					return MakeSkillResponse($"I don't know the intent called {intentRequest.Intent.Name}. Sorry.");
			}
		}

		private SkillResponse MakeSkillResponse(string responseText)
		{
			return Alexa.NET.ResponseBuilder.Tell(responseText);
		}
	}
}
