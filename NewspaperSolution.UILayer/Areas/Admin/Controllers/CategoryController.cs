using NewspaperSolution.DataAccessLayer.Repository.Concrete.EfRepository;
using NewspaperSolution.EntityLayer.Entities.Concrete;
using NewspaperSolution.EntityLayer.Enums;
using NewspaperSolution.UILayer.Areas.Admin.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewspaperSolution.UILayer.Areas.Admin.Controllers
{
    public class CategoryController:Controller
    {
        private EfCategoryRepository _repo;

        public CategoryController() => _repo = new EfCategoryRepository();

        // GET: Admin/Category
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category data)
        {
            _repo.Add(data);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult List() => View(_repo.GetActive());

        public ActionResult Update(int id)
        {
            Category category = _repo.GetById(id);
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.Id = category.id;
            categoryDTO.Name = category.Name;
            return View(categoryDTO);
        }

        [HttpPost]
        public ActionResult Update(CategoryDTO model)
        {
            Category category = _repo.GetById(model.Id);
            category.Name = model.Name;
            category.ModifiedDate = DateTime.Now;
            category.status = Status.Modified;
            _repo.Update(category);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult Delete(int id)
        {
            _repo.Remove(id);
            return Redirect("/Admin/Category/List");
        }
    }
}