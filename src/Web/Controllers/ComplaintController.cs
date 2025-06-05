using Application.Interfaces;
using Application.Models.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private readonly IComplaintService _complaintService;
        public ComplaintController(IComplaintService complaintService) 
        {
            _complaintService = complaintService;
        }

        [HttpGet("[action]")]
        [Authorize(Policy ="SysAdminOrSupportPolicy")]
        public async Task<ActionResult<List<ComplaintDTO>>> GetAllComplaint()
        {
            var complaints = await _complaintService.GetAllComplaint();
            return Ok(complaints);
        }


        [HttpPost("[action]")]
        [Authorize(Policy ="ClientPolicy")]
        public async Task<ActionResult<Complaint>> CreateComplaint(string description)
        {
            var complaint = await _complaintService.CreateComplaint(description, User.GetUserIntId());
            return Ok(complaint);
        }

        [HttpPatch("[action]")]
        [Authorize(Policy = "SupportPolicy")]
        public async Task<IActionResult> CompleteComplaint(int complaintId)
        {
            try
            {
                await _complaintService.CompleteComplaint(complaintId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
