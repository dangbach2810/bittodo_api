﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using WebProjectManager.Common.Authentication;
using WebProjectManager.Common.ViewModel;
using WebProjectManager.Models.EF;
using WebProjectManager.Models.Entities;

namespace WebProjectManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabsController : Controller
    {
        private readonly EFCoreDbContext _context;

        public TabsController(EFCoreDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Tab>>> Get(Guid id)
        {
            var data = await _context.Tabs.Where(x => x.ProjectId==id)
                .Include(x => x.Cards.OrderBy(c=>c.Order))
                    .ThenInclude(it => it.Tasks.OrderBy(d=>d.Order))
                        

                .ToListAsync();
            return Ok(data);
        }
        [HttpGet("Complete/{id}")]
        public async Task<ActionResult<IEnumerable<Tab>>> GetCompleteProject(Guid Id)
        {
            string tokenString = Request.Headers["Authorization"].ToString();
            var infoFromToken = Auths.GetInfoFromToken(tokenString);
            var userId = infoFromToken.Result.UserId;
            // var dataProject = _context.Projects.Where(x => x.CreatedBy == Guid.Parse(userId) && x.Id == Id);
            /* var data = await _context.Tabs
             .Where(x => x.ProjectId == Id)
             .Include(x => x.Cards.OrderBy(c => c.Order))
             .ToListAsync();

             var cardLists = data.Select(tab => tab.Cards.ToList()).ToList();*/
            /*var cards = await _context.Cards.Where(c => c.Tab.ProjectId == Id).OrderBy(c => c.Order).ToListAsync();*/
            var cards = await _context.Cards
            .Where(c => c.Tab.ProjectId == Id && c.Tasks.All(t => t.IsActive == true))
            .OrderBy(c => c.Order)
            .ToListAsync();
            return Ok(cards);
        }
        [HttpPost("{id}")]
        public async Task<ActionResult<Tab>> Post(TabViewModel model, Guid id)
        {
            string tokenString = Request.Headers["Authorization"].ToString();
            var infoFromToken = Auths.GetInfoFromToken(tokenString);
            var userId = infoFromToken.Result.UserId;
            Tab createItem = new Tab()
            {
                Id = Guid.NewGuid(),
                CreatedBy = Guid.Parse(userId),
                ProjectId = id,
                Name = model.Name,
                CreatedOn = DateTime.Now,
                TimeExpiry = model.TimeExpiry,
                IsActive = model.IsActive,
                Order = model.Order,
            };
            _context.Tabs.Add(createItem);
            await _context.SaveChangesAsync();
            return Ok(createItem);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Tab>> Put(TabViewModel model, Guid id)
        {
            string tokenString = Request.Headers["Authorization"].ToString();
            var infoFromToken = Auths.GetInfoFromToken(tokenString);
            var userId = infoFromToken.Result.UserId;
            var project = _context.Tabs.FirstOrDefault(x => x.Id == id);
            if (project == null)
            {
                return BadRequest();
            }
            if (model.Name != null && model.Name != "")
            {
                project.Name = model.Name;
            }
            if (model.IsActive != null)
            {
                project.IsActive = model.IsActive;
            }
            if (model.TimeExpiry != null)
            {
                project.TimeExpiry = model.TimeExpiry;
            }
            if (model.Order != null)
            {
                project.Order = model.Order;
            }
            _context.Entry(project).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(project);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            string tokenString = Request.Headers["Authorization"].ToString();
            var infoFromToken = Auths.GetInfoFromToken(tokenString);
            var userId = infoFromToken.Result.UserId;
            var project = _context.Tabs.FirstOrDefault(x => x.Id == id);
            if (project == null)
            {
                return BadRequest();
            }
            var lsCard = _context.Cards.Where(x=>x.TabId == id).ToList();
            foreach (var item in lsCard)
            {
                var lsTask = _context.Tasks.Where(x => x.CardId == item.Id).ToList();
                foreach (var items in lsTask)
                {
                    _context.Remove(items);
                }
                _context.Remove(item);
            }
            _context.Remove(project);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Id/{idTab}")]
        public ActionResult<Tab> GetById(Guid idTab)
        {
            var project = _context.Tabs.FirstOrDefault(x => x.Id == idTab);
            if (project == null)
            {
                return BadRequest();
            }
            return Ok(project);
        }
        [HttpPut("Name/{id}")]
        public async Task<ActionResult<Tab>> PutName(UpdateNameViewModel model, Guid id)
        {
            string tokenString = Request.Headers["Authorization"].ToString();
            var infoFromToken = Auths.GetInfoFromToken(tokenString);
            var userId = infoFromToken.Result.UserId;
            var project = _context.Tabs.FirstOrDefault(x => x.Id == id);
            if (project == null)
            {
                return BadRequest();
            }
            if (model.Name != null && model.Name != "")
            {
                project.Name = model.Name;
            }
            _context.Entry(project).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(project);
        }
    }
}
