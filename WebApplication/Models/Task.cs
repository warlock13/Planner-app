using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Task
    {
        public int ID { get; set; }
        [DisplayName("Название")] public string Name { get; set; }
        [DisplayName("Описание")] public string Description { get; set; }
        [DisplayName("Дата выполнения")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Закрепить")] public Boolean isActive { get; set; }
        [DisplayName("Просрочено")] public Boolean isActual { get; set; }
    }
}