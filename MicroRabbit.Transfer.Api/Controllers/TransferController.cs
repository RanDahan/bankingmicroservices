using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroRabbit.Transfer.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TransferController : ControllerBase
	{		
		private readonly ILogger<TransferController> _logger;
		private readonly ITransferService _transferService;

		public TransferController(ILogger<TransferController> logger, ITransferService transferService)
		{
			_logger = logger;
			_transferService = transferService;
		}

		// GET api/transfer
		[HttpGet]
		public ActionResult<IEnumerable<TransferLog>> Get()
		{
			return Ok(_transferService.GetTransferLogs());
		}
	}
}
