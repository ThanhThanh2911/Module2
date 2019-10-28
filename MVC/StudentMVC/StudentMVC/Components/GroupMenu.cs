using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Components
{
    public class GroupMenu : ViewComponent
    {
        private readonly IGroupRepository groupRepository;

        public GroupMenu(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        public IViewComponentResult Invoke()
        {
            var groups = groupRepository.GetAll.OrderBy(g => g.GroupName);

            return View(groups);
        }
    }
}
