﻿using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Services;

namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // 404 is only for when there is no such endpoint or resource, not for when there is no data
        // 204 is the correct status code for when there is no data 
        // to return 204, use NoContent() instead of Ok(null)

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles(int pageNumber = 1, int pageSize = 10)
        {
            try
            {
                var response = await _roleService.GetAll(pageNumber, pageSize).ConfigureAwait(false);
                return response != null ? Ok(response) : NoContent(); 
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetRoleById(int id)
        {
            try
            {
                if (id <= 0)
                
                    return BadRequest(new { success = false, status = 400, message = "Invalid ID" });

                    var response = await _roleService.GetByID(id).ConfigureAwait(false);

                    return response != null ? Ok(response) : NoContent();
                
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Role>> CreateRole([FromBody] Role role)
        {
            try
            {
                if (role == null)

                    return BadRequest(new { success = false, status = 400, message = "Invalid role" });

                if (!ModelState.IsValid)
                    return BadRequest(new { success = false, status = 400, message = "Invalid role" });

                var response = await _roleService.Create(role).ConfigureAwait(false);

                return CreatedAtAction(nameof(GetRoleById), new { id = response.Id }, response);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Role>> UpdateRole([FromBody] Role role)
        {
            try
            {
                if (role == null)
                    return BadRequest(new { success = false, status = 400, message = "Invalid role" });

                if (!ModelState.IsValid)
                    return BadRequest(new { success = false, status = 400, message = "Invalid role" });

                var response = await _roleService.Update(role).ConfigureAwait(false);

                return AcceptedAtAction(nameof(GetRoleById), new { id = response.Id }, response);
                
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Role>> DeleteRole(int id)
        {
            try
            {
               
                if (!ModelState.IsValid)
                    return BadRequest(new { success = false, status = 400, message = "Invalid role" });

                var response = await _roleService.Delete(id).ConfigureAwait(false);

                return AcceptedAtAction(nameof(DeleteRole));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
