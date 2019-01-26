using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.DAL
{
    public class PlannerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PlannerContext>
    {
        protected override void Seed(PlannerContext context)
        {
            var tesks = new List<Task>
            {
            new Task{Name="Молоко",Description="Купить в магазине",Date=DateTime.Parse("2005-01-01")},
            new Task{Name="Хлеб",Description="Заготовить тесто",Date=DateTime.Parse("2025-01-01")},
            new Task{Name="Уборка",Description="Пропылесосить и помыть пол",Date=DateTime.Parse("2019-01-25")},
            new Task{Name="Мусор",Description="Вынести мусор и натянуть чистый пакет на урну",Date=DateTime.Parse("2012-01-01")},
            new Task{Name="Ужин",Description="Приготовить что-то легкое на ужин",Date=DateTime.Parse("2019-02-13")}
            };

            tesks.ForEach(s => context.Tasks.Add(s));
            context.SaveChanges();
     
        }
    }
}