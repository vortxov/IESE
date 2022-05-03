﻿using IESE.Domain.Entities;
using IESE.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IESE.Domain.Repositories.EntityFramework
{
    public class EFDocumentCategoryRepository : IDocumentCategoryRepository //функции CRUD
    {
        private readonly AppDbContext context;
        public EFDocumentCategoryRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task DeleteDocumentCategory(Guid id)
        {
            context.Remove(GetDocumentCategoryById(id));
            context.SaveChanges();
        }

        public DocumentCategory GetDocumentCategoryById(Guid id)
        {
            return context.DocumentCategories.Include(x => x.Documents).FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<DocumentCategory> GetDocumentCatigories()
        {
            return context.DocumentCategories;
        }

        public async Task SaveDocumentCategory(DocumentCategory entity)
        {
            if (context.DocumentCategories.FirstOrDefault(x => x.Id == entity.Id) == null)
            {
                context.DocumentCategories.AddAsync(entity);
                context.SaveChanges();
            }
        }

        public async Task UpdateDocumentCategory(DocumentCategory entity)
        {
            context.DocumentCategories.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
