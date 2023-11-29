﻿using KOMiT.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOMiT.App.Service
{
    public interface IProjectService
    {
        Task<ICollection<Project>> GetAll();
        Task<Project> GetDetailsById(int id);
        Task CreateProject(Project project);
    }
    
}
